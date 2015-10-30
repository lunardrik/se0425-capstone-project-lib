using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LIB.Common;

namespace LIB
{
    public class RoleDAO
    {
        public List<RoleDTO> GetAll()
        {
            var listRole = new List<RoleDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0701All", new Dictionary<string, SqlDbType>(), new List<object>()).ExecuteReader();
                RoleDTO role;

                while (reader.Read())
                {
                    role = new RoleDTO();
                    int roleIdTmp;
                    int.TryParse(reader["RoleID"].ToString(), out roleIdTmp);
                    role.RoleId = roleIdTmp;
                    role.RoleDescription = reader["RoleDescription"].ToString();
                    role.CreatedDate = (DateTime)reader["CreatedDate"];
                    role.UpdatedDate = (DateTime)reader["UpdatedDate"];

                    listRole.Add(role);
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at RoleDAO - GetAll", e);
            }

            return listRole;
        }

        public RoleDTO GetById(int roleId)
        {
            RoleDTO roleDto = null;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0701ByID",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@RoleID", SqlDbType.Int}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            roleId   
                                                                        }).ExecuteReader();

                if (reader.Read())
                {
                    roleDto = new RoleDTO();
                    int roleIdTmp;
                    int.TryParse(reader["RoleID"].ToString(), out roleIdTmp);
                    roleDto.RoleId = roleIdTmp;
                    roleDto.RoleDescription = reader["RoleDescription"].ToString();
                    roleDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    roleDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at RoleDAO - GetAll", e);
            }

            return roleDto;
        }
    }
}
