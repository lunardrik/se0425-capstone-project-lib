using System;
using System.Collections.Generic;

namespace LIB
{
    public class RoleBUS
    {
        private readonly RoleDAO _roleDao = new RoleDAO();

        public List<RoleDTO> GetAllRole()
        {
            return _roleDao.GetAll();
        }

        public RoleDTO GetRoleById(int roleId)
        {
            return _roleDao.GetById(roleId);
        }

    }
}