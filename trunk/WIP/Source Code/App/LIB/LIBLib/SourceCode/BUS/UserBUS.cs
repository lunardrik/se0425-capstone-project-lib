using System;
using System.Collections.Generic;

namespace LIB
{
    public class UserBUS
    {
        private readonly UserDAO _userDao = new UserDAO();

        public bool InsertUser(UserDTO user)
        {
            return _userDao.Insert(user);
        }

        public bool UpdateUser(UserDTO user)
        {
            return _userDao.Update(user);
        }

        public UserDTO GetUserByUsername(string username)
        {
            return _userDao.GetByUsername(username);
        }

        public UserDTO GetUserById(string userId)
        {
            return _userDao.GetByUserId(userId);
        }

        public List<UserDTO> GetUserAll()
        {
            return _userDao.GetAll();
        }

        public bool Login(string userId, string password)
        {
            var userDto = _userDao.GetByUserId(userId);

            if (userDto == null)
            {
                return false;
            }

            if (!userDto.Password.Equals(Feature.EncodePassword(password)))
            {
                return false;
            }

            Options.User = userDto;
            Log.Info("User Logged In");
            return true;
        }
    }
}