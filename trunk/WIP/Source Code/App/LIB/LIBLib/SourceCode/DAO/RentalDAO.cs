using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using LIB.Common;
using System.Data;

namespace LIB
{
    public class RentalDAO
    {

        public bool Insert(RentalDTO rental)
        {
            try
            {
                rental.CreatedDate = DateTime.Now;
                rental.UpdatedDate = DateTime.Now;
                ConnectionManager.GetCommand("SP0902",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@UserID", SqlDbType.NVarChar},
                                                     {"@Barcode", SqlDbType.NVarChar},
                                                     {"@IssuedDate", SqlDbType.DateTime},
                                                     {"@DueDate", SqlDbType.DateTime},
                                                     {"@ReturnDate", SqlDbType.DateTime},
                                                     {"@Fine", SqlDbType.Float},
                                                     {"@Status", SqlDbType.Int},
                                                     {"@ExpandCount", SqlDbType.Int},
                                                     {"@CreatedDate", SqlDbType.DateTime},
                                                     {"@UpdatedDate", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     rental.UserId,
                                                     rental.Barcode,
                                                     rental.IssueDate,
                                                     rental.DueDate,
                                                     //if ReturnDate is null, insert null to DB
                                                     rental.ReturnDate ?? SqlDateTime.Null,
                                                     rental.Fine,
                                                     (int)rental.Status,
                                                     rental.ExpandCount,
                                                     rental.CreatedDate,
                                                     rental.UpdatedDate
                                                 }).ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at RentalDAO - Insert", e);
                return false;
            }
        }

        public bool Update(RentalDTO rental)
        {
            try
            {
                rental.UpdatedDate = DateTime.Now;
                ConnectionManager.GetCommand("SP0903",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@UserID", SqlDbType.NVarChar},
                                                     {"@Barcode", SqlDbType.NVarChar},
                                                     {"@IssuedDate", SqlDbType.DateTime},
                                                     {"@DueDate", SqlDbType.DateTime},
                                                     {"@ReturnDate", SqlDbType.DateTime},
                                                     {"@Fine", SqlDbType.Float},
                                                     {"@Status", SqlDbType.Int},
                                                     {"@ExpandCount", SqlDbType.Int},
                                                     {"@CreatedDate", SqlDbType.DateTime},
                                                     {"@UpdatedDate", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     rental.UserId,
                                                     rental.Barcode,
                                                     rental.IssueDate,
                                                     rental.DueDate,
                                                     //if ReturnDate is null, insert null to DB
                                                     rental.ReturnDate ?? SqlDateTime.Null,
                                                     rental.Fine,
                                                     rental.Status,
                                                     rental.ExpandCount,
                                                     rental.CreatedDate,
                                                     rental.UpdatedDate
                                                 }).ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at RentalDAO - Update", e);
                return false;
            }
        }

        public List<RentalDTO> GetAll()
        {
            List<RentalDTO> listRental = new List<RentalDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0901All", new Dictionary<string, SqlDbType>(), new List<object>()).ExecuteReader();
                RentalDTO rental;

                while (reader.Read())
                {
                    rental = new RentalDTO();
                    rental.UserId = reader["UserID"].ToString();
                    rental.Barcode = reader["Barcode"].ToString();
                    rental.IssueDate = (DateTime)reader["IssuedDate"];
                    rental.DueDate = (DateTime)reader["DueDate"];

                    if (reader["ReturnDate"] == DBNull.Value)
                    {
                        rental.ReturnDate = null;
                    }
                    else
                    {
                        rental.ReturnDate = (DateTime)reader["ReturnDate"];
                    }
                    float fine;
                    float.TryParse(reader["Fine"].ToString(), out fine);
                    rental.Fine = fine;
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    rental.Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), status.ToString());
                    int expandCount;
                    int.TryParse(reader["ExpandCount"].ToString(), out expandCount);
                    rental.ExpandCount = expandCount;
                    rental.CreatedDate = (DateTime)reader["CreatedDate"];
                    rental.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRental.Add(rental);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at RentalDAO - GetAll", e);
                return null;
            }

