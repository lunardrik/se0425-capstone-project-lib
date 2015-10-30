using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class AuthorDTO
    {
        public int AuthorId { get; set; }
        public String AuthorName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


        public override bool Equals(object obj)
        {
            return obj is System.DBNull ? false : ((AuthorDTO)obj).AuthorId == this.AuthorId;
        }

        public override string ToString()
        {
            return AuthorName;
        }
    }
}
