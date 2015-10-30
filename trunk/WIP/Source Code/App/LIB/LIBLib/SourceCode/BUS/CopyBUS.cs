using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class CopyBUS
    {
        public int InsertCopy(LIB.CopyDTO copy)
        {
            CopyDAO dao = new CopyDAO();
            return dao.InsertCopy(copy);
        }

        public int DeleteCopy(LIB.CopyDTO copy, SqlTransaction trans)
        {
            bool isInScopeCreated = false;

            int rs;

            if (trans == null)
            {
                isInScopeCreated = true;
                trans = ConnectionManager.Con.BeginTransaction("CAT_CRE_TRANSACT");
            }

            CopyDAO dao = new CopyDAO();
            rs = dao.DeleteCopy(copy, trans);

            if (isInScopeCreated)
            {
                if (rs == 0)
                    trans.Rollback();
                else 
                    trans.Commit();
            }

            return rs;
        }

        public int UpdateCopy(LIB.CopyDTO copy)
        {
            CopyDAO dao = new CopyDAO();
            return dao.UpdateCopy(copy);
        }

        public CopyDTO GetCopyById(String barcode)
        {
            CopyDAO dao = new CopyDAO();
            return dao.GetCopyById(barcode);
        }

        public List<CopyDTO> GetCopyByISBN(String isbn)
        {
            CopyDAO dao = new CopyDAO();
            return dao.GetCopyByISBN(isbn);
        }
    }
}
