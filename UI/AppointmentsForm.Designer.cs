
namespace Hospital_System
{
    partial class AppointmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            appointmentTitle = new System.Windows.Forms.Label();
            doctorLabel = new System.Windows.Forms.Label();
            patientLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            appointmentsGridView = new System.Windows.Forms.DataGridView();
            appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            doctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)appointmentsGridView).BeginInit();
            SuspendLayout();
            // 
            // appointmentTitle
            // 
            appointmentTitle.AutoSize = true;
            appointmentTitle.Font = new System.Drawing.Font("Segoe UI", 19.6981125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            appointmentTitle.Location = new System.Drawing.Point(24, 9);
            appointmentTitle.Name = "appointmentTitle";
            appointmentTitle.Size = new System.Drawing.Size(213, 40);
            appointmentTitle.TabIndex = 0;
            appointmentTitle.Text = "Appointments";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Location = new System.Drawing.Point(24, 108);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new System.Drawing.Size(51, 17);
            doctorLabel.TabIndex = 1;
            doctorLabel.Text = "Doctor:";
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Location = new System.Drawing.Point(277, 111);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new System.Drawing.Size(50, 17);
            patientLabel.TabIndex = 2;
            patientLabel.Text = "Patient:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(547, 111);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(38, 17);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:\r\n";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(333, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(134, 25);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(591, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(134, 25);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(81, 105);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(134, 25);
            comboBox3.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new System.Drawing.Point(1, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(801, 10);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // appointmentsGridView
            // 
            appointmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { appointmentID, patientID, doctorID, date, status });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.3018875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            appointmentsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            appointmentsGridView.Location = new System.Drawing.Point(24, 187);
            appointmentsGridView.Name = "appointmentsGridView";
            appointmentsGridView.RowHeadersWidth = 45;
            appointmentsGridView.Size = new System.Drawing.Size(764, 200);
            appointmentsGridView.TabIndex = 8;
            // 
            // appointmentID
            // 
            appointmentID.HeaderText = "ID";
            appointmentID.MinimumWidth = 6;
            appointmentID.Name = "appointmentID";
            appointmentID.Width = 110;
            // 
            // patientID
            // 
            patientID.HeaderText = "PATIENT";
            patientID.MinimumWidth = 6;
            patientID.Name = "patientID";
            patientID.Width = 110;
            // 
            // doctorID
            // 
            doctorID.HeaderText = "DOCTOR";
            doctorID.MinimumWidth = 6;
            doctorID.Name = "doctorID";
            doctorID.Width = 110;
            // 
            // date
            // 
            date.HeaderText = "DATA";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 110;
            // 
            // status
            // 
            status.HeaderText = "STATUS";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 110;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(appointmentsGridView);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateLabel);
            Controls.Add(patientLabel);
            Controls.Add(doctorLabel);
            Controls.Add(appointmentTitle);
            Name = "AppointmentsForm";
            Text = "AppointmentsForm";
            ((System.ComponentModel.ISupportInitialize)appointmentsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label appointmentTitle;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView appointmentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}