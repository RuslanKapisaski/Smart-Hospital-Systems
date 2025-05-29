
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
            roleBtn = new System.Windows.Forms.Button();
            emailTextBox = new System.Windows.Forms.TextBox();
            nameTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            Email = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            statsBox.SuspendLayout();
            SuspendLayout();
            // 
            // userGreetingLabel
            // 
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
            statsBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("statsBox.BackgroundImage");
            statsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            statsBox.Controls.Add(roleBtn);
            statsBox.Controls.Add(emailTextBox);
            statsBox.Controls.Add(nameTextBox);
            statsBox.Controls.Add(nameLabel);
            statsBox.Controls.Add(Email);
            statsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold);
            statsBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            statsBox.Location = new System.Drawing.Point(94, 117);
            statsBox.Name = "statsBox";
            statsBox.Size = new System.Drawing.Size(364, 361);
            statsBox.TabIndex = 1;
            statsBox.TabStop = false;
            statsBox.Text = "My info";
            // 
            // roleBtn
            // 
            roleBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            roleBtn.Font = new System.Drawing.Font("Segoe UI", 12.2264156F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            roleBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            roleBtn.Location = new System.Drawing.Point(49, 245);
            roleBtn.Name = "roleBtn";
            roleBtn.Size = new System.Drawing.Size(260, 42);
            roleBtn.TabIndex = 4;
            roleBtn.Text = "Request Role Upgrade";
            roleBtn.UseVisualStyleBackColor = false;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new System.Drawing.Point(91, 176);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(160, 31);
            emailTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(91, 108);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(160, 31);
            nameTextBox.TabIndex = 2;
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
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = System.Drawing.Color.Transparent;
            statusLabel.Font = new System.Drawing.Font("Segoe UI", 14.2641506F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            statusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            statusLabel.Location = new System.Drawing.Point(110, 512);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(74, 30);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.BackColor = System.Drawing.Color.Transparent;
            roleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2264156F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            roleLabel.ForeColor = System.Drawing.SystemColors.Control;
            roleLabel.Location = new System.Drawing.Point(111, 557);
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
            // UserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(977, 626);
            Controls.Add(roleLabel);
            Controls.Add(statusLabel);
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
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label Email;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label roleLabel;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}