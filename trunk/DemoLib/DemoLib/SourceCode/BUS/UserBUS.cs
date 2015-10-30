using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class UserBUS
    {
        private UserDAO UserDAO
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void insertUser(UserDTO user)
        {
            throw new System.NotImplementedException();
        }

        public void updateUser(UserDTO user)
        {
            throw new System.NotImplementedException();
        }

        public UserDTO getUserByUsername(string userID)
        {
            throw new System.NotImplementedException();
        }
    }
}
