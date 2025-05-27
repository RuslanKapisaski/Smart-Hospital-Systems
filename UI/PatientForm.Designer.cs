
namespace Hospital_System.UI
{
    partial class PatientFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientFormAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            welcomeLabel = new System.Windows.Forms.Label();
            appointmentsTab = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            appointmentsGrid = new System.Windows.Forms.DataGridView();
            hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            doctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabPage2 = new System.Windows.Forms.TabPage();
            hospitalLabel = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            resultsLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            doctorsGridView2 = new System.Windows.Forms.DataGridView();
            hospitalsDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            doctorsTab = new System.Windows.Forms.TabPage();
            appointmentsTab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsGrid).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorsGridView2).BeginInit();
            doctorsTab.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 16.3018875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            welcomeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            welcomeLabel.Location = new System.Drawing.Point(39, 39);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new System.Drawing.Size(138, 35);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, ";
            // 
            // appointmentsTab
            // 
            appointmentsTab.Controls.Add(tabPage1);
            appointmentsTab.Controls.Add(tabPage2);
            appointmentsTab.Controls.Add(doctorsTab);
            appointmentsTab.Location = new System.Drawing.Point(61, 118);
            appointmentsTab.Name = "appointmentsTab";
            appointmentsTab.SelectedIndex = 0;
            appointmentsTab.Size = new System.Drawing.Size(797, 472);
            appointmentsTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.DarkBlue;
            tabPage1.BackgroundImage = (System.Drawing.Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabPage1.Controls.Add(appointmentsGrid);
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(789, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Appointments";
            // 
            // appointmentsGrid
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            appointmentsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            appointmentsGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            appointmentsGrid.ColumnHeadersHeight = 25;
            appointmentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { hospital, doctorID, appointmentDate, appointmentStatus });
            appointmentsGrid.Location = new System.Drawing.Point(22, 60);
            appointmentsGrid.Name = "appointmentsGrid";
            appointmentsGrid.RowHeadersWidth = 45;
            appointmentsGrid.Size = new System.Drawing.Size(482, 107);
            appointmentsGrid.TabIndex = 4;
            // 
            // hospital
            // 
            hospital.HeaderText = "HOSPITAL";
            hospital.MinimumWidth = 6;
            hospital.Name = "hospital";
            hospital.Width = 110;
            // 
            // doctorID
            // 
            doctorID.HeaderText = "DOCTOR";
            doctorID.MinimumWidth = 6;
            doctorID.Name = "doctorID";
            doctorID.Width = 110;
            // 
            // appointmentDate
            // 
            appointmentDate.HeaderText = "DATE";
            appointmentDate.MinimumWidth = 6;
            appointmentDate.Name = "appointmentDate";
            appointmentDate.Width = 110;
            // 
            // appointmentStatus
            // 
            appointmentStatus.HeaderText = "STATUS";
            appointmentStatus.MinimumWidth = 6;
            appointmentStatus.Name = "appointmentStatus";
            appointmentStatus.Width = 110;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (System.Drawing.Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(hospitalLabel);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(resultsLabel);
            tabPage2.Controls.Add(patientNameLabel);
            tabPage2.Controls.Add(dateLabel);
            tabPage2.Location = new System.Drawing.Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(789, 442);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Medical Results";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // hospitalLabel
            // 
            hospitalLabel.AutoSize = true;
            hospitalLabel.Font = new System.Drawing.Font("Segoe UI", 10.8679247F);
            hospitalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            hospitalLabel.Location = new System.Drawing.Point(24, 12);
            hospitalLabel.Name = "hospitalLabel";
            hospitalLabel.Size = new System.Drawing.Size(70, 21);
            hospitalLabel.TabIndex = 5;
            hospitalLabel.Text = "Hospital:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            richTextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            richTextBox1.Location = new System.Drawing.Point(93, 171);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(656, 191);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8679247F);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(22, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 21);
            label2.TabIndex = 3;
            label2.Text = "Doctor:";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new System.Drawing.Font("Segoe UI", 10.8679247F);
            resultsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resultsLabel.Location = new System.Drawing.Point(24, 171);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new System.Drawing.Size(63, 21);
            resultsLabel.TabIndex = 2;
            resultsLabel.Text = "Results:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8679247F);
            patientNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            patientNameLabel.Location = new System.Drawing.Point(24, 59);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(60, 21);
            patientNameLabel.TabIndex = 1;
            patientNameLabel.Text = "Patient:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.8679247F);
            dateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dateLabel.Location = new System.Drawing.Point(33, 404);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(49, 21);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Date: ";
            // 
            // doctorsGridView2
            // 
            doctorsGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorsGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { doctorName, hospitalsDoctor });
            doctorsGridView2.GridColor = System.Drawing.SystemColors.MenuHighlight;
            doctorsGridView2.Location = new System.Drawing.Point(47, 164);
            doctorsGridView2.Name = "doctorsGridView2";
            doctorsGridView2.RowHeadersWidth = 45;
            doctorsGridView2.Size = new System.Drawing.Size(267, 57);
            doctorsGridView2.TabIndex = 0;
            // 
            // hospitalsDoctor
            // 
            hospitalsDoctor.HeaderText = "HOSPITAL";
            hospitalsDoctor.MinimumWidth = 6;
            hospitalsDoctor.Name = "hospitalsDoctor";
            hospitalsDoctor.Width = 110;
            // 
            // doctorName
            // 
            doctorName.HeaderText = "Doctor";
            doctorName.MinimumWidth = 6;
            doctorName.Name = "doctorName";
            doctorName.Width = 110;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(413, 212);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(129, 40);
            button1.TabIndex = 1;
            button1.Text = "Request ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Romantic", 8.150943F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            label1.Location = new System.Drawing.Point(497, 401);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(271, 14);
            label1.TabIndex = 2;
            label1.Text = "Note: Select a doctor from table if you want to request it";
            // 
            // doctorsTab
            // 
            doctorsTab.BackgroundImage = (System.Drawing.Image)resources.GetObject("doctorsTab.BackgroundImage");
            doctorsTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            doctorsTab.Controls.Add(label1);
            doctorsTab.Controls.Add(button1);
            doctorsTab.Controls.Add(doctorsGridView2);
            doctorsTab.Location = new System.Drawing.Point(4, 26);
            doctorsTab.Name = "doctorsTab";
            doctorsTab.Padding = new System.Windows.Forms.Padding(3);
            doctorsTab.Size = new System.Drawing.Size(789, 442);
            doctorsTab.TabIndex = 2;
            doctorsTab.Text = "Doctors";
            doctorsTab.UseVisualStyleBackColor = true;
            // 
            // PatientFormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(958, 610);
            Controls.Add(appointmentsTab);
            Controls.Add(welcomeLabel);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "PatientFormAdmin";
            Text = "Patient";
            appointmentsTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentsGrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorsGridView2).EndInit();
            doctorsTab.ResumeLayout(false);
            doctorsTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl appointmentsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView appointmentsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentStatus;
        private System.Windows.Forms.Label hospitalLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Label welcomeLabel;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage doctorsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView doctorsGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalsDoctor;
    }
}