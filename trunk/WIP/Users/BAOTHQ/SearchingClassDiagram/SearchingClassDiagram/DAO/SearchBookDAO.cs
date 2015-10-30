using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SearchingClassDiagram.DTO;

namespace SearchingClassDiagram.DAO
{
    class SearchBookDAO
    {
        private SearchBookDTO sbDIO;
        public SearchBookDAO()
        {
            sbDIO = new SearchBookDTO();
        }

        public SearchBookDAO(SearchBookDTO dto)
        {
            sbDIO = dto;
        }

        public DataSet SearchAllBooks()
        {
            return new DataSet();
        }
        
        public DataSet SearchBooks(SearchBookDTO sbDTO)
        {
            return new DataSet();
        }
        //public int SearchRequest(string title, string userID, int status)
        //{
        //    return 1;
        //}
        //public int searchRental(string title, string userID, int status)
        //{
        //    return 1;
        //}
        //public int searchUser(string userID, int status)
        //{
        //    return 1;
        //}
    }
}