            return listRental;
        }

        public List<RentalDTO> GetByUserId(string userId)
        {
            List<RentalDTO> listRental = new List<RentalDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0901ByUserID",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@UserID", SqlDbType.NVarChar}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            userId
                                                                        }).ExecuteReader();
                RentalDTO rental;

                while (reader.Read())
                {
                    rental = new RentalDTO();
                    rental.UserId = reader["UserID"].ToString();
                    rental.Barcode = reader["Barcode"].ToString();
                    rental.IssueDate = (DateTime)reader["IssuedDate"];
                    rental.DueDate = (DateTime)reader["DueDate"];
                    if (reader["ReturnDate"] == DBNull.Value)
                    {
                        rental.ReturnDate = null;
                    }
                    else
                    {
                        rental.ReturnDate = (DateTime)reader["ReturnDate"];
                    } 
                    float fine;
                    float.TryParse(reader["Fine"].ToString(), out fine);
                    rental.Fine = fine;
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    rental.Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), status.ToString());
                    int expandCount;
                    int.TryParse(reader["ExpandCount"].ToString(), out expandCount);
                    rental.ExpandCount = expandCount;
                    rental.CreatedDate = (DateTime)reader["CreatedDate"];
                    rental.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRental.Add(rental);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at RentalDAO - GetByUserID", e);
                return null;
            }

            return listRental;
        }

        public List<RentalDTO> GetByUserIdPaging(string userId, int start, int end, out int noR)
        {
            List<RentalDTO> listRental = new List<RentalDTO>();

            try
            {
                noR = (int) ConnectionManager.GetCommand("SP0901ByUserIDPagingC",
                                                         new Dictionary<string, SqlDbType>()
                                                             {
                                                                 {"@UserID", SqlDbType.NVarChar}
                                                             },
                                                         new List<object>()
                                                             {
                                                                 userId
                                                             }).ExecuteScalar();

                if (noR != 0)
                {
                    SqlDataReader reader = ConnectionManager.GetCommand("SP0901ByUserIDPaging",
                                                                        new Dictionary<string, SqlDbType>()
                                                                            {
                                                                                {"@UserID", SqlDbType.NVarChar},
                                                                                {"@StartRow", SqlDbType.NVarChar},
                                                                                {"@EndRow", SqlDbType.NVarChar}
                                                                            },
                                                                        new List<object>()
                                                                            {
                                                                                userId,
                                                                                start,
                                                                                end
                                                                            }).ExecuteReader();
                    RentalDTO rental;

                    while (reader.Read())
                    {
                        rental = new RentalDTO();
                        rental.UserId = reader["UserID"].ToString();
                        rental.Barcode = reader["Barcode"].ToString();
                        rental.IssueDate = (DateTime) reader["IssuedDate"];
                        rental.DueDate = (DateTime) reader["DueDate"];
                        if (reader["ReturnDate"] == DBNull.Value)
                        {
                            rental.ReturnDate = null;
                        }
                        else
                        {
                            rental.ReturnDate = (DateTime) reader["ReturnDate"];
                        }
                        float fine;
                        float.TryParse(reader["Fine"].ToString(), out fine);
                        rental.Fine = fine;
                        int status;
                        int.TryParse(reader["Status"].ToString(), out status);
                        rental.Status = (RentalStatus) Enum.Parse(typeof (RentalStatus), status.ToString());
                        int expandCount;
                        int.TryParse(reader["ExpandCount"].ToString(), out expandCount);
                        rental.ExpandCount = expandCount;
                        rental.CreatedDate = (DateTime) reader["CreatedDate"];
                        rental.UpdatedDate = (DateTime) reader["UpdatedDate"];

                        listRental.Add(rental);
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at RentalDAO - GetByUserIDPaging", e);
                noR = 0;
                return null;
            }
            
            return listRental;
        }
        
        public List<RentalDTO> GetByBarcode(string barcode)
        {
            List<RentalDTO> listRental = new List<RentalDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0901ByBarcode",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@Barcode", SqlDbType.NVarChar}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            barcode
                                                                        }).ExecuteReader();
                RentalDTO rental;

                while (reader.Read())
                {
                    rental = new RentalDTO();
                    rental.UserId = reader["UserID"].ToString();
                    rental.Barcode = reader["Barcode"].ToString();
                    rental.IssueDate = (DateTime)reader["IssuedDate"];
                    rental.DueDate = (DateTime)reader["DueDate"];
                    rental.ReturnDate = (DateTime)reader["ReturnDate"];
                    float fine;
                    float.TryParse(reader["Fine"].ToString(), out fine);
                    rental.Fine = fine;
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    rental.Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), status.ToString());
                    int expandCount;
                    int.TryParse(reader["ExpandCount"].ToString(), out expandCount);
                    rental.ExpandCount = expandCount;
                    rental.CreatedDate = (DateTime)reader["CreatedDate"];
                    rental.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRental.Add(rental);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at RentalDAO - GetByBarcode", e);
                return null;
            }

            return listRental;
        }

        public List<RentalDTO> GetByStatus(int status)
        {
            List<RentalDTO> listRental = new List<RentalDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0901ByStatus",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@Status", SqlDbType.Int}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            status
                                                                        }).ExecuteReader();
                RentalDTO rental;

                while (reader.Read())
                {
                    rental = new RentalDTO();
                    rental.UserId = reader["UserID"].ToString();
                    rental.Barcode = reader["Barcode"].ToString();
                    rental.IssueDate = (DateTime)reader["IssuedDate"];
                    rental.DueDate = (DateTime)reader["DueDate"];
                    rental.ReturnDate = (DateTime)reader["ReturnDate"];
                    float fine;
                    float.TryParse(reader["Fine"].ToString(), out fine);
                    rental.Fine = fine;
                    int statusTmp;
                    int.TryParse(reader["Status"].ToString(), out statusTmp);
                    rental.Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), status.ToString());
                    int expandCount;
                    int.TryParse(reader["ExpandCount"].ToString(), out expandCount);
                    rental.ExpandCount = expandCount;
                    rental.CreatedDate = (DateTime)reader["CreatedDate"];
                    rental.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRental.Add(rental);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at RentalDAO - GetByStatus", e);
                return null;
            }

            return listRental;
        }

        public List<RentalDTO> GetByIssuedDate(DateTime issuedDate)
        {
            List<RentalDTO> listRental = new List<RentalDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0901ByIssuedDate",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@IssuedDate", SqlDbType.DateTime}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            issuedDate
                                                                        }).ExecuteReader();
                RentalDTO rental;

                while (reader.Read())
                {
                    rental = new RentalDTO();
                    rental.UserId = reader["UserID"].ToString();
                    rental.Barcode = reader["Barcode"].ToString();
                    rental.IssueDate = (DateTime)reader["IssuedDate"];
                    rental.DueDate = (DateTime)reader["DueDate"];
                    rental.ReturnDate = (DateTime)reader["ReturnDate"];
                    float fine;
                    float.TryParse(reader["Fine"].ToString(), out fine);
                    rental.Fine = fine;
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    rental.Status = (RentalStatus)Enum.Parse(typeof(RentalStatus), status.ToString());
                    int expandCount;
                    int.TryParse(reader["ExpandCount"].ToString(), out expandCount);
                    rental.ExpandCount = expandCount;
                    rental.CreatedDate = (DateTime)reader["CreatedDate"];
                    rental.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRental.Add(rental);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at RentalDAO - GetByIssuedDate", e);
                return null;
            }

            return listRental;
        }
    }
}
