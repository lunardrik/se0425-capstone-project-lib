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
    public class SearchRentalDAO
    {
        public List<RentalDTO> SearchRentals(SearchRentalDTO dto)
        {
            RentalDTO rentalDto;
            List<RentalDTO> list = new List<RentalDTO>();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0004",
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
                    rentalDto = new RentalDTO();
                    rentalDto.Username = reader["Username"].ToString();
                    rentalDto.BookTitle = reader["Title"].ToString();
                    rentalDto.Barcode = reader["Barcode"].ToString();
                    rentalDto.IssueDate = DateTime.Parse(reader["IssuedDate"].ToString());
                    rentalDto.DueDate = DateTime.Parse(reader["DueDate"].ToString());
                    if (reader["ReturnDate"] == DBNull.Value)
                    {
                        rentalDto.ReturnDate = null;
                    }
                    else
                    {
                        rentalDto.ReturnDate = DateTime.Parse(reader["ReturnDate"].ToString());
                    }
                    float fine;
                    float.TryParse(reader["Fine"].ToString(), out fine);
                    rentalDto.Fine = fine;
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    rentalDto.Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), status.ToString());
                    int expandCount;
                    int.TryParse(reader["ExpandCount"].ToString(), out expandCount);
                    rentalDto.ExpandCount = expandCount;
                    list.Add(rentalDto);
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

        public List<RentalDTO> SearchRentalsAllStt(SearchRentalDTO dto)
        {
            RentalDTO rentalDto;
            List<RentalDTO> list = new List<RentalDTO>();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0004AllStt",
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
                    rentalDto = new RentalDTO();
                    rentalDto.Username = reader["Username"].ToString();
                    rentalDto.BookTitle = reader["Title"].ToString();
                    rentalDto.Barcode = reader["Barcode"].ToString();
                    rentalDto.IssueDate = DateTime.Parse(reader["IssuedDate"].ToString());
                    rentalDto.DueDate = DateTime.Parse(reader["DueDate"].ToString());
                    if (reader["ReturnDate"] == DBNull.Value)
                    {
                        rentalDto.ReturnDate = null;
                    }
                    else
                    {
                        rentalDto.ReturnDate = DateTime.Parse(reader["ReturnDate"].ToString());
                    }
                    float fine;
                    float.TryParse(reader["Fine"].ToString(), out fine);
                    rentalDto.Fine = fine;
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    rentalDto.Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), status.ToString());
                    int expandCount;
                    int.TryParse(reader["ExpandCount"].ToString(), out expandCount);
                    rentalDto.ExpandCount = expandCount;
                    list.Add(rentalDto);
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
