using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LIB
{
    public class SearchRentalBUS
    {
        public List<RentalDTO> SearchRentals(SearchRentalDTO dto)
        {
            SearchRentalDAO dao = new SearchRentalDAO();

            if(dto.Status==0)
            {
                return dao.SearchRentalsAllStt(dto);
            }
            else
            {
                return dao.SearchRentals(dto);    
            }
            
        }
    }
}
