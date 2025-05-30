namespace Hospital_System.BLL.Services
{
    using Hospital_System.BLL.Interfaces;
    using Hospital_System.DAL.DB;
    using Hospital_System.DAL.Models;
    using Hospital_System.Utils;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoleService : IRoleService
    {
        private readonly HospitalDbContext DBContext;

        public RoleService(HospitalDbContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public void AddRole(Role role)
        {
            try
            {
                this.DBContext.Roles.Add(role);
                this.DBContext.SaveChanges();
            }
            catch (Exception ex) { throw new ArgumentException(ExceptionMessages.RoleNotFound); }
            
        }

        public bool RemoveRoleByUserId(string userId)
        {
            var user = DBContext.Users.Find(userId);

            if (user == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }

            this.DBContext.Roles.Remove(user.Role);
            bool isDeleted = DBContext.SaveChanges() == 1;
            return isDeleted;
        }
        //public string GetRoleNameByRoleId() { }

        public List<Role> GetRoles()
        {
            return this.DBContext.Roles.ToList();
        }
    }
}
