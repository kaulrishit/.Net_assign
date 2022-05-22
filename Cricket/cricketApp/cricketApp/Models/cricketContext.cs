using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cricketApp.Models
{
    public partial class cricketContext : DbContext
    {
        public cricketContext()
        {
        }

        public cricketContext(DbContextOptions<cricketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Stadium> Stadium { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=cricket;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountryContinent)
                    .HasColumnName("country_continent")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matches>(entity =>
            {
                entity.HasKey(e => e.MatchId);

                entity.ToTable("matches");

                entity.Property(e => e.MatchId).HasColumnName("match_id");

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatchPlayed)
                    .HasColumnName("match_played")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StadiumId).HasColumnName("stadium_id");

                entity.Property(e => e.Team1).HasColumnName("team1");

                entity.Property(e => e.Team2).HasColumnName("team2");

                entity.HasOne(d => d.Stadium)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.StadiumId)
                    .HasConstraintName("FK__matches__stadium__6477ECF3");

                entity.HasOne(d => d.Team1Navigation)
                    .WithMany(p => p.MatchesTeam1Navigation)
                    .HasForeignKey(d => d.Team1)
                    .HasConstraintName("FK__matches__team1__656C112C");

                entity.HasOne(d => d.Team2Navigation)
                    .WithMany(p => p.MatchesTeam2Navigation)
                    .HasForeignKey(d => d.Team2)
                    .HasConstraintName("FK__matches__team2__66603565");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("player");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.PlayerAge).HasColumnName("player_age");

                entity.Property(e => e.PlayerCountryId).HasColumnName("player_country_id");

                entity.Property(e => e.PlayerName)
                    .HasColumnName("player_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlayerCountry)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.PlayerCountryId)
                    .HasConstraintName("FK__player__player_c__5EBF139D");
            });

            modelBuilder.Entity<Stadium>(entity =>
            {
                entity.ToTable("stadium");

                entity.Property(e => e.StadiumId).HasColumnName("stadium_id");

                entity.Property(e => e.MatchesAllowed).HasColumnName("matches_allowed");

                entity.Property(e => e.StadiumCountry).HasColumnName("stadium_country");

                entity.Property(e => e.StadiumName)
                    .HasColumnName("stadium_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.StadiumCountryNavigation)
                    .WithMany(p => p.Stadium)
                    .HasForeignKey(d => d.StadiumCountry)
                    .HasConstraintName("FK__stadium__stadium__619B8048");
            });
        }
    }
}
