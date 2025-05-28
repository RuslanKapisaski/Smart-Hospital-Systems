namespace Hospital_System.BLL.Interfaces
{
    using Hospital_System.DAL.Models.DTOs;
    interface IRoleService
    {
        void AddRole(RoleDTO roleDto);

        bool RemoveRoleByUserId(string userId);

    }
}
