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
    public class CatalogueDAO
    {
        public int InsertCatalogue(CatalogueDTO catalogue, SqlTransaction trans)
        {
            catalogue.UpdatedDate = DateTime.Now;
            catalogue.CreatedDate = DateTime.Now;

            try
            {
                ConnectionManager.GetCommand("SP0102",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.Int},
                                                     {"@Param4", SqlDbType.NVarChar},
                                                     {"@Param5", SqlDbType.NVarChar},
                                                     {"@Param6", SqlDbType.NVarChar},
                                                     {"@Param7", SqlDbType.Int},
                                                     {"@Param8", SqlDbType.Int},
                                                     {"@Param9", SqlDbType.Int},
                                                     {"@Param10", SqlDbType.Int},
                                                     {"@Param11", SqlDbType.Int},
                                                     {"@Param12", SqlDbType.Float},
                                                     {"@Param13", SqlDbType.NVarChar},
                                                     {"@Param14", SqlDbType.DateTime},
                                                     {"@Param15", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     catalogue.ISBN,
                                                     catalogue.Title,
                                                     catalogue.Publisher.PublisherId,
                                                     catalogue.ShortDescription,
                                                     catalogue.Category.CategoryId,
                                                     catalogue.Language,
                                                     catalogue.Year,
                                                     catalogue.ExpandLimit,
                                                     catalogue.ExpandDateLimit,
                                                     catalogue.NumberOfCopies,
                                                     catalogue.AvailableCopies,
                                                     catalogue.Price,
                                                     catalogue.Image,
                                                     catalogue.CreatedDate,
                                                     catalogue.UpdatedDate
                                                 }, trans).ExecuteNonQuery();

                

            }
            catch (Exception e)
            {
                Log.Error("Error at CatalogueDAO - InsertCatalogue", e);
                return 0;
            }

            return 1;
        }

        public int DeleteCatalogue(CatalogueDTO catalogue, SqlTransaction trans)
        {
            catalogue.NumberOfCopies = -1;
            catalogue.AvailableCopies = -1;
            return UpdateCatalogue(catalogue, trans);
        }

        public int UpdateCatalogue(CatalogueDTO catalogue, SqlTransaction trans)
        {
            catalogue.UpdatedDate = DateTime.Now;

            

            try
            {
                ConnectionManager.GetCommand("SP0103",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.Int},
                                                     {"@Param4", SqlDbType.NVarChar},
                                                     {"@Param5", SqlDbType.NVarChar},
                                                     {"@Param6", SqlDbType.NVarChar},
                                                     {"@Param7", SqlDbType.Int},
                                                     {"@Param8", SqlDbType.Int},
                                                     {"@Param9", SqlDbType.Int},
                                                     {"@Param10", SqlDbType.Int},
                                                     {"@Param11", SqlDbType.Int},
                                                     {"@Param12", SqlDbType.Float},
                                                     //{"@Param13", SqlDbType.Int},
                                                     //{"@Param14", SqlDbType.Int},
                                                     {"@Param13", SqlDbType.NVarChar},
                                                     {"@Param14", SqlDbType.DateTime},
                                                     {"@Param15", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     catalogue.ISBN,
                                                     catalogue.Title,
                                                     catalogue.Publisher.PublisherId,
                                                     catalogue.ShortDescription,
                                                     catalogue.Category.CategoryId,
                                                     catalogue.Language,
                                                     catalogue.Year,
                                                     catalogue.ExpandLimit,
                                                     catalogue.ExpandDateLimit,
                                                     catalogue.NumberOfCopies,
                                                     catalogue.AvailableCopies,
                                                     catalogue.Price,
                                                     //catalogue.RentalTime,
                                                     //catalogue.HitTime,
                                                     catalogue.Image,
                                                     catalogue.CreatedDate,
                                                     catalogue.UpdatedDate
                                                 }, trans).ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Log.Error("Error at CatalogueDAO - UpdateCatalogue", e);
                return 0;
            }

            return 1;
        }

        public CatalogueDTO GetCatalogueById(String isbn)
        {
            CatalogueDTO catalogueDto = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0101ISBN",
                                                                    new Dictionary<string, SqlDbType>() { { "@Param1", SqlDbType.NVarChar } },
                                                                    new List<object>() { isbn }).ExecuteReader();

                if (reader.Read())
                {
                    catalogueDto = new CatalogueDTO();

                    PublisherDTO publisherDto = new PublisherDTO();
                    CategoryDTO categoryDto = new CategoryDTO();

                    catalogueDto.ISBN = reader["ISBN"].ToString();
                    catalogueDto.Title = reader["Title"].ToString();
                    // add code for get data
                    publisherDto.PublisherId = int.Parse(reader["PublisherID"].ToString());
                    catalogueDto.Publisher = publisherDto;
                    catalogueDto.ShortDescription = reader["ShortDescription"].ToString();
                    // add code for get data
                    categoryDto.CategoryId = reader["CategoryID"].ToString();
                    catalogueDto.Category = categoryDto;
                    catalogueDto.Language = reader["Language"].ToString();
                    catalogueDto.Year = int.Parse(reader["Year"].ToString());
                    catalogueDto.ExpandLimit = int.Parse(reader["ExpandLimit"].ToString());
                    catalogueDto.ExpandDateLimit = int.Parse(reader["ExpandDateLimit"].ToString());
                    catalogueDto.NumberOfCopies = int.Parse(reader["NumberOfCopies"].ToString());
                    catalogueDto.AvailableCopies = int.Parse(reader["AvailableCopies"].ToString());
                    catalogueDto.Price = float.Parse(reader["Price"].ToString());
                    catalogueDto.Image = reader["Image"].ToString();
                    catalogueDto.HitTime = int.Parse(reader["HitTime"].ToString());
                    catalogueDto.RentalTime = int.Parse(reader["RentalTime"].ToString());
                    catalogueDto.CreatedDate = (DateTime) reader["CreatedDate"];
                    catalogueDto.UpdatedDate = (DateTime) reader["UpdatedDate"];
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at CatalogueDAO - GetCatalogueByID", e);
                return null;
            }

            return catalogueDto;
        }

        public int CountCatelogueByCategoryId(string categoryId)
        {
            int rs = 0;
            try
            {
                rs = int.Parse(ConnectionManager.GetCommand("SP0101CIC",
                                                                    new Dictionary<string, SqlDbType>() { { "@Param1", SqlDbType.NVarChar } },
                                                                    new List<object>() { categoryId }).ExecuteScalar().ToString());

               
            }
            catch (Exception e)
            {
                Log.Error("Error at CatalogueDAO - CountCatelogueByCategoryId", e);
                return rs;
            }

            return rs;
        }

        public CatalogueDTO GetRandomCatalogue()
        {
            CatalogueDTO catalogueDto = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0101RAND",
                                                                    new Dictionary<string, SqlDbType>(),
                                                                    new List<object>()).ExecuteReader();

                if (reader.Read())
                {
                    catalogueDto = new CatalogueDTO();

                    PublisherDTO publisherDto = new PublisherDTO();
                    CategoryDTO categoryDto = new CategoryDTO();

                    catalogueDto.ISBN = reader["ISBN"].ToString();
                    catalogueDto.Title = reader["Title"].ToString();
                    // add code for get data
                    publisherDto.PublisherId = int.Parse(reader["PublisherID"].ToString());
                    catalogueDto.Publisher = publisherDto;
                    catalogueDto.ShortDescription = reader["ShortDescription"].ToString();
                    // add code for get data
                    categoryDto.CategoryId = reader["CategoryID"].ToString();
                    catalogueDto.Category = categoryDto;
                    catalogueDto.Language = reader["Language"].ToString();
                    catalogueDto.Year = int.Parse(reader["Year"].ToString());
                    catalogueDto.ExpandLimit = int.Parse(reader["ExpandLimit"].ToString());
                    catalogueDto.ExpandDateLimit = int.Parse(reader["ExpandDateLimit"].ToString());
                    catalogueDto.NumberOfCopies = int.Parse(reader["NumberOfCopies"].ToString());
                    catalogueDto.AvailableCopies = int.Parse(reader["AvailableCopies"].ToString());
                    catalogueDto.Price = float.Parse(reader["Price"].ToString());
                    catalogueDto.Image = reader["Image"].ToString();
                    catalogueDto.HitTime = int.Parse(reader["HitTime"].ToString());
                    catalogueDto.RentalTime = int.Parse(reader["RentalTime"].ToString());
                    catalogueDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    catalogueDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at CatalogueDAO - GetRandomCatalogue", e);
                return null;
            }

            return catalogueDto;
        }
    }
}
