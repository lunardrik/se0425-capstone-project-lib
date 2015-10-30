using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.DTO
{
    class PublisherDTO
    {
        public int publisherId { get; set; }
        public String publisherName { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
    }
}
