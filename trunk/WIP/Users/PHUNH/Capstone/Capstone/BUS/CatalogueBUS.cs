using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capstone.DTO;
using Capstone.DAO;

namespace Capstone.BUS
{
    class CatalogueBUS
    {
        public int insertCatalogue(CatalogueDTO catalogue)
        {
            CatalogueDAO dao = new CatalogueDAO();
            return dao.insertCatalogue(catalogue);
        }

        public int deleteCatalogue(CatalogueDTO catalogue)
        {
            CatalogueDAO dao = new CatalogueDAO();
            return dao.deleteCatalogue(catalogue);
        }

        public int updateCatalogue(CatalogueDTO catalogue)
        {
            CatalogueDAO dao = new CatalogueDAO();
            return dao.updateCatalogue(catalogue);
        }

        public CatalogueDTO getCatalogueById(String isbn)
        {
            CatalogueDAO dao = new CatalogueDAO();
            return dao.getCatalogueById(isbn);
        }
    }
}
