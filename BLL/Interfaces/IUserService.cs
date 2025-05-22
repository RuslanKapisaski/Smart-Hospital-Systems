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

        bool EditUser(string userID,RoleDTO newRole);

        bool DeleteUser(string userId);

        bool AddRoleToUser(string userId, RoleDTO roleDto);

        List<User> GetAllUsers();
    }
}
