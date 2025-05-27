namespace Hospital_System.UI
{
    partial class UserFormAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            roleBox = new System.Windows.Forms.ComboBox();
            setRoleButton = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            addRoleBtn = new System.Windows.Forms.Button();
            deleteRoleBtn = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            roleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            roleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            logsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            logName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(51, 87);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(466, 313);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(roleBox);
            tabPage1.Controls.Add(setRoleButton);
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(458, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { userEmail, userRole });
            dataGridView1.Location = new System.Drawing.Point(16, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.Size = new System.Drawing.Size(273, 71);
            dataGridView1.TabIndex = 1;
            // 
            // userEmail
            // 
            userEmail.HeaderText = "Email";
            userEmail.MinimumWidth = 6;
            userEmail.Name = "userEmail";
            userEmail.Width = 110;
            // 
            // userRole
            // 
            userRole.HeaderText = "Role";
            userRole.MinimumWidth = 6;
            userRole.Name = "userRole";
            userRole.Width = 110;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Location = new System.Drawing.Point(338, 240);
            roleBox.Name = "roleBox";
            roleBox.Size = new System.Drawing.Size(100, 25);
            roleBox.TabIndex = 2;
            roleBox.Text = "Roles:";
            // 
            // setRoleButton
            // 
            setRoleButton.Location = new System.Drawing.Point(338, 199);
            setRoleButton.Name = "setRoleButton";
            setRoleButton.Size = new System.Drawing.Size(100, 25);
            setRoleButton.TabIndex = 1;
            setRoleButton.Text = "SET ROLE";
            setRoleButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(deleteRoleBtn);
            tabPage2.Controls.Add(addRoleBtn);
            tabPage2.Location = new System.Drawing.Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(458, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Roles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new System.Drawing.Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(458, 283);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Logs";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // addRoleBtn
            // 
            addRoleBtn.BackColor = System.Drawing.Color.Transparent;
            addRoleBtn.Font = new System.Drawing.Font("Segoe UI", 10.8679247F);
            addRoleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            addRoleBtn.Location = new System.Drawing.Point(307, 136);
            addRoleBtn.Name = "addRoleBtn";
            addRoleBtn.Size = new System.Drawing.Size(116, 44);
            addRoleBtn.TabIndex = 0;
            addRoleBtn.Text = "ADD ROLE";
            addRoleBtn.UseVisualStyleBackColor = false;
            // 
            // deleteRoleBtn
            // 
            deleteRoleBtn.Font = new System.Drawing.Font("Segoe UI", 10.8679247F);
            deleteRoleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            deleteRoleBtn.Location = new System.Drawing.Point(307, 206);
            deleteRoleBtn.Name = "deleteRoleBtn";
            deleteRoleBtn.Size = new System.Drawing.Size(116, 44);
            deleteRoleBtn.TabIndex = 1;
            deleteRoleBtn.Text = "DELETE ROLE";
            deleteRoleBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { roleId, roleName });
            dataGridView2.Location = new System.Drawing.Point(6, 72);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 45;
            dataGridView2.Size = new System.Drawing.Size(265, 166);
            dataGridView2.TabIndex = 2;
            // 
            // roleId
            // 
            roleId.HeaderText = "ID";
            roleId.MinimumWidth = 6;
            roleId.Name = "roleId";
            roleId.Width = 110;
            // 
            // roleName
            // 
            roleName.HeaderText = "NAME";
            roleName.MinimumWidth = 6;
            roleName.Name = "roleName";
            roleName.Width = 110;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { logsID, logName });
            dataGridView3.Location = new System.Drawing.Point(78, 84);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 45;
            dataGridView3.Size = new System.Drawing.Size(265, 95);
            dataGridView3.TabIndex = 0;
            // 
            // logsID
            // 
            logsID.HeaderText = "ID";
            logsID.MinimumWidth = 6;
            logsID.Name = "logsID";
            logsID.Width = 110;
            // 
            // logName
            // 
            logName.HeaderText = "LOG";
            logName.MinimumWidth = 6;
            logName.Name = "logName";
            logName.Width = 110;
            // 
            // UserFormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabControl1);
            Name = "UserFormAdmin";
            Text = "UserFormAdmin";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Button setRoleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRole;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleName;
        private System.Windows.Forms.Button deleteRoleBtn;
        private System.Windows.Forms.Button addRoleBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn logName;
    }
}