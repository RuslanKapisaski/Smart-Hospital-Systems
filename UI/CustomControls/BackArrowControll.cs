using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_System.UI.CustomControls
{
    public partial class BackArrowControll : UserControl
    {
        private PictureBox backArrow;
        public event EventHandler BackClicked;

        public BackArrowControll()
        {
            InitializeControl();
        }

        private void InitializeControl()
        {
            backArrow = new PictureBox();
            backArrow.Size = new Size(24, 24);
            backArrow.Dock = DockStyle.Fill;
            backArrow.Location = new Point(2, 2);
            backArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            backArrow.Image = Image.FromFile(@"C:\Users\Textile\Documents\Hospital System Images\back-arrow.png");
            backArrow.Cursor = Cursors.Hand;

            backArrow.Click += (s, e) => BackClicked?.Invoke(this, EventArgs.Empty);

            this.Controls.Add(backArrow);
        }
    }
}
