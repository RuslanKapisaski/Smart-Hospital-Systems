
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
            userGreetingLabel.Font = new System.Drawing.Font("Segoe UI", 12.2264156F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            userGreetingLabel.Location = new System.Drawing.Point(12, 9);
            userGreetingLabel.Name = "userGreetingLabel";
            userGreetingLabel.Size = new System.Drawing.Size(94, 25);
            userGreetingLabel.TabIndex = 0;
            userGreetingLabel.Text = "Welcome: ";
            // 
            // statsBox
            // 
            statsBox.Controls.Add(roleBtn);
            statsBox.Controls.Add(emailTextBox);
            statsBox.Controls.Add(nameTextBox);
            statsBox.Controls.Add(nameLabel);
            statsBox.Controls.Add(Email);
            statsBox.Font = new System.Drawing.Font("Segoe UI", 12.2264156F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            statsBox.Location = new System.Drawing.Point(94, 117);
            statsBox.Name = "statsBox";
            statsBox.Size = new System.Drawing.Size(364, 361);
            statsBox.TabIndex = 1;
            statsBox.TabStop = false;
            statsBox.Text = "My info";
            // 
            // roleBtn
            // 
            roleBtn.Location = new System.Drawing.Point(20, 245);
            roleBtn.Name = "roleBtn";
            roleBtn.Size = new System.Drawing.Size(260, 42);
            roleBtn.TabIndex = 4;
            roleBtn.Text = "Request Role Upgrade";
            roleBtn.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new System.Drawing.Point(68, 173);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(160, 31);
            emailTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(68, 111);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(160, 31);
            nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(5, 111);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(63, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new System.Drawing.Point(6, 176);
            Email.Name = "Email";
            Email.Size = new System.Drawing.Size(58, 25);
            Email.TabIndex = 0;
            Email.Text = "Email:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Segoe UI", 10.18868F);
            statusLabel.Location = new System.Drawing.Point(110, 512);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 20);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.18868F);
            roleLabel.Location = new System.Drawing.Point(110, 541);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(42, 20);
            roleLabel.TabIndex = 6;
            roleLabel.Text = "Role:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(193, 28);
            // 
            // UserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

        private System.Windows.Forms.Label userGreetingLabel;
        private System.Windows.Forms.GroupBox statsBox;
        private System.Windows.Forms.Button roleBtn;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}