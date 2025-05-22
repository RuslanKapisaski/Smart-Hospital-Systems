

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Controls.Primitives;

namespace Hospital_System.UI.CustomControls
{
    public class ToggleButton : CheckBox
    {


        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.DarkSlateBlue;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;

        public Color OnBackColor { get => onBackColor; set { onBackColor = value; this.Invalidate(); } }
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); } }
        public Color OffBackColor { get => offBackColor; set { offBackColor = value; this.Invalidate(); } }
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); } }

        public ToggleButton()
        {
            this.MinimumSize = new Size(50, 25);

        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            //Широчина на арката
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(leftArc, 90, 180);
            graphicsPath.AddArc(rightArc, 270, 180);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            //On
            if (this.Checked)
            {
                //Drawing the controll surface
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());

                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));

            }
            else
            {

                //Drawing the controll surface
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());

                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));

            }
        }

        public override string Text { get => base.Text; set { } }


        public void ApplyTheme(bool isDark)
        {
            this.BackColor = isDark ? Color.DimGray : Color.WhiteSmoke;

            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = isDark ? Color.WhiteSmoke : Color.DimGray;
                    control.BackColor = isDark ? Color.WhiteSmoke : Color.Black;
                }
                else if (control is Panel) {
                    control.BackColor = isDark ? Color.DarkGray : Color.WhiteSmoke;
                }
                
            }
        }


    }
}
