using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PlayerStatistics
    {
        public int Id { get; set; }
        public int NumberOfGoals { get; set; }
        public int NumberOfAssists { get; set; }
        public int NumberOfYellowCards { get; set; }
        public int NumberOfRedCards { get; set; }
        public int NumberOfGames { get; set; }
    }
}
