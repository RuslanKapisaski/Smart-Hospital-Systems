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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalFormAdmin));
            hospitalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            descriptionTextBox = new System.Windows.Forms.RichTextBox();
            emailTextBox = new System.Windows.Forms.TextBox();
            phoneTextBox = new System.Windows.Forms.TextBox();
            addressTextBox = new System.Windows.Forms.TextBox();
            nameTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            Phone = new System.Windows.Forms.Label();
            Address = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            deleteHospitalButton = new System.Windows.Forms.Button();
            addHospitalButton = new System.Windows.Forms.Button();
            hospitalsGroupBox = new System.Windows.Forms.GroupBox();
            hospitalsGridView = new System.Windows.Forms.DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new System.Windows.Forms.Label();
            HospitalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalDetailsGroupBox.SuspendLayout();
            hospitalsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hospitalsGridView).BeginInit();
            SuspendLayout();
            // 
            // hospitalDetailsGroupBox
            // 
            hospitalDetailsGroupBox.BackColor = System.Drawing.Color.Black;
            hospitalDetailsGroupBox.Controls.Add(descriptionTextBox);
            hospitalDetailsGroupBox.Controls.Add(emailTextBox);
            hospitalDetailsGroupBox.Controls.Add(phoneTextBox);
            hospitalDetailsGroupBox.Controls.Add(addressTextBox);
            hospitalDetailsGroupBox.Controls.Add(nameTextBox);
            hospitalDetailsGroupBox.Controls.Add(descriptionLabel);
            hospitalDetailsGroupBox.Controls.Add(emailLabel);
            hospitalDetailsGroupBox.Controls.Add(Phone);
            hospitalDetailsGroupBox.Controls.Add(Address);
            hospitalDetailsGroupBox.Controls.Add(nameLabel);
            hospitalDetailsGroupBox.Controls.Add(deleteHospitalButton);
            hospitalDetailsGroupBox.Controls.Add(addHospitalButton);
            hospitalDetailsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            hospitalDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            hospitalDetailsGroupBox.Location = new System.Drawing.Point(109, 45);
            hospitalDetailsGroupBox.Name = "hospitalDetailsGroupBox";
            hospitalDetailsGroupBox.Size = new System.Drawing.Size(576, 319);
            hospitalDetailsGroupBox.TabIndex = 0;
            hospitalDetailsGroupBox.TabStop = false;
            hospitalDetailsGroupBox.Text = "Hospitals";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new System.Drawing.Point(115, 214);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new System.Drawing.Size(276, 90);
            descriptionTextBox.TabIndex = 11;
            descriptionTextBox.Text = "";
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
            phoneTextBox.Margin = new System.Windows.Forms.Padding(10);
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
            nameTextBox.Location = new System.Drawing.Point(112, 54);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(279, 27);
            nameTextBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold);
            descriptionLabel.Location = new System.Drawing.Point(18, 218);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(91, 20);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold);
            emailLabel.Location = new System.Drawing.Point(30, 180);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold);
            Phone.Location = new System.Drawing.Point(26, 142);
            Phone.Name = "Phone";
            Phone.Size = new System.Drawing.Size(57, 20);
            Phone.TabIndex = 4;
            Phone.Text = "Phone:";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold);
            Address.Location = new System.Drawing.Point(26, 100);
            Address.Name = "Address";
            Address.Size = new System.Drawing.Size(67, 20);
            Address.TabIndex = 3;
            Address.Text = "Address:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(26, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // deleteHospitalButton
            // 
            deleteHospitalButton.BackColor = System.Drawing.Color.Firebrick;
            deleteHospitalButton.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            deleteHospitalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            deleteHospitalButton.Location = new System.Drawing.Point(432, 162);
            deleteHospitalButton.Name = "deleteHospitalButton";
            deleteHospitalButton.Size = new System.Drawing.Size(119, 51);
            deleteHospitalButton.TabIndex = 1;
            deleteHospitalButton.Text = "DELETE";
            deleteHospitalButton.UseVisualStyleBackColor = false;
            // 
            // addHospitalButton
            // 
            addHospitalButton.BackColor = System.Drawing.Color.ForestGreen;
            addHospitalButton.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            addHospitalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            addHospitalButton.Location = new System.Drawing.Point(432, 77);
            addHospitalButton.Name = "addHospitalButton";
            addHospitalButton.Size = new System.Drawing.Size(119, 51);
            addHospitalButton.TabIndex = 0;
            addHospitalButton.Text = "ADD";
            addHospitalButton.UseVisualStyleBackColor = false;
            addHospitalButton.Click += addHospitalButton_Click;
            // 
            // hospitalsGroupBox
            // 
            hospitalsGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            hospitalsGroupBox.Controls.Add(hospitalsGridView);
            hospitalsGroupBox.Location = new System.Drawing.Point(69, 370);
            hospitalsGroupBox.Name = "hospitalsGroupBox";
            hospitalsGroupBox.Size = new System.Drawing.Size(711, 192);
            hospitalsGroupBox.TabIndex = 1;
            hospitalsGroupBox.TabStop = false;
            hospitalsGroupBox.Text = "Hospitals";
            // 
            // hospitalsGridView
            // 
            hospitalsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            hospitalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hospitalsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { HospitalId, Name, hospitalAddress, ContactNumber, hospitalEmail, hospitalDescription });
            hospitalsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            hospitalsGridView.GridColor = System.Drawing.SystemColors.InfoText;
            hospitalsGridView.Location = new System.Drawing.Point(3, 21);
            hospitalsGridView.Name = "hospitalsGridView";
            hospitalsGridView.RowHeadersWidth = 45;
            hospitalsGridView.Size = new System.Drawing.Size(705, 168);
            hospitalsGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.2641506F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(26, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(334, 30);
            label1.TabIndex = 2;
            label1.Text = "Hospital Managment Operations";
            // 
            // HospitalId
            // 
            HospitalId.HeaderText = "ID";
            HospitalId.MinimumWidth = 6;
            HospitalId.Name = "HospitalId";
            HospitalId.Width = 110;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 110;
            // 
            // hospitalAddress
            // 
            hospitalAddress.HeaderText = "Address";
            hospitalAddress.MinimumWidth = 6;
            hospitalAddress.Name = "hospitalAddress";
            hospitalAddress.Width = 110;
            // 
            // ContactNumber
            // 
            ContactNumber.HeaderText = "Phone";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.Width = 110;
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
            // HospitalFormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(869, 625);
            Controls.Add(label1);
            Controls.Add(hospitalsGroupBox);
            Controls.Add(hospitalDetailsGroupBox);
            ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
           
            Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Hospital Administrator Mode";
            hospitalDetailsGroupBox.ResumeLayout(false);
            hospitalDetailsGroupBox.PerformLayout();
            hospitalsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hospitalsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox hospitalDetailsGroupBox;
        public System.Windows.Forms.Button deleteHospitalButton;
        public System.Windows.Forms.Button addHospitalButton;
        public System.Windows.Forms.GroupBox hospitalsGroupBox;
        public System.Windows.Forms.DataGridView hospitalsGridView;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.TextBox phoneTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Label Phone;
        public System.Windows.Forms.Label Address;
        public System.Windows.Forms.Label nameLabel;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalDescription;
    }
}
