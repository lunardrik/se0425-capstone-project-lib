using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class AuthorBUS
    {
        public int InsertAuthor(AuthorDTO author)
        {
            int rs = 0;
            using (SqlTransaction trans = ConnectionManager.Con.BeginTransaction())
            {
                AuthorDAO dao = new AuthorDAO();
                rs = dao.InsertAuthor(author);

                if (rs == 1)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            return rs;
        }

        public int DeleteAuthor(AuthorDTO author)
        {
            int rs = 0;
            using (SqlTransaction trans = ConnectionManager.Con.BeginTransaction())
            {
                AuthorDAO dao = new AuthorDAO();
                rs = dao.DeleteAuthor(author);

                if (rs == 1)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            return rs;
        }

        public int UpdateAuthor(LIB.AuthorDTO author)
        {
            int rs = 0;
            using (SqlTransaction trans = ConnectionManager.Con.BeginTransaction())
            {
                AuthorDAO dao = new AuthorDAO();
                rs = dao.UpdateAuthor(author);

                if (rs == 1)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            return rs;
        }

        public AuthorDTO GetAuthorById(int authorId) 
        {
            AuthorDAO dao = new AuthorDAO();
            return dao.GetAuthorById(authorId);
        }

        public List<AuthorDTO> GetAllAuthor()
        {
            AuthorDAO dao = new AuthorDAO();
            return dao.GetAllAuthor();
        }

        //BaoTHQ
        public List<AuthorDTO> searchAuthor(string authorName)
        {
            AuthorDAO dao=new AuthorDAO();
            return dao.SearchAuthor(authorName);
        }
    }
}
