
namespace Hospital_System.UI
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            userGreetingLabel = new System.Windows.Forms.Label();
            statsBox = new System.Windows.Forms.GroupBox();
            emailLabel = new System.Windows.Forms.Label();
            nameLbl = new System.Windows.Forms.Label();
            roleBtn = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            Email = new System.Windows.Forms.Label();
            registrationDateLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            regDateLabel = new System.Windows.Forms.Label();
            statsBox.SuspendLayout();
            SuspendLayout();
            // 
            // userGreetingLabel
            // 
            userGreetingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            userGreetingLabel.AutoSize = true;
            userGreetingLabel.BackColor = System.Drawing.Color.Transparent;
            userGreetingLabel.Font = new System.Drawing.Font("Segoe UI", 16.3018875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            userGreetingLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            userGreetingLabel.Location = new System.Drawing.Point(12, 9);
            userGreetingLabel.Name = "userGreetingLabel";
            userGreetingLabel.Size = new System.Drawing.Size(138, 35);
            userGreetingLabel.TabIndex = 0;
            userGreetingLabel.Text = "Welcome, ";
            // 
            // statsBox
            // 
            statsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            statsBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("statsBox.BackgroundImage");
            statsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            statsBox.Controls.Add(emailLabel);
            statsBox.Controls.Add(nameLbl);
            statsBox.Controls.Add(roleBtn);
            statsBox.Controls.Add(nameLabel);
            statsBox.Controls.Add(Email);
            statsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold);
            statsBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            statsBox.Location = new System.Drawing.Point(38, 90);
            statsBox.Name = "statsBox";
            statsBox.Size = new System.Drawing.Size(433, 388);
            statsBox.TabIndex = 1;
            statsBox.TabStop = false;
            statsBox.Text = "My info";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold);
            emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            emailLabel.Location = new System.Drawing.Point(106, 176);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(0, 25);
            emailLabel.TabIndex = 6;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.BackColor = System.Drawing.Color.Transparent;
            nameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold);
            nameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nameLbl.Location = new System.Drawing.Point(106, 111);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new System.Drawing.Size(0, 25);
            nameLbl.TabIndex = 5;
            // 
            // roleBtn
            // 
            roleBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            roleBtn.Font = new System.Drawing.Font("Segoe UI", 12.2264156F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            roleBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            roleBtn.Location = new System.Drawing.Point(73, 248);
            roleBtn.Name = "roleBtn";
            roleBtn.Size = new System.Drawing.Size(260, 42);
            roleBtn.TabIndex = 4;
            roleBtn.Text = "Request Role Upgrade";
            roleBtn.UseVisualStyleBackColor = false;
            roleBtn.Click += roleBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold);
            nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nameLabel.Location = new System.Drawing.Point(5, 111);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = System.Drawing.Color.Transparent;
            Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold);
            Email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            Email.Location = new System.Drawing.Point(6, 176);
            Email.Name = "Email";
            Email.Size = new System.Drawing.Size(60, 25);
            Email.TabIndex = 0;
            Email.Text = "Email:";
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.BackColor = System.Drawing.Color.Transparent;
            registrationDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.2641506F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            registrationDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            registrationDateLabel.Location = new System.Drawing.Point(67, 568);
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new System.Drawing.Size(178, 30);
            registrationDateLabel.TabIndex = 5;
            registrationDateLabel.Text = "Registration Date:";
            // 
            // roleLabel
            // 
            roleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            roleLabel.AutoSize = true;
            roleLabel.BackColor = System.Drawing.Color.Transparent;
            roleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            roleLabel.ForeColor = System.Drawing.SystemColors.Control;
            roleLabel.Location = new System.Drawing.Point(67, 534);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(53, 25);
            roleLabel.TabIndex = 6;
            roleLabel.Text = "Role:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // regDateLabel
            // 
            regDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            regDateLabel.AutoSize = true;
            regDateLabel.BackColor = System.Drawing.Color.Transparent;
            regDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold);
            regDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            regDateLabel.Location = new System.Drawing.Point(283, 573);
            regDateLabel.Name = "regDateLabel";
            regDateLabel.Size = new System.Drawing.Size(0, 25);
            regDateLabel.TabIndex = 8;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(977, 626);
            Controls.Add(regDateLabel);
            Controls.Add(roleLabel);
            Controls.Add(registrationDateLabel);
            Controls.Add(statsBox);
            Controls.Add(userGreetingLabel);
            ImeMode = System.Windows.Forms.ImeMode.On;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "UserForm";
            Text = "UserForm";
            statsBox.ResumeLayout(false);
            statsBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label userGreetingLabel;
        public System.Windows.Forms.GroupBox statsBox;
        public System.Windows.Forms.Button roleBtn;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label Email;
        public System.Windows.Forms.Label registrationDateLabel;
        public System.Windows.Forms.Label roleLabel;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Label nameLbl;
        public System.Windows.Forms.Label regDateLabel;
    }
}