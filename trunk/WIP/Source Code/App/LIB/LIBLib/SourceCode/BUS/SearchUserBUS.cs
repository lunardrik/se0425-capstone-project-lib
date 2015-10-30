using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LIB
{
    public class SearchUserBUS
    {
        public List<UserDTO> SearchUsers(SearchUserDTO dto)
        {
            SearchUserDAO dao=new SearchUserDAO();
            //int pageSize = Options.NumberOfRecord;
            //int rowStart = 0;
            //if (dto.PageNumber == 1)
            //{
            //    rowStart = 1;
            //}
            //else
            //{
            //    rowStart = (dto.PageNumber - 1) * pageSize;
            //}
            //int rowEnd = rowStart - 1 + pageSize;
            if (dto.Status == 1)
            {
                return dao.SearchUsers(dto);
            }
            return null;
        }

        public List<SearchUserDAO.SimpleUser> SearchSimpleUser(SearchUserDTO dto)
        {
            SearchUserDAO dao = new SearchUserDAO();
            return dao.SimplySearchUser(dto);
        }
    }
}
