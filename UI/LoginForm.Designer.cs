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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            loginTitle = new Label();
            emailLabel = new Label();
            emailInput = new MaskedTextBox();
            passInput = new MaskedTextBox();
            passLabel = new Label();
            imageList1 = new ImageList(components);
            LoginButton = new Button();
            linkRegisterForm = new LinkLabel();
            accountLabel = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loginTitle
            // 
            loginTitle.AutoSize = true;
            loginTitle.BackColor = System.Drawing.Color.Transparent;
            loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            loginTitle.ForeColor = System.Drawing.Color.LightSteelBlue;
            loginTitle.Location = new System.Drawing.Point(290, 125);
            loginTitle.Name = "loginTitle";
            loginTitle.Size = new System.Drawing.Size(241, 31);
            loginTitle.TabIndex = 3;
            loginTitle.Text = "Hospital Systems";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Location = new System.Drawing.Point(207, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(42, 17);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // emailInput
            // 
            emailInput.Location = new System.Drawing.Point(277, 189);
            emailInput.Name = "emailInput";
            emailInput.Size = new System.Drawing.Size(295, 25);
            emailInput.TabIndex = 7;
            // 
            // passInput
            // 
            passInput.Location = new System.Drawing.Point(277, 239);
            passInput.Name = "passInput";
            passInput.Size = new System.Drawing.Size(295, 25);
            passInput.TabIndex = 9;
            passInput.KeyPress += passInput_KeyPress;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = System.Drawing.Color.Transparent;
            passLabel.Location = new System.Drawing.Point(188, 239);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(67, 17);
            passLabel.TabIndex = 8;
            passLabel.Text = "Password:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LoginButton
            // 
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            LoginButton.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            LoginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            LoginButton.Location = new System.Drawing.Point(360, 300);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(105, 34);
            LoginButton.TabIndex = 24;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // linkRegisterForm
            // 
            linkRegisterForm.AutoSize = true;
            linkRegisterForm.BackColor = System.Drawing.Color.Transparent;
            linkRegisterForm.LinkColor = System.Drawing.Color.LightCoral;
            linkRegisterForm.Location = new System.Drawing.Point(690, 409);
            linkRegisterForm.Name = "linkRegisterForm";
            linkRegisterForm.Size = new System.Drawing.Size(92, 17);
            linkRegisterForm.TabIndex = 25;
            linkRegisterForm.TabStop = true;
            linkRegisterForm.Text = "Register Here!";
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.BackColor = System.Drawing.Color.Transparent;
            accountLabel.Location = new System.Drawing.Point(532, 409);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new System.Drawing.Size(152, 17);
            accountLabel.TabIndex = 26;
            accountLabel.Text = "Do not have an account?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(accountLabel);
            Controls.Add(linkRegisterForm);
            Controls.Add(LoginButton);
            Controls.Add(passInput);
            Controls.Add(passLabel);
            Controls.Add(emailInput);
            Controls.Add(emailLabel);
            Controls.Add(loginTitle);
            ForeColor = System.Drawing.SystemColors.InactiveCaption;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.MaskedTextBox emailInput;
        private System.Windows.Forms.MaskedTextBox passInput;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.ImageList imageList1;
        private LinkLabel linkRegisterForm;
        private Label accountLabel;
        public Button LoginButton;
    }
}