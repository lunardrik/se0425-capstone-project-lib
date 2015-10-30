using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class PublisherDTO
    {
        public int PublisherId { get; set; }
        public String PublisherName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public override bool Equals(object obj)
        {
            return obj is System.DBNull ? false : ((PublisherDTO)obj).PublisherId == this.PublisherId;
        }
        public override string ToString()
        {
            return PublisherName;
        }
    }
}
