using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LIB;

namespace LIBWeb.Models
{
    public class SearchResultModels
    {
        public List<SearchBookResultDTO> Results { get; set; }
        public int NoP { get; set; }
        public int CurrentPage { get; set; }
        public int NumberOfResult { get; set; }

        // for Keyword search only
        public string KeyWord { get; set; }
        public bool SearchByTitle { get; set; }
        public bool SearchByContent { get; set; }
        public bool SearchByAuthor { get; set; }
        public string CateToSearch { get; set; }

        // for category search only
        public string ParentCate { get; set; }

        // for author search only
        public int Author { get; set; }
    }
}