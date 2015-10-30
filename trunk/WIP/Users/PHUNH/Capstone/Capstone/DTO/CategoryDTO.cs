using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.DTO
{
    class CategoryDTO
    {
        public int categoryId { get; set; }
        public String categoryName { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
    }
}
