using Hospital_System.BLL.Services;
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using Hospital_System.DAL.Services;
using Mapster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System.UI
{
    public partial class UserFormAdmin : Form
    {
        public UserFormAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            refreshGridUsers();
            refreshGridRoles();
            refreshGridRoleRequests();
        }

        void refreshGridUsers()
        {
            DataTable userstDT = new DataTable();
            userstDT.Columns.Add("First Name");
            userstDT.Columns.Add("Last Name");
            userstDT.Columns.Add("Email");
            userstDT.Columns.Add("RoleID");

            var users = GetUserDTOs();

            foreach (var user in users)
            {
                userstDT.Rows.Add(user.FirstName, user.LastName, user.Email, user.Role.roleId);
            }

            dataGridViewUsers.DataSource = userstDT;
        }

        List<UserDTO> GetUserDTOs()
        {
            using (var context = new HospitalDbContext())
            {
                var service = new UserService(context);

                var users = service.GetAllUsers();

                foreach (var user in users)
                {
                    var roleName = user.Role.RoleName;  // this works because Role is loaded and RoleName is a computed property
                }

                return users.Adapt<List<UserDTO>>();
            }
        }

        void refreshGridRoles()
        {
            DataTable rolesDT = new DataTable();
            rolesDT.Columns.Add("ID");
            rolesDT.Columns.Add("Name");

            var roles = GetAllRoles();

            foreach (Role role in roles)
            {
                rolesDT.Rows.Add(role.RoleId, role.RoleName);
            }

            dataGridViewRoles.DataSource = rolesDT;
        }

        private List<Role> GetAllRoles()
        {
            using (var context = new HospitalDbContext())
            {
                try
                {
                    var service = new RoleService(context);
                    return service.GetRoles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while getting all the roles." + ex, "Error message", MessageBoxButtons.OK);
                    return null;
                }
            }
        }

        void refreshGridRoleRequests()
        {
            DataTable roleRequestDT = new DataTable();
            roleRequestDT.Columns.Add("Role ID");
            roleRequestDT.Columns.Add("UserID");
            roleRequestDT.Columns.Add("User Name");
            roleRequestDT.Columns.Add("Approved");
            roleRequestDT.Columns.Add("Requested At");

            var requests = GetAllRoleRequests();
          
            foreach (var request in requests) {
                roleRequestDT.Rows.Add(request.Id, request.UserId, GetUserName(request.UserId), request.IsApproved, request.RequestedAt);
            }

            dataGridViewRoleRequests.DataSource = roleRequestDT;
        }

        private List<RoleRequest> GetAllRoleRequests()
        {
            using (var context = new HospitalDbContext())
            {
                var service = new RoleRequestService(context);

                return service.GetAllRoleRequests();
            }
        }

        private string GetUserName(int userId)
        {
            using (var context = new HospitalDbContext())
            {
                var service = new UserService(context);

                var user = service.GetUserById(userId);

                return user.FirstName + " " + user.LastName;
            }
        }
    }
}