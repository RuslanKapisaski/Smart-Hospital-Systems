
namespace Hospital_System.UI
{
     partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            cutomDropDownMenu1 = new Hospital_System.UI.CustomControls.CutomDropDownMenu(components);
            appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cutomDropDownMenu2 = new Hospital_System.UI.CustomControls.CutomDropDownMenu(components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hospitalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            doctorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            requestVisitationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hospitalSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            watchLabel = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cutomDropDownMenu1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cutomDropDownMenu1
            // 
            cutomDropDownMenu1.ImageScalingSize = new System.Drawing.Size(18, 18);
            cutomDropDownMenu1.IsMainMenu = false;
            cutomDropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { appointmentsToolStripMenuItem });
            cutomDropDownMenu1.MenuItemHeight = 25;
            cutomDropDownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            cutomDropDownMenu1.Name = "cutomDropDownMenu1";
            cutomDropDownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            cutomDropDownMenu1.Size = new System.Drawing.Size(158, 26);
            // 
            // appointmentsToolStripMenuItem
            // 
            appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pricesToolStripMenuItem, doctorsToolStripMenuItem });
            appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            appointmentsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // pricesToolStripMenuItem
            // 
            pricesToolStripMenuItem.Name = "pricesToolStripMenuItem";
            pricesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            pricesToolStripMenuItem.Text = "Prices";
            // 
            // doctorsToolStripMenuItem
            // 
            doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            doctorsToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            doctorsToolStripMenuItem.Text = "Doctors";
            // 
            // cutomDropDownMenu2
            // 
            cutomDropDownMenu2.ImageScalingSize = new System.Drawing.Size(18, 18);
            cutomDropDownMenu2.IsMainMenu = false;
            cutomDropDownMenu2.MenuItemHeight = 25;
            cutomDropDownMenu2.MenuItemTextColor = System.Drawing.Color.DimGray;
            cutomDropDownMenu2.Name = "cutomDropDownMenu2";
            cutomDropDownMenu2.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            cutomDropDownMenu2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(96, 26);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.White;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem1, hospitalsToolStripMenuItem, doctorsToolStripMenuItem1, hospitalSystemsToolStripMenuItem, statusToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(923, 25);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new System.Drawing.Size(39, 21);
            fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // hospitalsToolStripMenuItem
            // 
            hospitalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { viewToolStripMenuItem });
            hospitalsToolStripMenuItem.Name = "hospitalsToolStripMenuItem";
            hospitalsToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            hospitalsToolStripMenuItem.Text = "Hospitals";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // doctorsToolStripMenuItem1
            // 
            doctorsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { viewToolStripMenuItem1, requestVisitationToolStripMenuItem });
            doctorsToolStripMenuItem1.Name = "doctorsToolStripMenuItem1";
            doctorsToolStripMenuItem1.Size = new System.Drawing.Size(66, 21);
            doctorsToolStripMenuItem1.Text = "Doctors";
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            viewToolStripMenuItem1.Text = "View";
            // 
            // requestVisitationToolStripMenuItem
            // 
            requestVisitationToolStripMenuItem.Name = "requestVisitationToolStripMenuItem";
            requestVisitationToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            requestVisitationToolStripMenuItem.Text = "Request Visitation";
            // 
            // hospitalSystemsToolStripMenuItem
            // 
            hospitalSystemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            hospitalSystemsToolStripMenuItem.Name = "hospitalSystemsToolStripMenuItem";
            hospitalSystemsToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            hospitalSystemsToolStripMenuItem.Text = "Hospital Systems";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { personalInfoToolStripMenuItem });
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            statusToolStripMenuItem.Text = "Status";
            // 
            // personalInfoToolStripMenuItem
            // 
            personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            personalInfoToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            personalInfoToolStripMenuItem.Text = "Personal Info";
            // 
            // watchLabel
            // 
            watchLabel.AutoSize = true;
            watchLabel.Dock = System.Windows.Forms.DockStyle.Right;
            watchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            watchLabel.Location = new System.Drawing.Point(923, 25);
            watchLabel.Name = "watchLabel";
            watchLabel.Size = new System.Drawing.Size(0, 17);
            watchLabel.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(923, 979);
            Controls.Add(watchLabel);
            Controls.Add(menuStrip1);
            ForeColor = System.Drawing.Color.Coral;
            HelpButton = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "mainForm";
            Text = "Results";
            Load += mainForm_Load;
            cutomDropDownMenu1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public Npgsql.NpgsqlCommand npgsqlCommand1;
        public CustomControls.CutomDropDownMenu cutomDropDownMenu1;
        public System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pricesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        public CustomControls.CutomDropDownMenu cutomDropDownMenu2;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem hospitalsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem1;
        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem hospitalSystemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem requestVisitationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
    }
}