using Hospital_System.BLL.Services;
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using Hospital_System.Utils;
using Mapster;
using Microsoft.EntityFrameworkCore;
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
    public partial class RolePopUpChoice : Form
    {
        public RolePopUpChoice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RequestDoctorRole(UserDTO userDTO)
        {
            try
            {
                using (var context = new HospitalDbContext())
                {
                    var service = new RoleRequestService(context);
                    var user = context
                    .Users
                    .Include(u => u.Role)
                    .FirstOrDefault(u => u.Email == userDTO.Email);
                    var roleRequest = new RoleRequest
                    {
                        UserId = user.Id,
                        RequestedAt = DateTime.Now,
                        IsApproved = false,
                        RequestedRoleId = 3
                    };
                    service.AddRoleRequest(roleRequest);
                    MessageBox.Show("Successfuly requested patient role. Please, wait administrator's approval.", "Request message", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch (Exception ex) { throw new ArgumentException(ExceptionMessages.RoleRequestError); }
        }

        private void RequestPatientRole(UserDTO userDTO)
        {
            using (var context = new HospitalDbContext())
            {
                var service = new RoleRequestService(context);
                var user = context
                    .Users
                    .Include(u=> u.Role)
                    .FirstOrDefault(u => u.Email == userDTO.Email);

                var roleRequest = new RoleRequest
                {
                    UserId = user.Id,
                    RequestedAt = DateTime.Now,
                    IsApproved = false,
                    RequestedRoleId = 2,
                };
                service.AddRoleRequest(roleRequest);
                MessageBox.Show("Successfuly requested patient role. Please, wait administrator's approval.", "Request message", MessageBoxButtons.OK);
                this.Close();
            }
        }


        private void radioBtnPatient_Click(object sender, EventArgs e)
        {
            RequestPatientRole(GLOB.LogedUser);
        }

        private void radioBtnDoctor_Click(object sender, EventArgs e)
        {
            RequestDoctorRole(GLOB.LogedUser);
        }
    }
}
