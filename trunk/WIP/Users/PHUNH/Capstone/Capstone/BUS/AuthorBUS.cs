using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capstone.DAO;
using Capstone.DTO;

namespace Capstone.BUS
{
    class AuthorBUS
    {
        public int insertAuthor(AuthorDTO author) 
        {
            AuthorDAO dao = new AuthorDAO();
            return dao.insertAuthor(author);
        }

        public int deleteAuthor(AuthorDTO author)
        {
            AuthorDAO dao = new AuthorDAO();
            return dao.deleteAuthor(author);
        }

        public int updateAuthor(Capstone.DTO.AuthorDTO author)
        {
            AuthorDAO dao = new AuthorDAO();
            return dao.updateAuthor(author);
        }

        public AuthorDTO getAuthorById(int authorId) 
        {
            AuthorDAO dao = new AuthorDAO();
            return dao.getAuthorById(authorId);
        }
    }
}
