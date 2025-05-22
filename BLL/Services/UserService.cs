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
    using System.Linq;

    public class UserService : IUserService
    {
        private static readonly string connectionString = @"Server=localhost;Username=postgres;Password=123r123k;Database=Hospital System;";
        private readonly HospitalDbContext dbContext;

        public UserService(HospitalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool RegisterUser(User user)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                var cmd = new NpgsqlCommand("INSERT INTO \"users\"  (first_name, last_name,email,password,role_id,birth_date,registration_date) values (@fName,@lName,@email,@pass,@role_id,@bdate,@regDate)");

                cmd.Parameters.AddWithValue("@fName", user.FirstName);
                cmd.Parameters.AddWithValue("@lName", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@pass", user.Password);
                cmd.Parameters.AddWithValue("@role_id", user.RoleId);
                cmd.Parameters.AddWithValue("@bdate", user.BirthDate);
                cmd.Parameters.AddWithValue("@regDate", user.RegistrationDate);

                int rows = cmd.ExecuteNonQuery();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool LoginUser(UserDTO user)
        {
            int userCount = 0;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE password = @password AND email = @email");
                cmd.Parameters.AddWithValue("password", user.Password);
                cmd.Parameters.AddWithValue("email", user.Email);

                userCount = Convert.ToInt32(cmd.ExecuteScalar()); //ExecuteScalar  -> returns an object
                if (userCount == 1)
                {
                    connection.Close();
                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InvalidLogin);
                }
            };

            return Convert.ToBoolean(userCount);
        }

        public bool AddRoleToUser(string userId, RoleDTO roleDto)
        {
            var user = this.dbContext.Users.Find(userId);

            if (user == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }

            var newRole = roleDto.Adapt<Role>();
            user.Role = newRole;

            bool isNewRoleCreated = this.dbContext.SaveChanges() == 1;

            return isNewRoleCreated;

        }

        public bool EditUser(string userID, RoleDTO roleDto)
        {
            User user = this.dbContext.Users.Find(userID);

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

            this.dbContext.Users.Add(user);

            bool isNewRoleEdited = this.dbContext.SaveChanges() == 1;

            return isNewRoleEdited;
        }

        public bool DeleteUser(string userId)
        {
            User user = this.dbContext.Users.Find(userId);

            if (user == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }

            this.dbContext.Users.Remove(user);
            bool isDeleted = this.dbContext.SaveChanges() == 1;

            return isDeleted;
        }

        public List<User> GetAllUsers()
        {
           List<User> users = this.dbContext.Users.ToList();
           
            return users;
        }

       
    
    }
}

    //void ConfigureMapster()
    //{ For fiing name differences
    //    TypeAdapterConfig<User, UserDTO>.NewConfig()
    //        .Map(dest => dest.)
    //}

