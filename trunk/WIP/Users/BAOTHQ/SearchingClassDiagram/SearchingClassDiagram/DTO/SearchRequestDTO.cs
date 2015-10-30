using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchingClassDiagram.DTO
{
    class SearchRequestDTO
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
        private string requestDate;

        public string RequestDate
        {
            get { return requestDate; }
            set { requestDate = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
