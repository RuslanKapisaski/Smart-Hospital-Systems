namespace Hospital_System.BLL.Interfaces
{
    using Hospital_System.DAL.Models;
    using System.Collections.Generic;

    interface IRoleService
    {
        void AddRole(Role roleDto);

        List<Role> GetRoles();

    }
}
