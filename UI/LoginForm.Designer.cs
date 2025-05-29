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
            loginTitle.Anchor = AnchorStyles.None;
            loginTitle.AutoSize = true;
            loginTitle.BackColor = System.Drawing.Color.Transparent;
            loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.2264137F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            loginTitle.ForeColor = System.Drawing.Color.LightBlue;
            loginTitle.Location = new System.Drawing.Point(119, 32);
            loginTitle.Margin = new Padding(3, 0, 3, 300);
            loginTitle.Name = "loginTitle";
            loginTitle.Size = new System.Drawing.Size(599, 81);
            loginTitle.TabIndex = 3;
            loginTitle.Text = "Hospital Systems";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 14.2641506F);
            emailLabel.Location = new System.Drawing.Point(175, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(68, 30);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // emailInput
            // 
            emailInput.Anchor = AnchorStyles.None;
            emailInput.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            emailInput.Location = new System.Drawing.Point(278, 189);
            emailInput.Name = "emailInput";
            emailInput.Size = new System.Drawing.Size(308, 31);
            emailInput.TabIndex = 7;
            // 
            // passInput
            // 
            passInput.Anchor = AnchorStyles.None;
            passInput.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            passInput.Location = new System.Drawing.Point(278, 239);
            passInput.Name = "passInput";
            passInput.Size = new System.Drawing.Size(308, 31);
            passInput.TabIndex = 9;
            passInput.KeyPress += passInput_KeyPress;
            // 
            // passLabel
            // 
            passLabel.Anchor = AnchorStyles.None;
            passLabel.AutoSize = true;
            passLabel.BackColor = System.Drawing.Color.Transparent;
            passLabel.Font = new System.Drawing.Font("Segoe UI", 14.2641506F);
            passLabel.Location = new System.Drawing.Point(156, 234);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(104, 30);
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
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            LoginButton.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            LoginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            LoginButton.Location = new System.Drawing.Point(360, 300);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(148, 46);
            LoginButton.TabIndex = 24;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // linkRegisterForm
            // 
            linkRegisterForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkRegisterForm.AutoSize = true;
            linkRegisterForm.BackColor = System.Drawing.Color.Transparent;
            linkRegisterForm.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            linkRegisterForm.LinkColor = System.Drawing.Color.LightCoral;
            linkRegisterForm.Location = new System.Drawing.Point(657, 403);
            linkRegisterForm.Name = "linkRegisterForm";
            linkRegisterForm.Size = new System.Drawing.Size(122, 25);
            linkRegisterForm.TabIndex = 25;
            linkRegisterForm.TabStop = true;
            linkRegisterForm.Text = "Register Here!";
            linkRegisterForm.LinkClicked += linkRegisterForm_LinkClicked_1;
            // 
            // accountLabel
            // 
            accountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            accountLabel.AutoSize = true;
            accountLabel.BackColor = System.Drawing.Color.Transparent;
            accountLabel.Font = new System.Drawing.Font("Segoe UI", 12.2264156F);
            accountLabel.Location = new System.Drawing.Point(452, 403);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new System.Drawing.Size(209, 25);
            accountLabel.TabIndex = 26;
            accountLabel.Text = "Do not have an account?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
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
        public Button LoginButton;
        public ContextMenuStrip contextMenuStrip1;
        public Label loginTitle;
        public Label emailLabel;
        public MaskedTextBox emailInput;
        public MaskedTextBox passInput;
        public Label passLabel;
        public ImageList imageList1;
        public LinkLabel linkRegisterForm;
        public Label accountLabel;
    }
}