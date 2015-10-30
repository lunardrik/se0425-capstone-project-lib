using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capstone.DTO;
using Capstone.DAO;

namespace Capstone.BUS
{
    class AuthorOfBookBUS
    {
        public int insertAuthorOfBook(AuthorOfBookDTO authorOfBook)
        {
            AuthorOfBookDAO dao = new AuthorOfBookDAO();
            return dao.insertAuthorOfBook(authorOfBook);
        }

        public int deleteAuthorOfBook(AuthorOfBookDTO authorOfBook)
        {
            AuthorOfBookDAO dao = new AuthorOfBookDAO();
            return dao.deleteAuthorOfBook(authorOfBook);
        }

        public int updateAuthorOfBook(AuthorOfBookDTO authorOfBook)
        {
            AuthorOfBookDAO dao = new AuthorOfBookDAO();
            return dao.updateAuthorOfBook(authorOfBook);
        }

        public List<AuthorOfBookDTO> getAuthorListByIsbn(String isbn) 
        {
            AuthorOfBookDAO dao = new AuthorOfBookDAO();
            return dao.getAuthorListByIsbn(isbn);
        }
    }
}
