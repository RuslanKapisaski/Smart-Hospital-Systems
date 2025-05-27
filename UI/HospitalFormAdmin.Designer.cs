namespace Hospital_System.DAL.Models.DTOs
{
    partial class HospitalFormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            hospitalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            hospitalDescriptionTextBox = new System.Windows.Forms.TextBox();
            emailTextBox = new System.Windows.Forms.TextBox();
            phoneTextBox = new System.Windows.Forms.TextBox();
            addressTextBox = new System.Windows.Forms.TextBox();
            nameTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            Phone = new System.Windows.Forms.Label();
            Address = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            deleteButton = new System.Windows.Forms.Button();
            addButton = new System.Windows.Forms.Button();
            hospitalsGroupBox = new System.Windows.Forms.GroupBox();
            hospitalsGridView1 = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new System.Windows.Forms.Label();
            hospitalDetailsGroupBox.SuspendLayout();
            hospitalsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hospitalsGridView1).BeginInit();
            SuspendLayout();
            // 
            // hospitalDetailsGroupBox
            // 
            hospitalDetailsGroupBox.Controls.Add(hospitalDescriptionTextBox);
            hospitalDetailsGroupBox.Controls.Add(emailTextBox);
            hospitalDetailsGroupBox.Controls.Add(phoneTextBox);
            hospitalDetailsGroupBox.Controls.Add(addressTextBox);
            hospitalDetailsGroupBox.Controls.Add(nameTextBox);
            hospitalDetailsGroupBox.Controls.Add(descriptionLabel);
            hospitalDetailsGroupBox.Controls.Add(emailLabel);
            hospitalDetailsGroupBox.Controls.Add(Phone);
            hospitalDetailsGroupBox.Controls.Add(Address);
            hospitalDetailsGroupBox.Controls.Add(nameLabel);
            hospitalDetailsGroupBox.Controls.Add(deleteButton);
            hospitalDetailsGroupBox.Controls.Add(addButton);
            hospitalDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            hospitalDetailsGroupBox.Location = new System.Drawing.Point(109, 87);
            hospitalDetailsGroupBox.Name = "hospitalDetailsGroupBox";
            hospitalDetailsGroupBox.Size = new System.Drawing.Size(576, 277);
            hospitalDetailsGroupBox.TabIndex = 0;
            hospitalDetailsGroupBox.TabStop = false;
            hospitalDetailsGroupBox.Text = "Hospitals";
            // 
            // hospitalDescriptionTextBox
            // 
            hospitalDescriptionTextBox.Location = new System.Drawing.Point(112, 218);
            hospitalDescriptionTextBox.Name = "hospitalDescriptionTextBox";
            hospitalDescriptionTextBox.Size = new System.Drawing.Size(279, 27);
            hospitalDescriptionTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new System.Drawing.Point(112, 177);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(279, 27);
            emailTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new System.Drawing.Point(112, 139);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new System.Drawing.Size(279, 27);
            phoneTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new System.Drawing.Point(112, 97);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new System.Drawing.Size(279, 27);
            addressTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(112, 51);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(279, 27);
            nameTextBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(18, 218);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(88, 20);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(21, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new System.Drawing.Point(21, 146);
            Phone.Name = "Phone";
            Phone.Size = new System.Drawing.Size(53, 20);
            Phone.TabIndex = 4;
            Phone.Text = "Phone:";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new System.Drawing.Point(26, 100);
            Address.Name = "Address";
            Address.Size = new System.Drawing.Size(65, 20);
            Address.TabIndex = 3;
            Address.Text = "Address:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(26, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = System.Drawing.Color.Firebrick;
            deleteButton.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            deleteButton.Location = new System.Drawing.Point(432, 162);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(119, 51);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.BackColor = System.Drawing.Color.ForestGreen;
            addButton.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            addButton.Location = new System.Drawing.Point(432, 77);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(119, 51);
            addButton.TabIndex = 0;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            // 
            // hospitalsGroupBox
            // 
            hospitalsGroupBox.Controls.Add(hospitalsGridView1);
            hospitalsGroupBox.Location = new System.Drawing.Point(69, 370);
            hospitalsGroupBox.Name = "hospitalsGroupBox";
            hospitalsGroupBox.Size = new System.Drawing.Size(711, 192);
            hospitalsGroupBox.TabIndex = 1;
            hospitalsGroupBox.TabStop = false;
            hospitalsGroupBox.Text = "Hospitals";
            // 
            // hospitalsGridView1
            // 
            hospitalsGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hospitalsGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, hospitalName, hospitalAddress, hospitalPhone, hospitalEmail, hospitalDescription });
            hospitalsGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            hospitalsGridView1.Location = new System.Drawing.Point(3, 21);
            hospitalsGridView1.Name = "hospitalsGridView1";
            hospitalsGridView1.RowHeadersWidth = 45;
            hospitalsGridView1.Size = new System.Drawing.Size(705, 168);
            hospitalsGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 110;
            // 
            // hospitalName
            // 
            hospitalName.HeaderText = "Name";
            hospitalName.MinimumWidth = 6;
            hospitalName.Name = "hospitalName";
            hospitalName.Width = 110;
            // 
            // hospitalAddress
            // 
            hospitalAddress.HeaderText = "Address";
            hospitalAddress.MinimumWidth = 6;
            hospitalAddress.Name = "hospitalAddress";
            hospitalAddress.Width = 110;
            // 
            // hospitalPhone
            // 
            hospitalPhone.HeaderText = "Phone";
            hospitalPhone.MinimumWidth = 6;
            hospitalPhone.Name = "hospitalPhone";
            hospitalPhone.Width = 110;
            // 
            // hospitalEmail
            // 
            hospitalEmail.HeaderText = "Email";
            hospitalEmail.MinimumWidth = 6;
            hospitalEmail.Name = "hospitalEmail";
            hospitalEmail.Width = 110;
            // 
            // hospitalDescription
            // 
            hospitalDescription.HeaderText = "Description";
            hospitalDescription.MinimumWidth = 6;
            hospitalDescription.Name = "hospitalDescription";
            hospitalDescription.Width = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.2641506F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(26, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(334, 30);
            label1.TabIndex = 2;
            label1.Text = "Hospital Managment Operations";
            // 
            // HospitalFormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(869, 625);
            Controls.Add(label1);
            Controls.Add(hospitalsGroupBox);
            Controls.Add(hospitalDetailsGroupBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HospitalFormAdmin";
            Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Hospital Administrator Mode";
            hospitalDetailsGroupBox.ResumeLayout(false);
            hospitalDetailsGroupBox.PerformLayout();
            hospitalsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hospitalsGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hospitalDetailsGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox hospitalsGroupBox;
        private System.Windows.Forms.DataGridView hospitalsGridView1;
        private System.Windows.Forms.TextBox hospitalDescriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}
