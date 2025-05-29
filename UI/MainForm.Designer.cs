
namespace Hospital_System.UI
{
     partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            viewToolStripMenuDoctors = new System.Windows.Forms.ToolStripMenuItem();
            hospitalSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            watchLabel = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            greetLabel = new System.Windows.Forms.Label();
            flowLayoutPanelMainForm = new System.Windows.Forms.FlowLayoutPanel();
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
            menuStrip1.Size = new System.Drawing.Size(923, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new System.Drawing.Size(50, 29);
            fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // hospitalsToolStripMenuItem
            // 
            hospitalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { viewToolStripMenuItem });
            hospitalsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            hospitalsToolStripMenuItem.Name = "hospitalsToolStripMenuItem";
            hospitalsToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            hospitalsToolStripMenuItem.Text = "Hospitals";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(127, 30);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // doctorsToolStripMenuItem1
            // 
            doctorsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { viewToolStripMenuDoctors });
            doctorsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            doctorsToolStripMenuItem1.Name = "doctorsToolStripMenuItem1";
            doctorsToolStripMenuItem1.Size = new System.Drawing.Size(87, 29);
            doctorsToolStripMenuItem1.Text = "Doctors";
            // 
            // viewToolStripMenuDoctors
            // 
            viewToolStripMenuDoctors.Name = "viewToolStripMenuDoctors";
            viewToolStripMenuDoctors.Size = new System.Drawing.Size(127, 30);
            viewToolStripMenuDoctors.Text = "View";
            // 
            // hospitalSystemsToolStripMenuItem
            // 
            hospitalSystemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            hospitalSystemsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            hospitalSystemsToolStripMenuItem.Name = "hospitalSystemsToolStripMenuItem";
            hospitalSystemsToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            hospitalSystemsToolStripMenuItem.Text = "Hospital Systems";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { personalInfoToolStripMenuItem });
            statusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            statusToolStripMenuItem.Text = "Status";
            // 
            // personalInfoToolStripMenuItem
            // 
            personalInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            personalInfoToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            personalInfoToolStripMenuItem.Text = "Personal Info";
            personalInfoToolStripMenuItem.Click += personalInfoToolStripMenuItem_Click;
            // 
            // watchLabel
            // 
            watchLabel.AutoSize = true;
            watchLabel.Dock = System.Windows.Forms.DockStyle.Right;
            watchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            watchLabel.Location = new System.Drawing.Point(923, 33);
            watchLabel.Name = "watchLabel";
            watchLabel.Size = new System.Drawing.Size(0, 17);
            watchLabel.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // greetLabel
            // 
            greetLabel.AutoSize = true;
            greetLabel.BackColor = System.Drawing.Color.Transparent;
            greetLabel.Dock = System.Windows.Forms.DockStyle.Right;
            greetLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            greetLabel.ForeColor = System.Drawing.Color.AliceBlue;
            greetLabel.Location = new System.Drawing.Point(870, 33);
            greetLabel.Name = "greetLabel";
            greetLabel.Size = new System.Drawing.Size(53, 20);
            greetLabel.TabIndex = 5;
            greetLabel.Text = "Hello, ";
            // 
            // flowLayoutPanelMainForm
            // 
            flowLayoutPanelMainForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowLayoutPanelMainForm.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanelMainForm.Location = new System.Drawing.Point(40, 190);
            flowLayoutPanelMainForm.Name = "flowLayoutPanelMainForm";
            flowLayoutPanelMainForm.Size = new System.Drawing.Size(803, 503);
            flowLayoutPanelMainForm.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(923, 979);
            Controls.Add(flowLayoutPanelMainForm);
            Controls.Add(greetLabel);
            Controls.Add(watchLabel);
            Controls.Add(menuStrip1);
            ForeColor = System.Drawing.Color.Coral;
            HelpButton = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MainForm";
            Text = "Results";
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
        public System.Windows.Forms.Label greetLabel;
        public System.Windows.Forms.Label watchLabel;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripMenuItem hospitalSystemsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem viewToolStripMenuDoctors;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMainForm;
    }
}