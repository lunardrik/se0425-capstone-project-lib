using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using LIB.Common;

namespace LIB
{
    public class BookRegisterDAO
    {
        public bool Insert(BookRegisterDTO bookRegister)
        {
            try
            {
                bookRegister.CreatedDate = DateTime.Now;
                bookRegister.UpdatedDate = DateTime.Now;
                ConnectionManager.GetCommand("SP1002",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@UserID", SqlDbType.NVarChar},
                                                     {"@ISBN", SqlDbType.NVarChar},
                                                     {"@RegisterDate", SqlDbType.DateTime},
                                                     {"@Note", SqlDbType.NText},
                                                     {"@Status", SqlDbType.Int},
                                                     {"@CreatedDate", SqlDbType.DateTime},
                                                     {"@UpdatedDate", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     bookRegister.UserId,
                                                     bookRegister.ISBN,
                                                     bookRegister.RegisterDate,
                                                     bookRegister.Note,
                                                     bookRegister.Status,
                                                     bookRegister.CreatedDate,
                                                     bookRegister.UpdatedDate
                                                 }).ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - Insert", e);
                throw;
            }
        }

        public bool Update(BookRegisterDTO bookRegister)
        {
            try
            {
                bookRegister.UpdatedDate = DateTime.Now;
                ConnectionManager.GetCommand("SP1003",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@UserID", SqlDbType.NVarChar},
                                                     {"@ISBN", SqlDbType.NVarChar},
                                                     {"@RegisterDate", SqlDbType.DateTime},
                                                     {"@Note", SqlDbType.NText},
                                                     {"@Status", SqlDbType.Int},
                                                     {"@CreatedDate", SqlDbType.DateTime},
                                                     {"@UpdatedDate", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     bookRegister.UserId,
                                                     bookRegister.ISBN,
                                                     bookRegister.RegisterDate,
                                                     bookRegister.Note,
                                                     bookRegister.Status,
                                                     bookRegister.CreatedDate,
                                                     bookRegister.UpdatedDate
                                                 }).ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - Update", e);
                return false;
            }
        }

        public bool Delete(string userId, String isbn, DateTime registerDate)
        {
            try
            {
                ConnectionManager.GetCommand("SP1004",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@UserID", SqlDbType.NVarChar},
                                                     {"@ISBN", SqlDbType.NVarChar},
                                                     {"@RegisterDate", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     userId,
                                                     isbn,
                                                     registerDate
                                                 }).ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - Delete", e);
                return false;
            }
        }

        public List<BookRegisterDTO> GetAll()
        {
            List<BookRegisterDTO> listRegister = new List<BookRegisterDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP1001All", new Dictionary<string, SqlDbType>(), new List<object>()).ExecuteReader();
                BookRegisterDTO register;

                while (reader.Read())
                {
                    register = new BookRegisterDTO();
                    register.UserId = reader["UserID"].ToString();
                    register.ISBN = reader["ISBN"].ToString();
                    register.RegisterDate = (DateTime)reader["RegisterDate"];
                    register.Note = reader["Note"].ToString();
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    register.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    register.CreatedDate = (DateTime)reader["CreatedDate"];
                    register.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRegister.Add(register);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - GetAll", e);
                return null;
            }

            return listRegister;
        }

