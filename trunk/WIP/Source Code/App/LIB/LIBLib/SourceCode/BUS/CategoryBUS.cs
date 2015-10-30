using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class CategoryBUS
    {
        public int InsertCategory(CategoryDTO category)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.InsertCategory(category);
        }

        public int DeleteCategory(CategoryDTO category)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.DeleteCategory(category);
        }

        public int UpdateCategory(CategoryDTO category)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.UpdateCategory(category);
        }

        public CategoryDTO GetCategoryById(String categoryId)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.GetCategoryById(categoryId);
        }

        public List<CategoryDTO> GetAllCatagory()
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.GetAllCategory();
        }

        public List<CategoryDTO> GetLv1Catagory()
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.GetLv1Category();
        }

        public List<CategoryDTO> GetSubCategory(string parentCate)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.GetSubCategory(parentCate);
        }
        
        public List<CategoryDTO> SearchCate(string info)
        {
            CategoryDAO dao=new CategoryDAO();
            return dao.SearchCategory(info);
        }
    }
}
