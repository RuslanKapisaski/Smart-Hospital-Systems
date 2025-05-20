namespace Hospital_System
{

    using System.Windows.Forms;

    partial class LoginForm : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginTitle = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.MaskedTextBox();
            this.passInput = new System.Windows.Forms.MaskedTextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.linkRegisterForm = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginTitle.Location = new System.Drawing.Point(290, 114);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(241, 31);
            this.loginTitle.TabIndex = 3;
            this.loginTitle.Text = "Hospital Systems";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(207, 189);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 15);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(277, 189);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(295, 20);
            this.emailInput.TabIndex = 7;

            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(277, 239);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(295, 20);
            this.passInput.TabIndex = 9;

            this.passInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passInput_KeyPress);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(188, 239);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(64, 15);
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "Password:";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(448, 385);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(142, 15);
            this.accountLabel.TabIndex = 10;
            this.accountLabel.Text = "Do not have an account?";
            // 
            // linkRegisterForm
            // 
            this.linkRegisterForm.AutoSize = true;
            this.linkRegisterForm.Location = new System.Drawing.Point(596, 385);
            this.linkRegisterForm.Name = "linkRegisterForm";
            this.linkRegisterForm.Size = new System.Drawing.Size(83, 15);
            this.linkRegisterForm.TabIndex = 11;
            this.linkRegisterForm.TabStop = true;
            this.linkRegisterForm.Text = "Register Here";
            this.linkRegisterForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(690, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(110, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LoginButton.Location = new System.Drawing.Point(360, 300);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(105, 23);
            this.LoginButton.TabIndex = 24;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.linkRegisterForm);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginTitle);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Name = "LoginForm";
            this.Text = "LoginForm";

            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.MaskedTextBox emailInput;
        private System.Windows.Forms.MaskedTextBox passInput;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.LinkLabel linkRegisterForm;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button LoginButton;
    }
}