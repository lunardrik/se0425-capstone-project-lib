using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capstone.DAO;
using Capstone.DTO;

namespace Capstone.BUS
{
    class CategoryBUS
    {
        public int insertCategory(CategoryDTO category)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.insertCategory(category);
        }

        public int deleteCategory(CategoryDTO category)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.deleteCategory(category);
        }

        public int updateCategory(CategoryDTO category)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.updateCategory(category);
        }

        public CategoryDTO getCategoryById(int categoryId)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.getCategoryById(categoryId);
        }
    }
}
