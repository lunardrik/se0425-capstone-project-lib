using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class SearchRequestDTO
    {
        public string Title { get; set; }

        public string UserName { get; set; }

        public string FromDate { get; set; }

        public string ToDate { get; set; }

        public int Status { get; set; }

        public int PageNumber { get; set; }
    }
}
