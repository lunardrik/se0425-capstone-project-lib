using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchingClassDiagram.DTO
{
    class SearchRentalDTO
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private bool isExpired;

        public bool IsExpired
        {
            get { return isExpired; }
            set { isExpired = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
