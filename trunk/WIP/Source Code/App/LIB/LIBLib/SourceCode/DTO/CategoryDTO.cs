using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class CategoryDTO
    {
        public String CategoryId { get; set; }
        public String CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public override bool Equals(object obj)
        {
            return !(obj is System.DBNull) && ((CategoryDTO)obj).CategoryId == this.CategoryId;
        }
        public override string ToString()
        {
            return CategoryName;
        }

        public CategoryDTO Clone()
        {
            return new CategoryDTO() { CategoryId = CategoryId.Clone().ToString(), CategoryName = CategoryName.Clone().ToString() };
        }
    }
}
