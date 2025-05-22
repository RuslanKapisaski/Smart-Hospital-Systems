
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.PatientFirstName,
            this.PatientSecondName});
            this.dataGridViewUsers.Location = new System.Drawing.Point(123, 148);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 45;
            this.dataGridViewUsers.Size = new System.Drawing.Size(448, 197);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.Width = 110;
            // 
            // PatientFirstName
            // 
            this.PatientFirstName.HeaderText = "Име";
            this.PatientFirstName.MinimumWidth = 6;
            this.PatientFirstName.Name = "PatientFirstName";
            this.PatientFirstName.Width = 110;
            // 
            // PatientSecondName
            // 
            this.PatientSecondName.HeaderText = "Презиме";
            this.PatientSecondName.MinimumWidth = 6;
            this.PatientSecondName.Name = "PatientSecondName";
            this.PatientSecondName.Width = 110;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(620, 220);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "ADD";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.dataGridViewUsers);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewUsers;
        public System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        public System.Windows.Forms.DataGridViewTextBoxColumn PatientFirstName;
        public System.Windows.Forms.DataGridViewTextBoxColumn PatientSecondName;
        public System.Windows.Forms.Button btnAddNewUser;
    }
}