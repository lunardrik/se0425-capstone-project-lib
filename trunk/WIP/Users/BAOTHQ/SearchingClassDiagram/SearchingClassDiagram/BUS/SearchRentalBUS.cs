using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SearchingClassDiagram.DTO;
using SearchingClassDiagram.DAO;

namespace SearchingClassDiagram.BUS
{
    class SearchRentalBUS
    {
        private SearchRentalDTO dto;
        private SearchRentalDAO dao;

        public SearchRentalBUS()
        {
            dto = new SearchRentalDTO();
            dao = new SearchRentalDAO();
        }

        public SearchRentalBUS(SearchRentalDTO dto, SearchRentalDAO dao)
        {
            this.dao = dao;
            this.dto = dto;
        }

        public DataSet SearchAllRentals()
        {
            return dao.SearchAllRentals();
        }

        public DataSet SearchRentals(SearchRentalDTO dto)
        {
            return dao.SearchRentals(dto);
        }
    }
}
