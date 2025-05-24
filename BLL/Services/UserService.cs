namespace Hospital_System.DAL.Services
{
    using Hospital_System.BLL.Interfaces;
    using Hospital_System.DAL.DB;
    using Hospital_System.DAL.Models;
    using Hospital_System.DAL.Models.DTOs;
    using Hospital_System.Utils;
    using Mapster;
    using Npgsql;
    using System;
    using System.Collections.Generic;
    //using System.Data.Entity;
    using System.Linq;

    public class UserService : IUserService
    {
        private readonly HospitalDbContext _hospitalDbContext;

        public UserService(HospitalDbContext dbContext)
        {
            this._hospitalDbContext = dbContext;
        }

        public bool RegisterUser(User user)
        {
            if (user != null)
            {
                throw new ArgumentException(ExceptionMessages.UserAlreadyExist);
            }
            if (this._hospitalDbContext.Users.Any(u => u.Email == user.Email))
            {
                throw new ArgumentException(ExceptionMessages.UserAlreadyExist);
            }
            else
            {
                this
                    ._hospitalDbContext
                    .Users
                    .Add(user);

                bool isRegistered = this._hospitalDbContext.SaveChanges() == 1;

                return isRegistered;
            }

        }

        public bool LoginUser(UserDTO user)
        {
            string userEmail = user.Email;
            bool isRegistered = this
                ._hospitalDbContext
                .Users
                .Any(u => userEmail == u.Email && u.Password == user.Password);

            if (isRegistered == false)
            {
                throw new ArgumentException(ExceptionMessages.UserAlreadyExist);
            }
            else
            {
                return isRegistered;
            }

        }

        public bool AddRoleToUser(int userId, RoleDTO roleDto)
        {
            var user = this._hospitalDbContext.Users.Find(userId);

            if (user == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }

            var newRole = roleDto.Adapt<Role>();
            user.Role = newRole;

            bool isNewRoleCreated = this._hospitalDbContext.SaveChanges() == 1;

            return isNewRoleCreated;

        }

        public bool EditUserRole(int userID, RoleDTO roleDto)
        {
            User user = this
                ._hospitalDbContext
                .Users
                .Find(userID);

            if (user == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }
            //Setting a new role by admin roles 0 -> 4 valid
            var newRole = roleDto.Adapt<Role>();
            if (newRole == null || newRole.RoleId != 0 || newRole.RoleId != 1 || newRole.RoleId != 2 || newRole.RoleId != 3 || newRole.RoleId != 4)
            {
                throw new ArgumentException(ExceptionMessages.InvlidRole);
            }

            user.Role = newRole;

            this._hospitalDbContext
                .Users
                .Add(user);

            bool isNewRoleEdited = this._hospitalDbContext.SaveChanges() == 1;

            return isNewRoleEdited;
        }

        public bool DeleteUser(int userId)
        {
            User user = this
                ._hospitalDbContext
                .Users
                .Find(userId);

            if (user == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }

            this._hospitalDbContext
                .Users
                .Remove(user);
            bool isDeleted = this._hospitalDbContext.SaveChanges() == 1;

            return isDeleted;
        }

        public IReadOnlyList<User> GetAllUsers()
        {
            var users = this
                ._hospitalDbContext
                .Users
                .ToList();

            if (users == null)
            {
                throw new ArgumentException(ExceptionMessages.NoUsersExist);
            }
            else
            {
                return users;
            }
        }

        public IReadOnlyList<UserDTO> GetAllUsersDTOs()
        {
            var users = this
                 ._hospitalDbContext
                 .Users
                 .ToList();

            if (users == null)
            {
                throw new ArgumentException(ExceptionMessages.NoUsersExist);
            }
            else
            {
                return users.Adapt<IReadOnlyList<UserDTO>>();
            }
        }

    }
}

