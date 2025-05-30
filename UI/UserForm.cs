using Hospital_System.BLL.Services;
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using Hospital_System.DAL.Services;
using Mapster;
using System;
using System.Windows.Forms;

namespace Hospital_System.UI
{
    public partial class UserForm : Form
    {
     
        public UserForm()
        {
            InitializeComponent();
            PopulateData(GLOB.LogedUser);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void roleBtn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var popUpForm = new RolePopUpChoice();
            popUpForm.ShowDialog();
        }

        private void PopulateData(UserDTO userDTO)
        {
            var user = GetUser(userDTO.Email);
            userGreetingLabel.Text += user.FirstName;
            nameLbl.Text += $" {user.FirstName} {user.LastName}";
            emailLabel.Text += " " + user.Email;
            roleLabel.Text += " " + user.Role.RoleName;
            registrationDateLabel.Text += " " + user.RegistrationDate.ToString("dd MMM yyyy");

        }

        private User GetUser(string email)
        {
            try
            {

                using (var context = new HospitalDbContext())
                {
                    var service = new UserService(context);
                    var user = service.GetUserByEmail(email);
                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetUser: {ex.Message}");
                return null;
            }

        }

        //private string GetRoleName(int roleId)
        //{
        //    using (var context = new HospitalDbContext())
        //    {
        //        var service = new RoleService(context);
        //        var role = service.GetRoleByRoleId(roleId);
        //        return role.RoleName.ToString();
        //    }
        //}


    }
}
