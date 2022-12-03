﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Domain
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PlayerStatistics? Statistics { get; set; }
        public Club? Club { get; set; }
        public Role? Role { get; set; }
    }
}
