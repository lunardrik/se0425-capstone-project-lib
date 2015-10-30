using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LIB
{
    public class SearchRequestBUS
    {
        public List<BookRegisterDTO> SearchRequests(SearchRequestDTO dto)
        {
            SearchRequestDAO dao = new SearchRequestDAO();

            if(dto.Status==0)
            {
                return dao.SearchRequestAllStt(dto);
                //break;
            }
            else
            {
                return dao.SearchRequests(dto);
            }
        }
    }
}
