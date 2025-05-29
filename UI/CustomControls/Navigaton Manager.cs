using Hospital_System.DAL.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System.UI.CustomControls
{
    public static class Navigaton_Manager
    {
        private static Stack<Form> History = new Stack<Form>();
        private static UserDTO CurrentUser { get; set; }


        public static void NavigateTo(Form newForm, Form currentForm)
        {
            History.Push(currentForm);
            newForm.ShowDialog();
            currentForm.Hide();
        }

        public static void GoBackTo()
        {
            if (History.Count > 0)
            {
                Form previousForm = History.Pop();
                previousForm.ShowDialog();
            }
        }
    }
}
