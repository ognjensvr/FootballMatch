using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Club
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? FoundingDate { get; set; }
        public ClubStatistics? Statistics { get; set; }
    }
}