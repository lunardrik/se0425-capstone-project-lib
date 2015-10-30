using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class AuthorDAO
    {
        public int InsertAuthor(AuthorDTO author)
        {
            author.CreatedDate = DateTime.Now;
            author.UpdatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0302",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.DateTime},
                                                     {"@Param4", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     author.AuthorName,
                                                     author.CreatedDate,
                                                     author.UpdatedDate
                                                 }).ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - InsertAuthor", e);
                return 0;
            }

            return 1;
        }

        public int DeleteAuthor(AuthorDTO author)
        {
            try
            {
                ConnectionManager.GetCommand("SP0304",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.Int}
                                                 },
                                             new List<object>()
                                                 {
                                                     author.AuthorId
                                                 }).ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - DeleteAuthor", e);
                return 0;
            }

            return 1;
        }

        public int UpdateAuthor(AuthorDTO author)
        {
            author.UpdatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0303",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.Int},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.DateTime},
                                                     {"@Param4", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     author.AuthorId,
                                                     author.AuthorName,
                                                     author.CreatedDate,
                                                     author.UpdatedDate
                                                 }).ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - UpdateAuthor", e);
                return 0;
            }

            return 1;
        }

        /// <summary>
        /// Get Author from Database by specific Id
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
        public AuthorDTO GetAuthorById(int authorId)
        {
            // 20120306 QUANLM ++
            AuthorDTO authorDTO = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0301AI",
                                                                    new Dictionary<string, SqlDbType>() { { "@Param1", SqlDbType.Int } },
                                                                    new List<object>() { authorId }).ExecuteReader();

                if (reader.Read())
                {
                    authorDTO = new AuthorDTO();
                    authorDTO.AuthorId = int.Parse(reader["AuthorID"].ToString());
                    authorDTO.AuthorName = reader["AuthorName"].ToString();
                    authorDTO.CreatedDate = (DateTime)reader["CreatedDate"];
                    authorDTO.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - GetAuthorByID", e);
                return null;
            }

            return authorDTO;
            // 20120306 QUANLM --
        }

        public List<AuthorDTO> GetAllAuthor()
        {
            List<AuthorDTO> list = new List<AuthorDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0301ALL",
                                                                    new Dictionary<string, SqlDbType>() { },
                                                                    new List<object>() { }).ExecuteReader();

                while (reader.Read())
                {
                    AuthorDTO authorDTO = new AuthorDTO();
                    authorDTO.AuthorId = int.Parse(reader["AuthorID"].ToString());
                    authorDTO.AuthorName = reader["AuthorName"].ToString();
                    authorDTO.CreatedDate = (DateTime)reader["CreatedDate"];
                    authorDTO.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(authorDTO);
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

        public List<AuthorDTO> SearchAuthor(string authorName)
        {
            List<AuthorDTO> list = new List<AuthorDTO>();
            AuthorDTO authorDTO;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0005author",
                                                                    new Dictionary<string, SqlDbType>() { { "@author", SqlDbType.NVarChar } },
                                                                    new List<object>() { authorName }).ExecuteReader();

                while (reader.Read())
                {
                    authorDTO = new AuthorDTO();
                    authorDTO.AuthorId = int.Parse(reader["AuthorID"].ToString());
                    authorDTO.AuthorName = reader["AuthorName"].ToString();
                    authorDTO.CreatedDate = (DateTime)reader["CreatedDate"];
                    authorDTO.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(authorDTO);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - GetAuthorByID", e);
                return null;
            }
            return list;
        }
    }
}
