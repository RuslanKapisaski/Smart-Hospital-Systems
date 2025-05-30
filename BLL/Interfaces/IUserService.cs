namespace Hospital_System.BLL.Interfaces
{
    using Hospital_System.DAL.Models;
    using Hospital_System.DAL.Models.DTOs;
    using System.Collections.Generic;
    interface IUserService
    {
        bool RegisterUser(User user);

        UserDTO LoginUser(UserDTO user);

        public User GetUserById(int id);

        User GetUserByEmail(string email);

        bool EditUserRole(int userID, Role role);

        bool DeleteUser(int userId);

        bool AddRoleToUser(int userId, Role role);

        IReadOnlyList<UserDTO> GetAllUsersDTOs();

        IReadOnlyList<User> GetAllUsers();
    }
}
