using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SearchingClassDiagram.DTO;

namespace SearchingClassDiagram.DAO
{
    class SearchUserDAO
    {
        private SearchUserDTO dto;
        public SearchUserDAO()
        {
            dto = new SearchUserDTO();
        }

        public SearchUserDAO(SearchUserDTO dto)
        {
            this.dto = dto;
        }

        public DataSet SearchAllUsers()
        {
            return new DataSet();
        }

        public DataSet SearchUsers(SearchUserDTO dto)
        {
            return new DataSet();
        }
    }
}
