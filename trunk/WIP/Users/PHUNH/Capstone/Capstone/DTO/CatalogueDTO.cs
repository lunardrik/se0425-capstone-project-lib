using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.DTO
{
    class CatalogueDTO
    {
        /*Properties of Catalogue*/
        public String isbn { get; set; }
        public PublisherDTO publisher { get; set; }
        public String shortDescription { get; set; }
        public CategoryDTO category { get; set; }
        public List<AuthorOfBookDTO> authorList { get; set; }
        public String language { get; set; }
        public int year { get; set; }
        public int expandLimit { get; set; }
        public int expandDateLimit { get; set; }
        public int numberOfCopies { get; set; }
        public int avaibleCopies { get; set; }
        public String image { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
        public float price { get; set; }
    }
}
