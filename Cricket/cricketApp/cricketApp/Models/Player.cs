using System;
using System.Collections.Generic;

namespace cricketApp.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int? PlayerAge { get; set; }
        public int? PlayerCountryId { get; set; }

        public Country PlayerCountry { get; set; }
    }
}
