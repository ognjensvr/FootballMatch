using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClubStatistics
    {
        public int Id { get; set; }
        public int NumberOfGoals { get; set; }
        public int NumberOfWins { get; set; }
        public int NumberOfDraws { get; set; }
        public int NumberOfLosses { get; set; }
    }
}
