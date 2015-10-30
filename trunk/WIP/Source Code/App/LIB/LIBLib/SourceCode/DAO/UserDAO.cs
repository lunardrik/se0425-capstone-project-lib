using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LIB.Common;

namespace LIB
{
    public class UserDAO
    {
        public bool Insert(UserDTO user)
        {
            try
            {
                user.CreatedDate = DateTime.Now;
                user.UpdatedDate = DateTime.Now;
                ConnectionManager.GetCommand("SP0602",
                                             new Dictionary<string, SqlDbType>
                                                 {
                                                     {"@UserID", SqlDbType.NVarChar},
                                                     {"@Username", SqlDbType.NVarChar},
                                                     {"@Password", SqlDbType.NVarChar},
                                                     {"@RoleID", SqlDbType.Int},
                                                     {"@Birthday", SqlDbType.Date},
                                                     {"@Address", SqlDbType.NVarChar},
                                                     {"@Phone", SqlDbType.NVarChar},
                                                     {"@Email", SqlDbType.NVarChar},
                                                     {"@IDSN", SqlDbType.NVarChar},
                                                     {"@IssuedDate", SqlDbType.DateTime},
                                                     {"@ExpiredDate", SqlDbType.DateTime},
                                                     {"@Status", SqlDbType.Int},
                                                     {"@CreatedDate", SqlDbType.DateTime},
                                                     {"@UpdatedDate", SqlDbType.DateTime}
                                                 },
                                             new List<object>
                                                 {
                                                     user.UserId,
                                                     user.Username, 
                                                     user.Password, 
                                                     user.RoleId, 
                                                     user.Birthday, 
                                                     user.Address, 
                                                     user.Phone, 
                                                     user.Email, 
                                                     user.IDSN, 
                                                     user.IssuedDate,  
                                                     user.ExpiredDate,
                                                     user.Status,
                                                     user.CreatedDate,
                                                     user.UpdatedDate
                                                 }).ExecuteReader();

                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at UserDAO - Insert", e);
                return false;
            }
        }

        public bool Update(UserDTO user)
        {
            try
            {
                user.UpdatedDate = DateTime.Now;
                ConnectionManager.GetCommand("SP0603",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@UserID", SqlDbType.NVarChar},
                                                     {"@Username", SqlDbType.NVarChar},
                                                     {"@Password", SqlDbType.NVarChar},
                                                     {"@RoleID", SqlDbType.Int},
                                                     {"@Birthday", SqlDbType.Date},
                                                     {"@Address", SqlDbType.NVarChar},
                                                     {"@Phone", SqlDbType.NVarChar},
                                                     {"@Email", SqlDbType.NVarChar},
                                                     {"@IDSN", SqlDbType.NVarChar},
                                                     {"@IssuedDate", SqlDbType.DateTime},
                                                     {"@ExpiredDate", SqlDbType.DateTime},
                                                     {"@Status", SqlDbType.Int},
                                                     {"@CreatedDate", SqlDbType.DateTime},
                                                     {"@UpdatedDate", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     user.UserId,
                                                     user.Username, 
                                                     user.Password, 
                                                     user.RoleId, 
                                                     user.Birthday, 
                                                     user.Address, 
                                                     user.Phone, 
                                                     user.Email, 
                                                     user.IDSN, 
                                                     user.IssuedDate,  
                                                     user.ExpiredDate,
                                                     user.Status,
                                                     user.CreatedDate,
                                                     user.UpdatedDate
                                                 }).ExecuteReader();

                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at UserDAO - Update", e);
                return false;
            }
        }

        public List<UserDTO> GetAll()
        {
            List<UserDTO> listUser = new List<UserDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0601All", new Dictionary<string, SqlDbType>(), new List<object>()).ExecuteReader();
                UserDTO user;

                while (reader.Read())
                {
                    user = new UserDTO();
                    user.UserId = reader["UserID"].ToString();
                    user.Username = reader["Username"].ToString();
                    user.Password = reader["Password"].ToString();
                    int roleIdTmp;
                    int.TryParse(reader["RoleID"].ToString(), out roleIdTmp);
                    user.RoleId = roleIdTmp;
                    user.Birthday = (DateTime)reader["Birthday"];
                    user.Address = reader["Address"].ToString();
                    user.Phone = reader["Phone"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.IDSN = reader["IDSN"].ToString();
                    user.IssuedDate = (DateTime)reader["IssuedDate"];
                    user.ExpiredDate = (DateTime)reader["ExpiredDate"];
                    int statusTemp;
                    int.TryParse(reader["Status"].ToString(), out statusTemp);
                    user.Status = (UserStatus)Enum.Parse(typeof(UserStatus), statusTemp.ToString());
                    user.CreatedDate = (DateTime)reader["CreatedDate"];
                    user.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listUser.Add(user);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at UserDAO - GetAll", e);
                return null;
            }

            return listUser;
        }

        public UserDTO GetByUsername(string username)
        {
            UserDTO user = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0601ByUsername",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@Username", SqlDbType.NVarChar}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        username
                                                                    }).ExecuteReader();

                if (reader.Read())
                {
                    user = new UserDTO();
                    user.UserId = reader["UserID"].ToString();
                    user.Username = reader["Username"].ToString();
                    user.Password = reader["Password"].ToString();
                    int roleIdTmp;
                    int.TryParse(reader["RoleID"].ToString(), out roleIdTmp);
                    user.RoleId = roleIdTmp;
                    user.Birthday = (DateTime)reader["Birthday"];
                    user.Address = reader["Address"].ToString();
                    user.Phone = reader["Phone"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.IDSN = reader["IDSN"].ToString();
                    user.IssuedDate = (DateTime)reader["IssuedDate"];
                    user.ExpiredDate = (DateTime)reader["ExpiredDate"];
                    int statusTemp;
                    int.TryParse(reader["Status"].ToString(), out statusTemp);
                    user.Status = (UserStatus)Enum.Parse(typeof(UserStatus), statusTemp.ToString());
                    user.CreatedDate = (DateTime)reader["CreatedDate"];
                    user.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at UserDAO - GetByUserName", e);
                return null;
            }

            return user;
        }

        public UserDTO GetByUserId(string userId)
        {
            UserDTO user = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0601ByUserID",
                                                                    new Dictionary<string, SqlDbType>()
                                                                    {
                                                                        {"@UserID", SqlDbType.NVarChar}
                                                                    },
                                                                    new List<object>()
                                                                    {
                                                                        userId
                                                                    }).ExecuteReader();

                if (reader.Read())
                {
                    user = new UserDTO();
                    user.UserId = reader["UserID"].ToString();
                    user.Username = reader["Username"].ToString();
                    user.Password = reader["Password"].ToString();
                    int roleIdTmp;
                    int.TryParse(reader["RoleID"].ToString(), out roleIdTmp);
                    user.RoleId = roleIdTmp;
                    user.Birthday = (DateTime)reader["Birthday"];
                    user.Address = reader["Address"].ToString();
                    user.Phone = reader["Phone"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.IDSN = reader["IDSN"].ToString();
                    user.IssuedDate = (DateTime)reader["IssuedDate"];
                    user.ExpiredDate = (DateTime)reader["ExpiredDate"];
                    int statusTemp;
                    int.TryParse(reader["Status"].ToString(), out statusTemp);
                    user.Status = (UserStatus)Enum.Parse(typeof(UserStatus), statusTemp.ToString());
                    user.CreatedDate = (DateTime)reader["CreatedDate"];
                    user.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at UserDAO - GetByUserName", e);
                return null;
            }

            return user;
        }
    }
}
