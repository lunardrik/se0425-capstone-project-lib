using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LIB;
using LIB.Common;

namespace LIB
{
    public class CategoryDAO
    {
        public int InsertCategory(CategoryDTO category)
        {
            category.UpdatedDate = DateTime.Now;
            category.CreatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0202",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.DateTime},
                                                     {"@Param4", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     category.CategoryId,
                                                     category.CategoryName,
                                                     category.CreatedDate,
                                                     category.UpdatedDate
                                                 }).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at CategoryDAO - InsertCategory", e);
                return 0;
            }

            return 1;
        }

        public int DeleteCategory(CategoryDTO category)
        {
            try
            {
                ConnectionManager.GetCommand("SP0204",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar}
                                                 },
                                             new List<object>()
                                                 {
                                                     category.CategoryId
                                                 }).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at CategoryDAO - DeleteCategory", e);
                return 0;
            }

            return 1;
        }

        public int UpdateCategory(CategoryDTO category)
        {
            category.UpdatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0203",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.DateTime},
                                                     {"@Param4", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     category.CategoryId,
                                                     category.CategoryName,
                                                     category.CreatedDate,
                                                     category.UpdatedDate
                                                 }).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at CategoryDAO - UpdateCategory", e);
                return 0;
            }

            return 1;
        }

        public CategoryDTO GetCategoryById(String categoryId) {
            CategoryDTO categoryDto = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0201CI",
                                                                    new Dictionary<string, SqlDbType>() { { "@Param1", SqlDbType.NVarChar } },
                                                                    new List<object>() { categoryId }).ExecuteReader();

                if (reader.Read())
                {
                    categoryDto = new CategoryDTO();
                    categoryDto.CategoryId = reader["CategoryID"].ToString();
                    categoryDto.CategoryName = reader["CategoryName"].ToString();
                    categoryDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    categoryDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at CategoryDAO - GetCategoryByID", e);
                return null;
            }

            return categoryDto;
        }

        public List<CategoryDTO> GetAllCategory()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0201ALL",
                                                                    new Dictionary<string, SqlDbType>() { },
                                                                    new List<object>() { }).ExecuteReader();

                while (reader.Read())
                {
                    CategoryDTO categoryDto = new CategoryDTO();
                    categoryDto.CategoryId = reader["CategoryID"].ToString();
                    categoryDto.CategoryName = reader["CategoryName"].ToString();
                    categoryDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    categoryDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(categoryDto);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - GetAllCategory", e);
                return null;
            }

            return list;
        }

        public List<CategoryDTO> GetLv1Category()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();


            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0201MASTER",
                                                                    new Dictionary<string, SqlDbType>() { },
                                                                    new List<object>() { }).ExecuteReader();

                while (reader.Read())
                {
                    CategoryDTO categoryDto = new CategoryDTO();
                    categoryDto.CategoryId = reader["CategoryID"].ToString();
                    categoryDto.CategoryName = reader["CategoryName"].ToString();
                    categoryDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    categoryDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(categoryDto);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - GetLv1Category", e);
                return null;
            }

            return list;
        }

        public List<CategoryDTO> GetSubCategory(string parentCate)
        {
            List<CategoryDTO> list = new List<CategoryDTO>();


            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0201SUB",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {{"@Param1", SqlDbType.NVarChar}},
                                                                    new List<object>() {parentCate}).ExecuteReader();

                while (reader.Read())
                {
                    CategoryDTO categoryDto = new CategoryDTO();
                    categoryDto.CategoryId = reader["CategoryID"].ToString();
                    categoryDto.CategoryName = reader["CategoryName"].ToString();
                    categoryDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    categoryDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(categoryDto);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - GetLv1Category", e);
                return null;
            }

            return list;
        }

        public List<CategoryDTO> SearchCategory(string info)
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            CategoryDTO categoryDTO;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0005category",
                                                                    new Dictionary<string, SqlDbType>() { { "@cate", SqlDbType.NVarChar } },
                                                                    new List<object>() { info }).ExecuteReader();

                while (reader.Read())
                {
                    categoryDTO = new CategoryDTO();
                    categoryDTO.CategoryId = reader["categoryID"].ToString();
                    categoryDTO.CategoryName = reader["categoryName"].ToString();
                    categoryDTO.CreatedDate = (DateTime)reader["CreatedDate"];
                    categoryDTO.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(categoryDTO);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Logger.Error("Error at AuthorDAO - GetAuthorByID", e);
                return null;
            }
            return list;
        }
    }
}
