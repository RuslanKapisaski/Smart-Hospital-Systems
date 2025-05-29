using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using Mapster;
using System.Windows.Forms;

namespace Hospital_System.UI
{
    public partial class UserForm : Form
    {
        public UserForm(UserDTO userDTO)
        {
            var user = userDTO.Adapt<User>();

            InitializeComponent();
            userGreetingLabel.Text += user.FirstName;
            nameTextBox.Text += $"{user.FirstName} {user.LastName}";
            emailTextBox.Text += user.Email;
        }
    }
}
