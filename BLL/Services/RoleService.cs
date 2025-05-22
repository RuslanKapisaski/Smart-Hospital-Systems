using Hospital_System.BLL.Interfaces;
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using Hospital_System.Utils;
using Mapster;
using System;
using System.Windows.Forms;

namespace Hospital_System.BLL.Services
{
    public class RoleService : IRoleService
    {
        private readonly HospitalDbContext DBContext;

        public RoleService(HospitalDbContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public void AddRole(RoleDTO roleDto)
        {
           // Role role = this.mapper.Map
            var newRole = roleDto.Adapt<Role>();
            this.DBContext.Roles.Add(newRole);
            this.DBContext.SaveChanges();
        }

        public bool RemoveRoleByUserId(string userId)
        {
            var user = DBContext.Users.Find(userId);

            if (user==null)
            {
                throw new ArgumentException (ExceptionMessages.UserNotFound);
            }

            this.DBContext.Users.Remove(user);
            bool isDeleted = DBContext.SaveChanges() == 1;
            return isDeleted;
        }
    }
}
