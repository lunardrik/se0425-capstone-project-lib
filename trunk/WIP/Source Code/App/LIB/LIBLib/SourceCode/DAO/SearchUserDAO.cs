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
    public class SearchUserDAO
    {
        public class SimpleUser
        {
            public string UserID { get; set; }
            public string Username { get; set; }
        }
        public List<UserDTO> SearchUsers(SearchUserDTO dto)
        {
            UserDTO user;
            List<UserDTO> list=new List<UserDTO>();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0002",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@username", SqlDbType.NVarChar},
                                                                            {"@status", SqlDbType.Int},
                                                                            {"@eMail", SqlDbType.NVarChar},
                                                                            {"@idsn", SqlDbType.NVarChar}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            dto.UserName,
                                                                            dto.Status,
                                                                            dto.Email,
                                                                            dto.Isdn
                                                                        }).ExecuteReader();

                while (reader.Read())
                {
                    user=new UserDTO();
                    user.UserId = reader["UserID"].ToString();
                    user.Username = reader["Username"].ToString();
                    //user.Password = reader["Password"].ToString();
                    user.RoleDescription = reader["RoleDescription"].ToString();
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
                    list.Add(user);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at UserDAO - GetUserByID", e);
                return null;
            }
            return list;
        }

        public List<SimpleUser> SimplySearchUser(SearchUserDTO dto)
        {
            List<SimpleUser> list=new List<SimpleUser>();
            SimpleUser sUser;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0002simple",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@userName", SqlDbType.NVarChar},
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            dto.UserName
                                                                        }).ExecuteReader();

                while (reader.Read())
                {
                    sUser=new SimpleUser();
                    sUser.UserID = reader["UserID"].ToString();
                    sUser.Username = reader["Username"].ToString();
                    list.Add(sUser);
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
