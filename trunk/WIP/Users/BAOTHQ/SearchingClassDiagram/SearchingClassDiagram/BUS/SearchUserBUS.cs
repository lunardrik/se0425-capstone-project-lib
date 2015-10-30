using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SearchingClassDiagram.DTO;
using SearchingClassDiagram.DAO;

namespace SearchingClassDiagram.BUS
{
    class SearchUserBUS
    {
        private SearchUserDTO dto;
        private SearchUserDAO dao;

        public SearchUserBUS()
        {
            dto = new SearchUserDTO();
            dto = new SearchUserDTO();
        }

        public SearchUserBUS(SearchUserDAO dao, SearchUserDTO dto)
        {
            this.dao = dao;
            this.dto = dto;
        }

        public DataSet SearchAllUsers()
        {
            return dao.SearchAllUsers();
        }

        public DataSet SearchUsers(SearchUserDTO dto)
        {
            return dao.SearchUsers(dto);
        }
    }
}
