using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchingClassDiagram.DTO
{
    class SearchUserDTO
    {
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string isdn;

        public string Isdn
        {
            get { return isdn; }
            set { isdn = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }        
    }
}
