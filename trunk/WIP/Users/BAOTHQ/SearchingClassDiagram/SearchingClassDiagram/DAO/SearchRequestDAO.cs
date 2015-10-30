using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SearchingClassDiagram.DTO;

namespace SearchingClassDiagram.DAO
{
    class SearchRequestDAO
    {
        private SearchRequestDTO dto;
        public SearchRequestDAO()
        {
            dto = new SearchRequestDTO();
        }
        public SearchRequestDAO(SearchRequestDTO dto)
        {
            this.dto = dto;
        }
        public DataSet SearchAllRequests()
        {
            return new DataSet();
        }
        public DataSet SearchRequests(SearchRequestDTO dto)
        {
            return new DataSet();
        }
    }
}