        public List<BookRegisterDTO> GetByIsbn(string isbn)
        {
            List<BookRegisterDTO> listRegister = new List<BookRegisterDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP1001ByISBN",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@ISBN", SqlDbType.NVarChar}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        isbn      
                                                                    }).ExecuteReader();
                BookRegisterDTO register;

                while (reader.Read())
                {
                    register = new BookRegisterDTO();
                    register.UserId = reader["UserID"].ToString();
                    register.ISBN = reader["ISBN"].ToString();
                    register.RegisterDate = (DateTime)reader["RegisterDate"];
                    register.Note = reader["Note"].ToString();
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    register.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    register.CreatedDate = (DateTime)reader["CreatedDate"];
                    register.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRegister.Add(register);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - GetByISBN", e);
                return null;
            }

            return listRegister;
        }

        public List<BookRegisterDTO> GetByUserId(string userId)
        {
            List<BookRegisterDTO> listRegister = new List<BookRegisterDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP1001ByUserID",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@UserID", SqlDbType.NVarChar}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        userId      
                                                                    }).ExecuteReader();
                BookRegisterDTO register;

                while (reader.Read())
                {
                    register = new BookRegisterDTO();
                    register.UserId = reader["UserID"].ToString();
                    register.ISBN = reader["ISBN"].ToString();
                    register.RegisterDate = (DateTime)reader["RegisterDate"];
                    register.Note = reader["Note"].ToString();
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    register.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    register.CreatedDate = (DateTime)reader["CreatedDate"];
                    register.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRegister.Add(register);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - GetByUserID", e);
                return null;
            }

            return listRegister;
        }

        public List<BookRegisterDTO> GetByUserIdPaging(string userId, int start, int end, out int noR)
        {
            List<BookRegisterDTO> listRegister = new List<BookRegisterDTO>();

            try
            {

                noR = (int)ConnectionManager.GetCommand("SP1001ByUserIDPagingC",
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
                                                                    }).ExecuteScalar();

                if (noR != 0)
                {
                    SqlDataReader reader = ConnectionManager.GetCommand("SP1001ByUserIDPaging",
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
                    BookRegisterDTO register;

                    while (reader.Read())
                    {
                        register = new BookRegisterDTO();
                        register.UserId = reader["UserID"].ToString();
                        register.ISBN = reader["ISBN"].ToString();
                        register.RegisterDate = (DateTime) reader["RegisterDate"];
                        register.Note = reader["Note"].ToString();
                        int status;
                        int.TryParse(reader["Status"].ToString(), out status);
                        register.Status =
                            (BookRegisterStatus) Enum.Parse(typeof (BookRegisterStatus), status.ToString());
                        register.CreatedDate = (DateTime) reader["CreatedDate"];
                        register.UpdatedDate = (DateTime) reader["UpdatedDate"];

                        listRegister.Add(register);
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - GetByUserID", e);
                noR = 0;
                return null;
            }

            return listRegister;
        }

        public List<BookRegisterDTO> GetByStatus(int status)
        {
            List<BookRegisterDTO> listRegister = new List<BookRegisterDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP1001ByStatus",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@Status", SqlDbType.NVarChar}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        status      
                                                                    }).ExecuteReader();
                BookRegisterDTO register;

                while (reader.Read())
                {
                    register = new BookRegisterDTO();
                    register.UserId = reader["UserID"].ToString();
                    register.ISBN = reader["ISBN"].ToString();
                    register.RegisterDate = (DateTime)reader["RegisterDate"];
                    register.Note = reader["Note"].ToString();
                    int statusTmp;
                    int.TryParse(reader["Status"].ToString(), out statusTmp);
                    register.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    register.CreatedDate = (DateTime)reader["CreatedDate"];
                    register.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRegister.Add(register);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - GetByStatus", e);
                return null;
            }

            return listRegister;
        }

        public List<BookRegisterDTO> GetByRegisterDate(DateTime registerDate)
        {
            List<BookRegisterDTO> listRegister = new List<BookRegisterDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP1001ByRegisterDate",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@RegisterDate", SqlDbType.DateTime}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        registerDate      
                                                                    }).ExecuteReader();
                BookRegisterDTO register;

                while (reader.Read())
                {
                    register = new BookRegisterDTO();
                    register.UserId = reader["UserID"].ToString();
                    register.ISBN = reader["ISBN"].ToString();
                    register.RegisterDate = (DateTime)reader["RegisterDate"];
                    register.Note = reader["Note"].ToString();
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    register.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    register.CreatedDate = (DateTime)reader["CreatedDate"];
                    register.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRegister.Add(register);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - GetByRegisterDate", e);
                return null;
            }

            return listRegister;
        }

        public BookRegisterDTO GetByPrimaryKey(string userId, string isbn, DateTime registerDate)
        {
            BookRegisterDTO registerDto = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP1001ByPrimaryKey",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@UserID", SqlDbType.NVarChar},
                                                                        {"@ISBN", SqlDbType.NVarChar},
                                                                        {"@RegisterDate", SqlDbType.DateTime}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        userId,
                                                                        isbn,
                                                                        registerDate      
                                                                    }).ExecuteReader();

                if (reader.Read())
                {
                    registerDto = new BookRegisterDTO();
                    registerDto.UserId = reader["UserID"].ToString();
                    registerDto.ISBN = reader["ISBN"].ToString();
                    registerDto.RegisterDate = (DateTime)reader["RegisterDate"];
                    registerDto.Note = reader["Note"].ToString();
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    registerDto.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    registerDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    registerDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at BookRegisterDAO - GetByRegisterDate", e);
                return null;
            }

            return registerDto;
        }

        public List<BookRegisterDTO> GetByCreatedDate(DateTime createdDate)
        {
            List<BookRegisterDTO> listRegister = new List<BookRegisterDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP1001ByCreatedDate",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@CreatedDate", SqlDbType.DateTime}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        createdDate      
                                                                    }).ExecuteReader();
                BookRegisterDTO register;

                while (reader.Read())
                {
                    register = new BookRegisterDTO();
                    register.UserId = reader["UserID"].ToString();
                    register.ISBN = reader["ISBN"].ToString();
                    register.RegisterDate = (DateTime)reader["RegisterDate"];
                    register.Note = reader["Note"].ToString();
                    int status;
                    int.TryParse(reader["Status"].ToString(), out status);
                    register.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    register.CreatedDate = (DateTime)reader["CreatedDate"];
                    register.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRegister.Add(register);
                }
            }
            catch (Exception e)
            {
                Log.Logger.Error("Error at BookRegisterDAO - GetByRegisterDate", e);
                return null;
            }

            return listRegister;
        }

        public List<BookRegisterDTO> GetByStatusAndCreatedDate(BookRegisterStatus status, DateTime createdDate)
        {
            var listRegister = new List<BookRegisterDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP1001ByStatusAndCreatedDate",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@Status", SqlDbType.Int},
                                                                        {"@CreatedDate", SqlDbType.DateTime}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        (int) status,
                                                                        createdDate      
                                                                    }).ExecuteReader();
                BookRegisterDTO register;

                while (reader.Read())
                {
                    register = new BookRegisterDTO();
                    register.UserId = reader["UserID"].ToString();
                    register.ISBN = reader["ISBN"].ToString();
                    register.RegisterDate = (DateTime)reader["RegisterDate"];
                    register.Note = reader["Note"].ToString();
                    int statusTmp;
                    int.TryParse(reader["Status"].ToString(), out statusTmp);
                    register.Status = (BookRegisterStatus)Enum.Parse(typeof(BookRegisterStatus), status.ToString());
                    register.CreatedDate = (DateTime)reader["CreatedDate"];
                    register.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRegister.Add(register);
                }
            }
            catch (Exception e)
            {
                Log.Logger.Error("Error at BookRegisterDAO - GetByStatusAndCreatedDate", e);
                return null;
            }

            return listRegister;
        }

    }
}
