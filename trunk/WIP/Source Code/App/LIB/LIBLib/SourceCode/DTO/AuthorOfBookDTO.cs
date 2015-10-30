using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class AuthorOfBookDTO
    {
        public AuthorDTO Author{ get; set; }
        public String ISBN{ get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
