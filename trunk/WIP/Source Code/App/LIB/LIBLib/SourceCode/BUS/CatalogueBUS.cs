using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class CatalogueBUS
    {
        public int InsertCatalogue(CatalogueDTO catalogue, SqlTransaction trans)
        {
            AuthorOfBookBUS authorOfBookBus = new AuthorOfBookBUS();
            CatalogueDAO dao = new CatalogueDAO();
            bool isInScopeCreated = false;

            int rs;

            if (trans == null)
            {
                isInScopeCreated = true;
                trans = ConnectionManager.Con.BeginTransaction("CAT_CRE_TRANSACT");
            }

            rs = dao.InsertCatalogue(catalogue, trans);

            if (rs == 1)
            {
                authorOfBookBus.DeleteAuthorOfBook(catalogue.ISBN, trans);
                for (int i = 0; i < catalogue.AuthorList.Count; i++)
                {
                    rs = rs & authorOfBookBus.InsertAuthorOfBook(catalogue.AuthorList.ElementAt(i), trans);
                    if (rs == 0)
                        break;
                }

                if (isInScopeCreated)
                {
                    if (rs == 0)
                        trans.Rollback();
                    else
                        trans.Commit();
                }
            }
            else
            {
                if (isInScopeCreated)
                    trans.Rollback();
            }

            return rs;
        }

        public int DeleteCatalogue(CatalogueDTO catalogue, SqlTransaction trans)
        {
            CatalogueDAO dao = new CatalogueDAO();
            CopyBUS copyBus = new CopyBUS();
            bool isInScopeCreated = false;

            int rs = 1;

            if (trans == null)
            {
                isInScopeCreated = true;
                trans = ConnectionManager.Con.BeginTransaction("CAT_DEL_TRANSACT");
            }

            List<CopyDTO> list = copyBus.GetCopyByISBN(catalogue.ISBN);
            foreach (CopyDTO copyDTO in list)
            {
                rs = rs & copyBus.DeleteCopy(copyDTO, trans);
                if (rs == 0)
                    break;
            }

            if (rs == 0)
            {
                if (isInScopeCreated)
                    trans.Rollback();
            }
            else
            {
                rs = rs & dao.DeleteCatalogue(catalogue, trans);

                if (isInScopeCreated)
                    if (rs == 0)
                        trans.Rollback();
                    else
                        trans.Commit();
            }

            return rs;
        }

        public int UpdateCatalogue(CatalogueDTO catalogue, SqlTransaction trans)
        {
            AuthorOfBookBUS authorOfBookBus = new AuthorOfBookBUS();
            bool isInScopeCreated = false;

            int rs = 1;

            if (trans == null)
            {
                isInScopeCreated = true;
                trans = ConnectionManager.Con.BeginTransaction("CAT_UPD_TRANSACT");
            }
            
            rs = rs & authorOfBookBus.DeleteAuthorOfBook(catalogue.ISBN, trans);

            if (rs == 0)
            {
                if (isInScopeCreated)
                    trans.Rollback();
            }
            else
            {
                for (int i = 0; i < catalogue.AuthorList.Count; i++)
                {
                    rs = rs & authorOfBookBus.InsertAuthorOfBook(catalogue.AuthorList.ElementAt(i), trans);
                    if (rs == 0)
                        break;
                }

                if (rs == 0)
                {
                    if (isInScopeCreated)
                        trans.Rollback();
                }
                else
                {
                    CatalogueDAO dao = new CatalogueDAO();
                    rs = rs & dao.UpdateCatalogue(catalogue, trans);
                    if (isInScopeCreated)
                    {
                        if (rs == 0)
                            trans.Rollback();
                        else
                            trans.Commit();
                    }
                }
            }
            return rs;
        }

        public CatalogueDTO GetCatalogueById(String isbn)
        {
            CatalogueDTO catalogueDto = new CatalogueDTO();

            CatalogueDAO dao = new CatalogueDAO();
            catalogueDto = dao.GetCatalogueById(isbn);

            if (catalogueDto != null)
            {
                PublisherBUS publisherBus = new PublisherBUS();
                CategoryBUS categoryBus = new CategoryBUS();
                AuthorOfBookBUS authorOfBookBus = new AuthorOfBookBUS();

                catalogueDto.Publisher = publisherBus.GetPublisherById(catalogueDto.Publisher.PublisherId);
                catalogueDto.Category = categoryBus.GetCategoryById(catalogueDto.Category.CategoryId);
                catalogueDto.AuthorList = authorOfBookBus.GetAuthorListByIsbn(catalogueDto.ISBN);
            }
            return catalogueDto;
        }

        public int CountCatelogueByCategoryId(string categoryId)
        {
            CatalogueDAO dao = new CatalogueDAO();
            return dao.CountCatelogueByCategoryId(categoryId);
        }

        public CatalogueDTO GetRandomCatalogue()
        {
            CatalogueDTO catalogueDto = new CatalogueDTO();

            CatalogueDAO dao = new CatalogueDAO();
            catalogueDto = dao.GetRandomCatalogue();

            //Random không dùng thông tin chi tiết nên không cần phải load
            //if (catalogueDto != null)
            //{
            //    PublisherBUS publisherBus = new PublisherBUS();
            //    CategoryBUS categoryBus = new CategoryBUS();
            //    AuthorOfBookBUS authorOfBookBus = new AuthorOfBookBUS();

            //    catalogueDto.Publisher = publisherBus.GetPublisherById(catalogueDto.Publisher.PublisherId);
            //    catalogueDto.Category = categoryBus.GetCategoryById(catalogueDto.Category.CategoryId);
            //    catalogueDto.AuthorList = authorOfBookBus.GetAuthorListByIsbn(catalogueDto.ISBN);
            //}
            return catalogueDto;
        }
    }
}
