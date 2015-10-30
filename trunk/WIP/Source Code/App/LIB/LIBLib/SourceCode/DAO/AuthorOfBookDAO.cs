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
    public class AuthorOfBookDAO
    {
        public int InsertAuthorOfBook(AuthorOfBookDTO authorOfBook, SqlTransaction trans)
        {
            authorOfBook.UpdatedDate = DateTime.Now;
            authorOfBook.CreatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0802",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.Int},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.DateTime},
                                                     {"@Param4", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     authorOfBook.Author.AuthorId,
                                                     authorOfBook.ISBN,
                                                     authorOfBook.CreatedDate,
                                                     authorOfBook.UpdatedDate
                                                 }, trans).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorOfBookDAO - InsertAuthorOfBook", e);
                return 0;
            }

            return 1;
        }

        public int DeleteAuthorOfBook(String isbn, SqlTransaction trans)
        {
            try
            {
                ConnectionManager.GetCommand("SP0804",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar}
                                                 },
                                             new List<object>()
                                                 {
                                                     isbn
                                                 }, trans).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorOfBookDAO - DeleteAuthorOfBook", e);
                return 0;
            }

            return 1;
        }

        public List<AuthorOfBookDTO> GetAuthorListByIsbn(String isbn)
        {
            List<AuthorOfBookDTO> list = new List<AuthorOfBookDTO>();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0801ISBN",
                                                                    new Dictionary<string, SqlDbType>() { { "@Param1", SqlDbType.NVarChar } },
                                                                    new List<object>() { isbn }).ExecuteReader();

                while (reader.Read())
                {
                    AuthorOfBookDTO authorOfBookDto = new AuthorOfBookDTO();
                    authorOfBookDto.ISBN = reader["ISBN"].ToString();
                    //Add code
                    AuthorDTO authorDto = new AuthorDTO();
                    authorDto.AuthorId = int.Parse(reader["AuthorID"].ToString());
                    authorOfBookDto.Author = authorDto;
                    authorOfBookDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    authorOfBookDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(authorOfBookDto);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorOfBookDAO - GetAuthorListByISBN", e);
                return null;
            }

            return list;
        }
    }
}
