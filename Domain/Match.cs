using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Match
    {
        public int Id { get; set; }
        public int Host { get; set; }
        public int Guest { get; set; }
        public int HostGoals { get; set; }
        public int GuestGoals { get; set; }
        public int Winner { get; set; }
    }
}
