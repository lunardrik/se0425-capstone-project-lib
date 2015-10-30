using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LIB
{
    public class SearchBookBUS
    {
        
        public List<SearchBookResultDTO> SearchBooks(SearchBookDTO dto)
        {
            SearchBookDAO sbDAO=new SearchBookDAO();
            List<SearchBookResultDTO> result = new List<SearchBookResultDTO>();

            int pageSize = Options.NumberOfRecord;
            int rowStart = 0;
            if(dto.PageNumber==1)
            {
                rowStart = 1;
            }
            else
            {
                rowStart = (dto.PageNumber - 1)*pageSize;
            }
            int rowEnd = rowStart - 1 + pageSize;
            switch(dto.SearchType)
            {
                case SearchType.BASIC_SEARCH:
                    result = sbDAO.SearchBasicBooks(dto.Info1, rowStart, rowEnd);
                    break;
                case SearchType.DETAIL_SEARCH:
                    result = sbDAO.SearchDetailBooks(dto.Info1, dto.Info2, dto.Info3, dto.Info4, rowStart, rowEnd);
                    break;
                default:
                    result = sbDAO.SearchAdvanceBooks(dto, rowStart, rowEnd);
                    break;
            }
            return result;
        }

        public int SearchBooksCount(SearchBookDTO dto)
        {
            SearchBookDAO sbDAO=new SearchBookDAO();
            int result;

            switch(dto.SearchType)
            {
                case SearchType.BASIC_SEARCH:
                    result = sbDAO.SearchBasicBooksCount(dto.Info1);
                    break;
                case SearchType.DETAIL_SEARCH:
                    result = sbDAO.SearchDetailBooksCount(dto.Info1, dto.Info2, dto.Info3, dto.Info4);
                    break;
                default:
                    result = sbDAO.SearchAdvanceBooksCount(dto);
                    break;
            }
            
            return result;
        }

        // By Author
        public List<SearchBookResultDTO> SearchBooksByAuthor(SearchBookDTO dto)
        {
            SearchBookDAO sbDAO = new SearchBookDAO();
            List<SearchBookResultDTO> result = new List<SearchBookResultDTO>();
            CatalogueBUS bus = new CatalogueBUS();

            int pageSize = Options.NumberOfRecord;
            int rowStart = 0;
            if (dto.PageNumber == 1)
            {
                rowStart = 1;
            }
            else
            {
                rowStart = (dto.PageNumber - 1) * pageSize;
            }
            int rowEnd = rowStart - 1 + pageSize;
            DataTable dt;

            dt = sbDAO.SearchBooksByAuthor(dto.Info1, rowStart, rowEnd);

            foreach (DataRowView record in dt.DefaultView)
            {
                result.Add(new SearchBookResultDTO()
                {
                    ISBN = record["ISBN"].ToString(),
                    AuthorName = record["AuthorName"].ToString(),
                    CategoryName = record["CategoryName"].ToString(),
                    Image = record["Image"].ToString(),
                    PublisherName = record["PublisherName"].ToString(),
                    Title = record["Title"].ToString(),
                    ShortDescription = record["ShortDescription"].ToString(),
                    No = int.Parse(record["No"].ToString())
                });
            }
            return result;
        }

        public int SearchBooksByAuthorCount(SearchBookDTO dto)
        {
            SearchBookDAO sbDAO = new SearchBookDAO();
            int result;


            result = sbDAO.SearchBooksByAuthorCount(dto.Info1);


            return result;
        }

        public List<SearchBookResultDTO> SearchBooksHit()
        {
            SearchBookDAO sbDAO = new SearchBookDAO();
            List<SearchBookResultDTO> result = new List<SearchBookResultDTO>();
            
            DataTable dt;

            dt = sbDAO.SearchBooksHit();

            foreach (DataRowView record in dt.DefaultView)
            {
                result.Add(new SearchBookResultDTO()
                {
                    ISBN = record["ISBN"].ToString(),
                    AuthorName = record["AuthorName"].ToString(),
                    CategoryName = record["CategoryName"].ToString(),
                    Image = record["Image"].ToString(),
                    PublisherName = record["PublisherName"].ToString(),
                    Title = record["Title"].ToString(),
                    ShortDescription = record["ShortDescription"].ToString(),
                    No = int.Parse(record["No"].ToString())
                });
            }
            return result;
        }

        //Simple Search for rental
        public List<SearchBookDAO.SimpleCopyOfBook> SearchBarcode(SearchBookDTO dto)
        {
            SearchBookDAO dao=new SearchBookDAO();
            return dao.SearchBarcode(dto);
        }

        public List<SearchBookDAO.SimpleCatalogue> SearchCatalogue(SearchBookDTO dto)
        {
            SearchBookDAO dao = new SearchBookDAO();
            return dao.SearchCatalogue(dto);
        }
    }
}
