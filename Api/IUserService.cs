using Api.ViewModels;
using DocumentFormat.OpenXml.Spreadsheet;
using Domain;
using System.Collections.Generic;
namespace Api.Services
{
    public interface IUserService
    {       
        List<User> GetUsersList();
        User GetUserDetailsById(int userId);
        ResponseModel SaveUser(User userModel);
        ResponseModel DeleteUser(int userId);
    }
}