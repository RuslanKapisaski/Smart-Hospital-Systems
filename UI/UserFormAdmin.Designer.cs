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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFormAdmin));
            logsTab = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dataGridViewUsers = new System.Windows.Forms.DataGridView();
            roleBox = new System.Windows.Forms.ComboBox();
            setRoleButton = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            dataGridViewRoles = new System.Windows.Forms.DataGridView();
            addRoleBtn = new System.Windows.Forms.Button();
            tabPage3 = new System.Windows.Forms.TabPage();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            roleRequestsTab = new System.Windows.Forms.TabPage();
            dataGridViewRoleRequests = new System.Windows.Forms.DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cutomDropDownMenu1 = new Hospital_System.UI.CustomControls.CutomDropDownMenu(components);
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            logsTab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            roleRequestsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoleRequests).BeginInit();
            SuspendLayout();
            // 
            // logsTab
            // 
            logsTab.Controls.Add(tabPage2);
            logsTab.Controls.Add(tabPage3);
            logsTab.Controls.Add(roleRequestsTab);
            logsTab.Controls.Add(tabPage1);
            logsTab.Location = new System.Drawing.Point(33, 87);
            logsTab.Name = "logsTab";
            logsTab.SelectedIndex = 0;
            logsTab.Size = new System.Drawing.Size(734, 336);
            logsTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.Transparent;
            tabPage1.BackgroundImage = (System.Drawing.Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabPage1.Controls.Add(dataGridViewUsers);
            tabPage1.Controls.Add(roleBox);
            tabPage1.Controls.Add(setRoleButton);
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(726, 306);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new System.Drawing.Point(3, 27);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 45;
            dataGridViewUsers.Size = new System.Drawing.Size(452, 262);
            dataGridViewUsers.TabIndex = 1;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Location = new System.Drawing.Point(461, 27);
            roleBox.Name = "roleBox";
            roleBox.Size = new System.Drawing.Size(82, 25);
            roleBox.TabIndex = 2;
            roleBox.Text = "Roles:";
            // 
            // setRoleButton
            // 
            setRoleButton.Location = new System.Drawing.Point(461, 82);
            setRoleButton.Name = "setRoleButton";
            setRoleButton.Size = new System.Drawing.Size(82, 25);
            setRoleButton.TabIndex = 1;
            setRoleButton.Text = "SET ROLE";
            setRoleButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (System.Drawing.Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(dataGridViewRoles);
            tabPage2.Controls.Add(addRoleBtn);
            tabPage2.Location = new System.Drawing.Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(726, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Roles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoles
            // 
            dataGridViewRoles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoles.Location = new System.Drawing.Point(6, 36);
            dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewRoles.RowHeadersWidth = 45;
            dataGridViewRoles.Size = new System.Drawing.Size(276, 221);
            dataGridViewRoles.TabIndex = 2;
            // 
            // addRoleBtn
            // 
            addRoleBtn.BackColor = System.Drawing.Color.Transparent;
            addRoleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            addRoleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            addRoleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            addRoleBtn.Font = new System.Drawing.Font("Segoe UI", 12.2264156F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204, true);
            addRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            addRoleBtn.Location = new System.Drawing.Point(358, 90);
            addRoleBtn.Name = "addRoleBtn";
            addRoleBtn.Size = new System.Drawing.Size(116, 44);
            addRoleBtn.TabIndex = 0;
            addRoleBtn.Text = "ADD ROLE";
            addRoleBtn.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (System.Drawing.Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new System.Drawing.Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(726, 306);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Logs";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new System.Drawing.Point(138, 46);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 45;
            dataGridView3.Size = new System.Drawing.Size(278, 236);
            dataGridView3.TabIndex = 0;
            // 
            // roleRequestsTab
            // 
            roleRequestsTab.BackColor = System.Drawing.Color.CornflowerBlue;
            roleRequestsTab.BackgroundImage = (System.Drawing.Image)resources.GetObject("roleRequestsTab.BackgroundImage");
            roleRequestsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            roleRequestsTab.Controls.Add(comboBox1);
            roleRequestsTab.Controls.Add(button1);
            roleRequestsTab.Controls.Add(dataGridViewRoleRequests);
            roleRequestsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            roleRequestsTab.Location = new System.Drawing.Point(4, 26);
            roleRequestsTab.Name = "roleRequestsTab";
            roleRequestsTab.Padding = new System.Windows.Forms.Padding(3);
            roleRequestsTab.Size = new System.Drawing.Size(726, 306);
            roleRequestsTab.TabIndex = 3;
            roleRequestsTab.Text = "Role Requests";
            // 
            // dataGridViewRoleRequests
            // 
            dataGridViewRoleRequests.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewRoleRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoleRequests.GridColor = System.Drawing.SystemColors.InfoText;
            dataGridViewRoleRequests.Location = new System.Drawing.Point(10, 58);
            dataGridViewRoleRequests.Name = "dataGridViewRoleRequests";
            dataGridViewRoleRequests.RowHeadersWidth = 45;
            dataGridViewRoleRequests.Size = new System.Drawing.Size(539, 166);
            dataGridViewRoleRequests.TabIndex = 0;
            // 
            // cutomDropDownMenu1
            // 
            cutomDropDownMenu1.ImageScalingSize = new System.Drawing.Size(18, 18);
            cutomDropDownMenu1.IsMainMenu = false;
            cutomDropDownMenu1.MenuItemHeight = 25;
            cutomDropDownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            cutomDropDownMenu1.Name = "cutomDropDownMenu1";
            cutomDropDownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            cutomDropDownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(578, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(104, 25);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Roles:";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(578, 153);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(104, 25);
            button1.TabIndex = 3;
            button1.Text = "SET ROLE";
            button1.UseVisualStyleBackColor = true;
            // 
            // UserFormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(logsTab);
            DoubleBuffered = true;
            Name = "UserFormAdmin";
            Text = "UserFormAdmin";
            logsTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            roleRequestsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoleRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Button setRoleButton;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomControls.CutomDropDownMenu cutomDropDownMenu1;
        public System.Windows.Forms.DataGridView dataGridViewUsers;
        public System.Windows.Forms.Button addRoleBtn;
        private System.Windows.Forms.TabPage roleRequestsTab;
        public System.Windows.Forms.TabControl logsTab;
        private System.Windows.Forms.DataGridView dataGridViewRoleRequests;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}