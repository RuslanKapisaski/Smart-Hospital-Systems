
namespace Hospital_System.UI
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            welcomeLabel = new System.Windows.Forms.Label();
            mainTab = new System.Windows.Forms.TabControl();
            tabAppointemnts = new System.Windows.Forms.TabPage();
            appointmentsGrid = new System.Windows.Forms.DataGridView();
            hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            doctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            resultsTab = new System.Windows.Forms.TabPage();
            hospitalLabel = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            resultsLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            doctorsTab = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            doctorsGridView2 = new System.Windows.Forms.DataGridView();
            doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalsDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalsTab = new System.Windows.Forms.TabPage();
            dataGridViewHospitals = new System.Windows.Forms.DataGridView();
            hospitalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalEstablishedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hospitalDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mainTab.SuspendLayout();
            tabAppointemnts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsGrid).BeginInit();
            resultsTab.SuspendLayout();
            doctorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorsGridView2).BeginInit();
            hospitalsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHospitals).BeginInit();
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
            // mainTab
            // 
            mainTab.Controls.Add(tabAppointemnts);
            mainTab.Controls.Add(resultsTab);
            mainTab.Controls.Add(doctorsTab);
            mainTab.Controls.Add(hospitalsTab);
            mainTab.Location = new System.Drawing.Point(61, 118);
            mainTab.Name = "mainTab";
            mainTab.SelectedIndex = 0;
            mainTab.Size = new System.Drawing.Size(797, 472);
            mainTab.TabIndex = 1;
            // 
            // tabAppointemnts
            // 
            tabAppointemnts.BackColor = System.Drawing.Color.Black;
            tabAppointemnts.BackgroundImage = (System.Drawing.Image)resources.GetObject("tabAppointemnts.BackgroundImage");
            tabAppointemnts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabAppointemnts.Controls.Add(appointmentsGrid);
            tabAppointemnts.Location = new System.Drawing.Point(4, 26);
            tabAppointemnts.Name = "tabAppointemnts";
            tabAppointemnts.Padding = new System.Windows.Forms.Padding(3);
            tabAppointemnts.Size = new System.Drawing.Size(789, 442);
            tabAppointemnts.TabIndex = 0;
            //tabAppointemnts.Text = "Appointments";
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
            appointmentsGrid.Location = new System.Drawing.Point(6, 30);
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
            // resultsTab
            // 
            resultsTab.BackgroundImage = (System.Drawing.Image)resources.GetObject("resultsTab.BackgroundImage");
            resultsTab.Controls.Add(hospitalLabel);
            resultsTab.Controls.Add(richTextBox1);
            resultsTab.Controls.Add(label2);
            resultsTab.Controls.Add(resultsLabel);
            resultsTab.Controls.Add(patientNameLabel);
            resultsTab.Controls.Add(dateLabel);
            resultsTab.Location = new System.Drawing.Point(4, 26);
            resultsTab.Name = "resultsTab";
            resultsTab.Padding = new System.Windows.Forms.Padding(3);
            resultsTab.Size = new System.Drawing.Size(789, 442);
            resultsTab.TabIndex = 1;
            resultsTab.Text = "Medical Results";
            resultsTab.UseVisualStyleBackColor = true;
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
            // doctorsTab
            // 
            doctorsTab.BackgroundImage = (System.Drawing.Image)resources.GetObject("doctorsTab.BackgroundImage");
            doctorsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // button1
            // 
            button1.Location = new System.Drawing.Point(350, 164);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(129, 40);
            button1.TabIndex = 1;
            button1.Text = "Request ";
            button1.UseVisualStyleBackColor = true;
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
            // doctorName
            // 
            doctorName.HeaderText = "Doctor";
            doctorName.MinimumWidth = 6;
            doctorName.Name = "doctorName";
            doctorName.Width = 110;
            // 
            // hospitalsDoctor
            // 
            hospitalsDoctor.HeaderText = "HOSPITAL";
            hospitalsDoctor.MinimumWidth = 6;
            hospitalsDoctor.Name = "hospitalsDoctor";
            hospitalsDoctor.Width = 110;
            // 
            // hospitalsTab
            // 
            hospitalsTab.BackgroundImage = (System.Drawing.Image)resources.GetObject("hospitalsTab.BackgroundImage");
            hospitalsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            hospitalsTab.Controls.Add(dataGridViewHospitals);
            hospitalsTab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            hospitalsTab.Location = new System.Drawing.Point(4, 26);
            hospitalsTab.Name = "hospitalsTab";
            hospitalsTab.Padding = new System.Windows.Forms.Padding(3);
            hospitalsTab.Size = new System.Drawing.Size(789, 442);
            hospitalsTab.TabIndex = 3;
            hospitalsTab.Text = "Hospitals";
            hospitalsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHospitals
            // 
            dataGridViewHospitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHospitals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { hospitalName, hospitalAddress, hospitalNumber, hospitalEmail, hospitalEstablishedDate, hospitalDescription });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.2641506F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewHospitals.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHospitals.Location = new System.Drawing.Point(41, 111);
            dataGridViewHospitals.Name = "dataGridViewHospitals";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.2641506F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewHospitals.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewHospitals.RowHeadersWidth = 45;
            dataGridViewHospitals.Size = new System.Drawing.Size(706, 166);
            dataGridViewHospitals.TabIndex = 0;
            // 
            // hospitalName
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            hospitalName.DefaultCellStyle = dataGridViewCellStyle2;
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
            // hospitalNumber
            // 
            hospitalNumber.HeaderText = "Number";
            hospitalNumber.MinimumWidth = 6;
            hospitalNumber.Name = "hospitalNumber";
            hospitalNumber.Width = 110;
            // 
            // hospitalEmail
            // 
            hospitalEmail.HeaderText = "Email";
            hospitalEmail.MinimumWidth = 6;
            hospitalEmail.Name = "hospitalEmail";
            hospitalEmail.Width = 110;
            // 
            // hospitalEstablishedDate
            // 
            hospitalEstablishedDate.HeaderText = "Established Date";
            hospitalEstablishedDate.MinimumWidth = 6;
            hospitalEstablishedDate.Name = "hospitalEstablishedDate";
            hospitalEstablishedDate.Width = 110;
            // 
            // hospitalDescription
            // 
            hospitalDescription.HeaderText = "Description";
            hospitalDescription.MinimumWidth = 6;
            hospitalDescription.Name = "hospitalDescription";
            hospitalDescription.Width = 110;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(958, 610);
            Controls.Add(mainTab);
            Controls.Add(welcomeLabel);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "PatientForm";
            Text = "Patient";
            mainTab.ResumeLayout(false);
            tabAppointemnts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentsGrid).EndInit();
            resultsTab.ResumeLayout(false);
            resultsTab.PerformLayout();
            doctorsTab.ResumeLayout(false);
            doctorsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorsGridView2).EndInit();
            hospitalsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHospitals).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage resultsTab;
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
        private System.Windows.Forms.TabPage doctorsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView doctorsGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalsDoctor;
        private System.Windows.Forms.TabPage hospitalsTab;
        private System.Windows.Forms.DataGridView dataGridViewHospitals;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalEstablishedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalDescription;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TabPage tabAppointemnts;
    }
}