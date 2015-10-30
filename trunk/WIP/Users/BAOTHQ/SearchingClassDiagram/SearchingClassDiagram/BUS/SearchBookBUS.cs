using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SearchingClassDiagram.DTO;
using SearchingClassDiagram.DAO;

namespace SearchingClassDiagram.BUS
{
    class SearchBookBUS
    {
        private SearchBookDTO sbDTO;
        private SearchBookDAO sbDAO;
        public SearchBookBUS()
        {
            sbDAO = new SearchBookDAO();
            sbDTO = new SearchBookDTO();
        }
        public SearchBookBUS(SearchBookDTO dto, SearchBookDAO dao)
        {
            sbDTO = dto;
            sbDAO = dao;
        }
        public DataSet SearchAllBooks()
        {
            return sbDAO.SearchAllBooks();
        }
        public DataSet SearchBooks(SearchBookDTO dto)
        {
            return sbDAO.SearchBooks(dto);
        }
    }
}
