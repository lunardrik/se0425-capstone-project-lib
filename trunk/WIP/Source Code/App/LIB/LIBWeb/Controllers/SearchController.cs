using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LIB;
using LIBWeb.Models;

namespace LIBWeb.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public ActionResult Index()
        {
            return View(new SearchResultModels());
        }

        //
        // GET: /Search/Details/5

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            try
            {
                bool isByTitle = collection["chkTitle"] != null;
                bool isByContent = collection["chkContent"] != null;
                bool isByAuthor = collection["chkAuthor"] != null;

                SearchBookBUS bus = new SearchBookBUS();
                SearchBookDTO dto = new SearchBookDTO()
                {
                    Info1 = isByTitle ? collection["txtKeyword"] : "",
                    Info2 = collection["lstCategories"],
                    Info3 = isByContent ? collection["txtKeyword"] : "",
                    Info4 = isByAuthor ? collection["txtKeyword"] : "",
                    PageNumber = int.Parse(collection["txtPageNum"]),
                    SearchType = SearchType.DETAIL_SEARCH
                };

                int count = bus.SearchBooksCount(dto);
                return View(new SearchResultModels()
                {
                    KeyWord = collection["txtKeyword"],
                    SearchByAuthor = isByAuthor,
                    SearchByContent = isByContent,
                    SearchByTitle = isByTitle,
                    CateToSearch = collection["lstCategories"],
                    Results = bus.SearchBooks(dto),
                    NoP =
                        (int)
                        Math.Ceiling((double)count / ((double)Options.NumberOfRecord)),
                    NumberOfResult = count,
                    CurrentPage = dto.PageNumber
                });
                
            }
            catch
            {
                return View();
            }
        }

        public ActionResult BookDetail(string id)
        {
            CatalogueBUS bus = new CatalogueBUS();
            return View(bus.GetCatalogueById(id));
        }

        public ActionResult Author(int id)
        {
            try
            {
                SearchBookBUS bus = new SearchBookBUS();
                SearchBookDTO dto = new SearchBookDTO()
                {
                    Info1 = id.ToString(),
                    PageNumber = 1,
                    SearchType = SearchType.DETAIL_SEARCH
                };

                int count = bus.SearchBooksByAuthorCount(dto);
                return View(new SearchResultModels()
                {
                    Author = id,
                    Results = bus.SearchBooksByAuthor(dto),
                    NoP =
                        (int)
                        Math.Ceiling((double)count / ((double)Options.NumberOfRecord)),
                    NumberOfResult = count,
                    CurrentPage = dto.PageNumber
                });

            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Author(FormCollection collection)
        {
            try
            {
                SearchBookBUS bus = new SearchBookBUS();
                SearchBookDTO dto = new SearchBookDTO()
                {
                    Info1 = collection["txtAuthor"],
                    PageNumber = int.Parse(collection["txtPageNum"]),
                    SearchType = SearchType.DETAIL_SEARCH
                };

                int count = bus.SearchBooksByAuthorCount(dto);
                return View(new SearchResultModels()
                {
                    Author = int.Parse(collection["txtAuthor"]),
                    Results = bus.SearchBooksByAuthor(dto),
                    NoP =
                        (int)
                        Math.Ceiling((double)count / ((double)Options.NumberOfRecord)),
                    NumberOfResult = count,
                    CurrentPage = dto.PageNumber
                });

            }
            catch
            {
                return View();
            }
        }

        public ActionResult Category(string id)
        {
            try
            {
                SearchBookBUS bus = new SearchBookBUS();
                SearchBookDTO dto = new SearchBookDTO()
                {
                    Info2 = id,
                    PageNumber = 1,
                    SearchType = SearchType.DETAIL_SEARCH
                };

                int count = bus.SearchBooksCount(dto);
                return View(new SearchResultModels()
                {
                    ParentCate = id,
                    Results = bus.SearchBooks(dto),
                    NoP =
                        (int)
                        Math.Ceiling((double)count / ((double)Options.NumberOfRecord)),
                    NumberOfResult = count,
                    CurrentPage = dto.PageNumber
                });

            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Category(FormCollection collection)
        {
            try
            {
                SearchBookBUS bus = new SearchBookBUS();
                SearchBookDTO dto = new SearchBookDTO()
                {
                    Info2 = collection["txtCategoryId"],
                    PageNumber = int.Parse(collection["txtPageNum"]),
                    SearchType = SearchType.DETAIL_SEARCH
                };

                int count = bus.SearchBooksCount(dto);
                return View(new SearchResultModels()
                {
                    ParentCate = collection["txtCategoryId"],
                    Results = bus.SearchBooks(dto),
                    NoP =
                        (int)
                        Math.Ceiling((double)count / ((double)Options.NumberOfRecord)),
                    NumberOfResult = count,
                    CurrentPage = dto.PageNumber
                });

            }
            catch
            {
                return View();
            }
        }
    }
}
