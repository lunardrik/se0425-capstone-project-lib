using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.DTO
{
    class AuthorOfBookDTO
    {
        public Author author{ get; set; }
        public int isbn{ get; set; }
        public DateTime createdDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
    }
}
