using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class AuthorOfBookBUS
    {
        public int InsertAuthorOfBook(AuthorOfBookDTO authorOfBook, SqlTransaction trans)
        {
            AuthorOfBookDAO dao = new AuthorOfBookDAO();
            bool isInScopeCreated = false;
            int rs;

            if (trans == null)
            {
                isInScopeCreated = true;
                trans = ConnectionManager.Con.BeginTransaction("AOB_CRE_TRANSACT");
            }

            rs = dao.InsertAuthorOfBook(authorOfBook, trans);

            if (isInScopeCreated)
            {
                if (rs == 0)
                    trans.Rollback();
                else
                    trans.Commit();
            }

            return rs;
        }

        public int DeleteAuthorOfBook(String isbn, SqlTransaction trans)
        {
            AuthorOfBookDAO dao = new AuthorOfBookDAO();
            bool isInScopeCreated = false;
            int rs;

            if (trans == null)
            {
                isInScopeCreated = true;
                trans = ConnectionManager.Con.BeginTransaction("AOB_DEL_TRANSACT");
            }

            rs = dao.DeleteAuthorOfBook(isbn, trans);

            if (isInScopeCreated)
            {
                if (rs == 0)
                    trans.Rollback();
                else
                    trans.Commit();
            }
            return rs;
        }

        public List<AuthorOfBookDTO> GetAuthorListByIsbn(String isbn) 
        {
            List<AuthorOfBookDTO> lst = new List<AuthorOfBookDTO>();
            AuthorOfBookDAO dao = new AuthorOfBookDAO();
            lst = dao.GetAuthorListByIsbn(isbn);

            AuthorBUS authorBus = new AuthorBUS();

            for (int i = 0; i < lst.Count; i++)
            {
                lst.ElementAt(i).Author = authorBus.GetAuthorById(lst.ElementAt(i).Author.AuthorId);
            }

            return lst;
        }
    }
}
