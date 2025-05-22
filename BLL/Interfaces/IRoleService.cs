using Hospital_System.DAL.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Interfaces
{
    interface IRoleService
    {
        void AddRole(RoleDTO roleDto);

        bool RemoveRoleByUserId(string userId);
    }
}
