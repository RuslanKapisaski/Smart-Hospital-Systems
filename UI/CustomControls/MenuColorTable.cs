﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_System.UI.CustomControls
{
    public class MenuColorTable : ProfessionalColorTable
    {

        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        public MenuColorTable(bool isMainMenu, Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = Color.FromArgb(37, 39, 60);
                leftColumnColor = Color.FromArgb(32, 32, 51);
                borderColor = Color.FromArgb(32, 32, 51);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;

            }
            else
            {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightSkyBlue;
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            { return backColor; }
        }

        public override Color MenuBorder
        {
            get { return borderColor; }
        }

        public override Color MenuItemBorder
        {
            get { return menuItemBorderColor; }
        }

        public override Color MenuItemSelected
        {
            get { return menuItemSelectedColor; }
        }

        public override Color ImageMarginGradientBegin
        {
            get { return leftColumnColor; }
        }

        public override Color ImageMarginGradientEnd
        {
            get {return base.ImageMarginGradientEnd; }
        }


    }
}


