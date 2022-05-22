using System;
using System.Collections.Generic;

namespace cricketApp.Models
{
    public partial class Country
    {
        public Country()
        {
            MatchesTeam1Navigation = new HashSet<Matches>();
            MatchesTeam2Navigation = new HashSet<Matches>();
            Player = new HashSet<Player>();
            Stadium = new HashSet<Stadium>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryContinent { get; set; }
        public string CountryCode { get; set; }

        public ICollection<Matches> MatchesTeam1Navigation { get; set; }
        public ICollection<Matches> MatchesTeam2Navigation { get; set; }
        public ICollection<Player> Player { get; set; }
        public ICollection<Stadium> Stadium { get; set; }
    }
}
