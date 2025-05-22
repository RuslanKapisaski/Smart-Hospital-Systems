////Панел за потребители
namespace Hospital_System.UI.UIManagers
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class SettingsManagerPt
    {
        private Size ButtonSize = new Size(200, 200);

        private void ShowFormResults()
        {

            using (var form = new MainForm())
            {
                form.Text = "Results";
                form.ShowDialog();
            }
        }


        //private Control CreateTile(string buttonText, Color backColor, Action onClick)
        //{
        //    var button = new Button();
        //    button.Text = buttonText;
        //    button.Size = ButtonSize;
        //    button.ForeColor = Color.White;
        //    button.BackColor = backColor;
        //    button.Click += (s, e) => onClick?.Invoke();

        //    return button;
        //}

    }
}
