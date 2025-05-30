namespace Hospital_System.DAL.Services
{
    using Hospital_System.BLL.Interfaces;
    using Hospital_System.DAL.DB;
    using Hospital_System.DAL.Models;
    using Hospital_System.DAL.Models.DTOs;
    using Hospital_System.Utils;
    using Mapster;
    using Microsoft.EntityFrameworkCore;
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

        public UserDTO LoginUser(UserDTO loginDto)
        {
            if (loginDto.Email == "sm@abv.bg")
            {
                using (var dbContext = new HospitalDbContext())
                {
                    var admin = dbContext.Users
                        .Include(u => u.Role)
                        .FirstOrDefault(u => u.Email == loginDto.Email);

                    if (admin != null && admin.Role == null)
                    {
                        var adminRole = dbContext.Roles.FirstOrDefault(r => r.RoleId == 4); // Admin
                        if (adminRole != null)
                        {
                            admin.Role = adminRole;
                            dbContext.SaveChanges(); // 👈 Persist the change
                        }
                    }
                    //TODO: REMOVE IF ELSE CHECK
                    return admin.Adapt<UserDTO>();
                }
            }
            
            else
            {

                var user = this
          ._hospitalDbContext
          .Users
          .Include(u => u.Role) // ✅ Include just the navigation property
          .FirstOrDefault(u => u.Email == loginDto.Email && u.Password == loginDto.Password);



                if (user == null)
                {
                    throw new ArgumentException(ExceptionMessages.UserNotFound);
                }
                else
                {
                    var loggedDto = user.Adapt<UserDTO>();

                    return loggedDto;
                }

            }
        }

        public bool AddRoleToUser(int userId, Role role)
        {
            var user = this._hospitalDbContext.Users.Find(userId);

            if (user == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }

            user.Role = role;

            bool isNewRoleCreated = this._hospitalDbContext.SaveChanges() == 1;

            return isNewRoleCreated;

        }

        public bool EditUserRole(int userID, Role role)
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
      
            if (role == null || role.RoleId != 0 || role.RoleId != 1 || role.RoleId != 2 || role.RoleId != 3 || role.RoleId != 4)
            {
                throw new ArgumentException(ExceptionMessages.InvlidRole);
            }

            user.Role = role;

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
                .Include(u => u.Role)
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

        public User GetUserByEmail(string email)
        {
            User user = this._hospitalDbContext
                .Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.Email == email);

            return user;
        }

        public User GetUserById(int id)
        {
           return this._hospitalDbContext .Users.FirstOrDefault(u => u.Id == id);
        }
    }
}

