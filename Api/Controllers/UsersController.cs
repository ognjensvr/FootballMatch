using Api.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public string Name { get; private set; }

        [HttpGet] //localhost:5000/users
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
            };
             return user;           
        }
        [HttpGet("list")] // putanja: localhost:5000/users/list
        public List<User> GetAllUsers()
        {
            var users = _userService.GetUsersList();
            return users;
            //List<User> listOfUsers = new List<User>();
            //var user1 = new User
            //{
            //    Id = 1,
            //    Name = "Ognjen",
            //    Surname = "Svrkota",
            //    Age = 21,
            //    DateOfBirth = DateTime.Now,
            //    Statistics = new PlayerStatistics
            //    {
            //        NumberOfGoals = 10
            //    },
            //    Club = new Club
            //    {
            //        Name = "Crvena Zvezda"
            //    },
            //    Role = new Role
            //    {
            //        Name = "Player"
            //    }
            //};
            //var user2 = new User
            //{
            //    Id = 2,
            //    Name = "Marko",
            //    Surname = "Maric",
            //    Age = 25,
            //    DateOfBirth = DateTime.Now,
            //    Statistics = new PlayerStatistics
            //    {
            //        NumberOfGoals = 16
            //    },
            //    Club = new Club
            //    {
            //        Name = "Partizan"
            //    },
            //    Role = new Role
            //    {
            //        Name = "Player"
            //    }
            //};
            //var user3 = new User
            //{
            //    Id = 3,
            //    Name = "Ognjen",
            //    Surname = "Petrovic",
            //    Age = 31,
            //    DateOfBirth = DateTime.Now,
            //    Statistics = new PlayerStatistics
            //    {
            //        NumberOfGoals = 3
            //    },
            //    Club = new Club
            //    {
            //        Name = "Vojvodina"
            //    },
            //    Role = new Role
            //    {
            //        Name = "Player"
            //    }
            //};
            //listOfUsers.Add(user1);
            //listOfUsers.Add(user2);
            //listOfUsers.Add(user3);
            //List<User> filteredList = new List<User>();
            //foreach (var user in listOfUsers)
            //{
            //    if (user.Age < 30 && user.Name == "Ognjen")
            //    {
            //        filteredList.Add(user);
            //    }
            //}
            //return filteredList;
        }
        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetUsersById(int Id)
        {
            try
            {
                var users = _userService.GetUserDetailsById(Id);
                if (users == null) return NotFound();
                return Ok(users);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveUsers(User userModel)
        {
            try
            {
                var model = _userService.SaveUser(userModel);
                return Ok(model);
            }catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteUsers(int Id)
        {
            try
            {
                var model = _userService.DeleteUser(Id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}