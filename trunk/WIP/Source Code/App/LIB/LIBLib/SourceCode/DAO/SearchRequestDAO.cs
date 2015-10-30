using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using LIB;
using LIB.Common;

namespace LIB
{
    public class SearchRequestDAO
    {
        public List<BookRegisterDTO> SearchRequests(SearchRequestDTO dto)
        {
            BookRegisterDTO bookReg;
            List<BookRegisterDTO> list = new List<BookRegisterDTO>();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0003",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@userName", SqlDbType.NVarChar},
                                                                            {"@title", SqlDbType.NVarChar},
                                                                            {"@status", SqlDbType.Int},
                                                                            {"@fromDate", SqlDbType.DateTime},
                                                                            {"@toDate", SqlDbType.DateTime}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            dto.UserName,
                                                                            dto.Title,
                                                                            dto.Status,
                                                                            dto.FromDate,
                                                                            dto.ToDate
                                                                        }).ExecuteReader();

                while (reader.Read())
                {
                    bookReg = new BookRegisterDTO();
                    bookReg.Username = reader["Username"].ToString();
                    bookReg.BookTitle = reader["Title"].ToString();
                    bookReg.RegisterDate = DateTime.Parse(reader["RegisterDate"].ToString());
                    bookReg.Note = reader["Note"].ToString();
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    bookReg.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    list.Add(bookReg);
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

        public List<BookRegisterDTO> SearchRequestAllStt(SearchRequestDTO dto)
        {
            BookRegisterDTO bookReg;
            List<BookRegisterDTO> list = new List<BookRegisterDTO>();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0003AllStt",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@userName", SqlDbType.NVarChar},
                                                                            {"@title", SqlDbType.NVarChar},
                                                                            {"@fromDate", SqlDbType.DateTime},
                                                                            {"@toDate", SqlDbType.DateTime}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            dto.UserName,
                                                                            dto.Title,
                                                                            dto.FromDate,
                                                                            dto.ToDate
                                                                        }).ExecuteReader();

                while (reader.Read())
                {
                    bookReg = new BookRegisterDTO();
                    bookReg.Username = reader["Username"].ToString();
                    bookReg.BookTitle = reader["Title"].ToString();
                    bookReg.RegisterDate = DateTime.Parse(reader["RegisterDate"].ToString());
                    bookReg.Note = reader["Note"].ToString();
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    bookReg.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    list.Add(bookReg);
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
