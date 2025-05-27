
namespace Hospital_System.UI
{
    partial class ManagmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagmentForm));
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.flowLayoutPanelAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDeveloper = new System.Windows.Forms.FlowLayoutPanel();
            this.darkThemeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toggleButton1 = new Hospital_System.UI.CustomControls.ToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // flowLayoutPanelAdmin
            // 
            this.flowLayoutPanelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAdmin.Location = new System.Drawing.Point(128, 74);
            this.flowLayoutPanelAdmin.Name = "flowLayoutPanelAdmin";
            this.flowLayoutPanelAdmin.Size = new System.Drawing.Size(486, 462);
            this.flowLayoutPanelAdmin.TabIndex = 3;
            // 
            // flowLayoutPanelDeveloper
            // 
            this.flowLayoutPanelDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDeveloper.Location = new System.Drawing.Point(613, 74);
            this.flowLayoutPanelDeveloper.Name = "flowLayoutPanelDeveloper";
            this.flowLayoutPanelDeveloper.Size = new System.Drawing.Size(618, 462);
            this.flowLayoutPanelDeveloper.TabIndex = 4;
            // 
            // darkThemeLabel
            // 
            this.darkThemeLabel.AutoSize = true;
            this.darkThemeLabel.Location = new System.Drawing.Point(1117, 10);
            this.darkThemeLabel.Name = "darkThemeLabel";
            this.darkThemeLabel.Size = new System.Drawing.Size(75, 15);
            this.darkThemeLabel.TabIndex = 1;
            this.darkThemeLabel.Text = "Dark Theme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.darkThemeLabel);
            this.panel1.Controls.Add(this.toggleButton1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 77);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(126, 462);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(1127, 29);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(50, 25);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Salmon;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Firebrick;
            this.toggleButton1.OnBackColor = System.Drawing.Color.LimeGreen;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.Green;
            this.toggleButton1.Size = new System.Drawing.Size(50, 25);
            this.toggleButton1.TabIndex = 0;
            this.toggleButton1.UseVisualStyleBackColor = true;            // 
            // ManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 605);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanelDeveloper);
            this.Controls.Add(this.flowLayoutPanelAdmin);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.Name = "ManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Npgsql.NpgsqlCommand npgsqlCommand1;
        public CustomControls.ToggleButton toggleButton1;
        public System.Windows.Forms.Label darkThemeLabel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAdmin;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDeveloper;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}