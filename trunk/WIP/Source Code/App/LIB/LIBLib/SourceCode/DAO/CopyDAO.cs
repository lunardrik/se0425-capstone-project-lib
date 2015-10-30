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
    public class CopyDAO
    {
        public int InsertCopy(CopyDTO copy)
        {
            copy.UpdatedDate = DateTime.Now;
            copy.CreatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0502",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.Int},
                                                     {"@Param4", SqlDbType.DateTime},
                                                     {"@Param5", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     copy.Barcode,
                                                     copy.ISBN,
                                                     copy.Status,
                                                     copy.CreatedDate,
                                                     copy.UpdatedDate
                                                 }).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at CopyDAO - InsertCopy", e);
                return 0;
            }

            return 1;
        }

        public int DeleteCopy(CopyDTO copy, SqlTransaction trans)
        {
            try
            {
                ConnectionManager.GetCommand("SP0504",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar}
                                                 },
                                             new List<object>()
                                                 {
                                                     copy.Barcode
                                                 }, trans).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at CopyDAO - DeleteCopy", e);
                return 0;
            }

            return 1;
        }

        public int UpdateCopy(CopyDTO copy)
        {
            copy.UpdatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0503",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.Int},
                                                     {"@Param4", SqlDbType.DateTime},
                                                     {"@Param5", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     copy.Barcode,
                                                     copy.ISBN,
                                                     copy.Status,
                                                     copy.CreatedDate,
                                                     copy.UpdatedDate
                                                 }).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at CopyDAO - UpdateCopy", e);
                return 0;
            }

            return 1;
        }

        public CopyDTO GetCopyById(String barcode){
            CopyDTO copyDto = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0501BC",
                                                                    new Dictionary<string, SqlDbType>() { { "@Param1", SqlDbType.NVarChar } },
                                                                    new List<object>() { barcode }).ExecuteReader();

                if (reader.Read())
                {
                    copyDto = new CopyDTO();
                    copyDto.Barcode = reader["Barcode"].ToString();
                    copyDto.ISBN = reader["ISBN"].ToString();
                    copyDto.Status = int.Parse(reader["Status"].ToString());
                    copyDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    copyDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at CopyDAO - GetCopyByID", e);
                return null;
            }

            return copyDto;
        }

        public List<CopyDTO> GetCopyByISBN(String isbn)
        {
            List<CopyDTO> list = new List<CopyDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0501ISBN",
                                                                    new Dictionary<string, SqlDbType>() {{"@Param1",SqlDbType.NVarChar} },
                                                                    new List<object>() { isbn }).ExecuteReader();

                while (reader.Read())
                {
                    CopyDTO copyDto = new CopyDTO();
                    copyDto.Barcode = reader["Barcode"].ToString();
                    copyDto.ISBN = reader["ISBN"].ToString();
                    copyDto.Status = int.Parse(reader["Status"].ToString());
                    copyDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    copyDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(copyDto);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - GetAllAuthor", e);
                return null;
            }

            return list;
        }
    }
}
