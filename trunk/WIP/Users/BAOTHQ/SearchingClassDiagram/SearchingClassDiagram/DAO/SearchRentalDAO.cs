using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SearchingClassDiagram.DTO;

namespace SearchingClassDiagram.DAO
{
    class SearchRentalDAO
    {
        private SearchRentalDTO dto;

        public SearchRentalDAO()
        {
            dto = new SearchRentalDTO();
        }

        public SearchRentalDAO(SearchRentalDTO dto)
        {
            this.dto = dto;
        }

        public DataSet SearchAllRentals()
        {
            return new DataSet();
        }

        public DataSet SearchRentals(SearchRentalDTO dto)
        {
            return new DataSet();
        }
    }
}
