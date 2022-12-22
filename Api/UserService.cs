using Api.Services;
using Api.ViewModels;
using Domain;

namespace Api
{
    public class UserService : IUserService
    {
        private DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public ResponseModel DeleteUser(int userId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                User _temp = GetUserDetailsById(userId);
                if (_temp != null)
                {
                    _context.Remove<User>(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Message = "User Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Message = "User Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Error : " + ex.Message;
            }
            return model;
        }

        public User GetUserDetailsById(int userId)
        {
            User user;
            try
            {
                user = _context.Find < User > (userId);
            }
            catch (Exception) { throw; }
            return user;
        }
        public List<User> GetUsersList()
        {
            List<User> userList;
            try
            {
                userList = _context.Set<User>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return userList;
        }

        public ResponseModel SaveUser(User userModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                User _temp = GetUserDetailsById(userModel.Id);
                if (_temp != null)
                {
                    _temp.Name = userModel.Name;
                    _temp.Surname = userModel.Surname;
                    _temp.Age = userModel.Age;
                    _temp.Club = userModel.Club;
                    _context.Update<User>(_temp);
                    model.Message = "User Update Successfully";
                }
                else
                {
                    _context.Add<User>(userModel);
                    model.Message = "User Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Error:" + ex.Message;
            }
            return model;
        }
    }
}
