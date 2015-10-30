using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capstone.DTO;
using Capstone.DAO;

namespace Capstone.BUS
{
    class CopyBUS
    {
        public int insertCopy(Capstone.DTO.CopyDTO copy)
        {
            CopyDAO dao = new CopyDAO();
            return dao.insertCopy(copy);
        }

        public int deleteCopy(Capstone.DTO.CopyDTO copy)
        {
            CopyDAO dao = new CopyDAO();
            return dao.deleteCopy(copy);
        }

        public int updateCopy(Capstone.DTO.CopyDTO copy)
        {
            CopyDAO dao = new CopyDAO();
            return dao.updateCopy(copy);
        }

        public CopyDTO getCopyById(String barcode)
        {
            CopyDAO dao = new CopyDAO();
            return dao.getCopyById(barcode);
        }
    }
}
