CREATE DATABASE cricket;

CREATE TABLE country(country_id int primary key identity(1,1),country_name varchar(20),country_continent varchar(20),country_code varchar(5) );
INSERT INTO country values('India','Asia',+'91');
INSERT INTO country values('Pakistan','Asia','+92');
INSERT INTO country values('England','Europe','+44');
INSERT INTO country values('Australia','Australia','+61');
--INSERT INTO country values('South Africa','Africa','+27');

CREATE TABLE player(player_id int primary key identity(1,1),player_name varchar(20),player_age int, player_country_id int foreign key references country(country_id) );
INSERT INTO player values('virat kohli',33,1);
INSERT INTO player values('rohit sharma',34,1);
INSERT INTO player values('shikhar dhawan',35,1);
INSERT INTO player values('kl rahul',29,1);
INSERT INTO player values('sky',31,1);
INSERT INTO player values('dk',37,1);
INSERT INTO player values('hardik pandya',29,1);
INSERT INTO player values('rishab pant',25,1);
INSERT INTO player values('bhuvi',25,1);
INSERT INTO player values('moh. shami',25,1);
INSERT INTO player values('jasprit bumrah',25,1);

INSERT INTO player values('rizwan khan',33,2);
INSERT INTO player values('fakhar zaman',34,2);
INSERT INTO player values('babar azam',35,2);
INSERT INTO player values('imam ul haq',29,2);
INSERT INTO player values('shoaib malik',31,2);
INSERT INTO player values('sarfaraz ahmed',37,2);
INSERT INTO player values('shadab khan',29,2);
INSERT INTO player values('imad wasim',25,2);
INSERT INTO player values('shadab khan',25,2);
INSERT INTO player values('wahab riaz',25,2);
INSERT INTO player values('shaheen afridi',25,2);

INSERT INTO player values('jonny bairstow',33,3);
INSERT INTO player values('joe root',34,3);
INSERT INTO player values('jason roy',35,3);
INSERT INTO player values('james vince',29,3);
INSERT INTO player values('jos buttler',31,3);
INSERT INTO player values('ben stokes',37,3);
INSERT INTO player values('moeen ali',29,3);
INSERT INTO player values('adil rashid',25,3);
INSERT INTO player values('mark wood',25,3);
INSERT INTO player values('liam plunkett',25,3);
INSERT INTO player values('jofra archer',25,3);

INSERT INTO player values('aron finch',33,4);
INSERT INTO player values('david warner',34,4);
INSERT INTO player values('steve smith',35,4);
INSERT INTO player values('mathew wade',29,4);
INSERT INTO player values('marcus stoinis',31,4);
INSERT INTO player values('glenn maxwell',37,4);
INSERT INTO player values('travis head',29,4);
INSERT INTO player values('nathan lyon',25,4);
INSERT INTO player values('pat cummins',25,4);
INSERT INTO player values('josh hazelwood',25,4);
INSERT INTO player values('mitchel starc',25,4);


CREATE TABLE stadium(stadium_id int primary key identity(1,1),stadium_name varchar(20),matches_allowed int, stadium_country int foreign key references country(country_id));
INSERT INTO stadium values('Eden Gardens',2,1);
INSERT INTO stadium values('gaddafi stadium',0,2);
INSERT INTO stadium values('MCG',1,4);
INSERT INTO stadium values('Lords',2,3);

create table matches(match_id int primary key identity(1,1),stadium_id int foreign key references stadium(stadium_id),team1 int foreign key references country(country_id),team2 int foreign key references country(country_id),result varchar(30),date_time datetime,match_played varchar(30));
insert into matches values(1,1,4,'India','2022-05-01 19:00:00','yes');
insert into matches values(2,2,3,'England','2022-05-05 19:00:00','yes');
insert into matches values(3,3,1,'India','2022-05-11 19:00:00','yes');
insert into matches values(1,1,2,'India','2022-05-14 19:00:00','yes');
insert into matches values(3,4,3,'Australia','2022-05-20 19:00:00','yes');
insert into matches values(4,3,2,'England','2022-05-23 19:00:00','yes');

select * from country;
select * from player;
select * from stadium;
select * from matches;