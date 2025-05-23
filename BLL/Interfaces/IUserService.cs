using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Interfaces
{
    interface IUserService
    {
        bool RegisterUser(User user);

        bool LoginUser(UserDTO user);

        bool EditUserRole(int userID, RoleDTO newRole);

        bool DeleteUser(int userId);

        bool AddRoleToUser(int userId, RoleDTO roleDto);

        IReadOnlyList<UserDTO> GetAllUsersDTOs();

        IReadOnlyList<User> GetAllUsers();
    }
}
