using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SearchingClassDiagram.DTO;
using SearchingClassDiagram.DAO;

namespace SearchingClassDiagram.BUS
{
    class SearchRequestBUS
    {
        private SearchRequestDTO dto;
        private SearchRequestDAO dao;
        public SearchRequestBUS()
        {
            dto = new SearchRequestDTO();
            dao = new SearchRequestDAO();
        }
        public SearchRequestBUS(SearchRequestDAO dao, SearchRequestDTO dto)
        {
            this.dao = dao;
            this.dto = dto;
        }
        public DataSet SearchAllRequests()
        {
            return dao.SearchAllRequests();
        }
        public DataSet SearchRequests(SearchRequestDTO dto)
        {
            return dao.SearchRequests(dto);
        }
    }
}
