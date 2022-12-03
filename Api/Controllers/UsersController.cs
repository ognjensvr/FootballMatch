﻿using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public User GetUserById()
        {
            var user = new User
            {
                Id = 1,
                Name = "Ognjen",
                Surname = "Svrkota",
                Age = 21,
                DateOfBirth = DateTime.Now,
                Statistics = new PlayerStatistics
                {
                    NumberOfGoals = 10
                },
                Club = new Club
                {
                    Name = "Crvena Zvezda"
                },
                Role = new Role
                {
                    Name = "Player"
                }
            }                
        ;        
            return user;
            var user2 = new User
            {
                Id = 2,
                Name = "Marko",
                Surname = "Maric",
                Age = 24,
                DateOfBirth = DateTime.Now,
                Statistics = new PlayerStatistics
                {
                    NumberOfGoals = 21
                },
                Club = new Club
                {
                    Name = "Partizan"
                },
                Role = new Role
                {
                    Name = "Player"
                }
            };  
        }
    }
}