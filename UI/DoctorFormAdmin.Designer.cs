
namespace Hospital_System.UI
{
    partial class DoctorFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorFormAdmin));
            groupBoxDoctors = new System.Windows.Forms.GroupBox();
            deleteDoctorBtn = new System.Windows.Forms.Button();
            editDoctorBtn = new System.Windows.Forms.Button();
            viewDoctorsBtn = new System.Windows.Forms.Button();
            addDoctorBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBoxDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDoctors
            // 
            groupBoxDoctors.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBoxDoctors.BackColor = System.Drawing.Color.Transparent;
            groupBoxDoctors.Controls.Add(deleteDoctorBtn);
            groupBoxDoctors.Controls.Add(editDoctorBtn);
            groupBoxDoctors.Controls.Add(viewDoctorsBtn);
            groupBoxDoctors.Controls.Add(addDoctorBtn);
            groupBoxDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 204);
            groupBoxDoctors.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            groupBoxDoctors.Location = new System.Drawing.Point(734, 82);
            groupBoxDoctors.Margin = new System.Windows.Forms.Padding(4);
            groupBoxDoctors.Name = "groupBoxDoctors";
            groupBoxDoctors.Padding = new System.Windows.Forms.Padding(4);
            groupBoxDoctors.Size = new System.Drawing.Size(236, 489);
            groupBoxDoctors.TabIndex = 0;
            groupBoxDoctors.TabStop = false;
            groupBoxDoctors.Text = "Doctor Services";
            // 
            // deleteDoctorBtn
            // 
            deleteDoctorBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            deleteDoctorBtn.BackColor = System.Drawing.Color.MidnightBlue;
            deleteDoctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8679247F, System.Drawing.FontStyle.Bold);
            deleteDoctorBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            deleteDoctorBtn.Location = new System.Drawing.Point(46, 371);
            deleteDoctorBtn.Margin = new System.Windows.Forms.Padding(4);
            deleteDoctorBtn.Name = "deleteDoctorBtn";
            deleteDoctorBtn.Size = new System.Drawing.Size(145, 72);
            deleteDoctorBtn.TabIndex = 3;
            deleteDoctorBtn.Text = "DELETE";
            deleteDoctorBtn.UseVisualStyleBackColor = false;
            // 
            // editDoctorBtn
            // 
            editDoctorBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            editDoctorBtn.BackColor = System.Drawing.Color.MidnightBlue;
            editDoctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8679247F, System.Drawing.FontStyle.Bold);
            editDoctorBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            editDoctorBtn.Location = new System.Drawing.Point(46, 256);
            editDoctorBtn.Margin = new System.Windows.Forms.Padding(4);
            editDoctorBtn.Name = "editDoctorBtn";
            editDoctorBtn.Size = new System.Drawing.Size(145, 72);
            editDoctorBtn.TabIndex = 2;
            editDoctorBtn.Text = "EDIT";
            editDoctorBtn.UseVisualStyleBackColor = false;
            // 
            // viewDoctorsBtn
            // 
            viewDoctorsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            viewDoctorsBtn.BackColor = System.Drawing.Color.MidnightBlue;
            viewDoctorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8679247F, System.Drawing.FontStyle.Bold);
            viewDoctorsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            viewDoctorsBtn.Location = new System.Drawing.Point(46, 65);
            viewDoctorsBtn.Margin = new System.Windows.Forms.Padding(4);
            viewDoctorsBtn.Name = "viewDoctorsBtn";
            viewDoctorsBtn.Size = new System.Drawing.Size(145, 72);
            viewDoctorsBtn.TabIndex = 1;
            viewDoctorsBtn.Text = "VIEW";
            viewDoctorsBtn.UseVisualStyleBackColor = false;
            viewDoctorsBtn.Click += button2_Click;
            // 
            // addDoctorBtn
            // 
            addDoctorBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            addDoctorBtn.BackColor = System.Drawing.Color.MidnightBlue;
            addDoctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8679247F, System.Drawing.FontStyle.Bold);
            addDoctorBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            addDoctorBtn.Location = new System.Drawing.Point(46, 160);
            addDoctorBtn.Margin = new System.Windows.Forms.Padding(4);
            addDoctorBtn.Name = "addDoctorBtn";
            addDoctorBtn.Size = new System.Drawing.Size(145, 72);
            addDoctorBtn.TabIndex = 0;
            addDoctorBtn.Text = "ADD";
            addDoctorBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FirstName, LastName, Specialization, Hospital });
            dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            dataGridView1.Location = new System.Drawing.Point(58, 207);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.Size = new System.Drawing.Size(481, 72);
            dataGridView1.TabIndex = 1;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 110;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "Last Name";
            LastName.HeaderText = "Column1";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 110;
            // 
            // Specialization
            // 
            Specialization.HeaderText = "Specialization";
            Specialization.MinimumWidth = 6;
            Specialization.Name = "Specialization";
            Specialization.Width = 110;
            // 
            // Hospital
            // 
            Hospital.HeaderText = "Hospital";
            Hospital.MinimumWidth = 6;
            Hospital.Name = "Hospital";
            Hospital.Width = 110;
            // 
            // DoctorFormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(983, 646);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxDoctors);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "DoctorFormAdmin";
            Text = "DoctorForm";
            groupBoxDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDoctors;
        private System.Windows.Forms.Button addDoctorBtn;
        private System.Windows.Forms.Button editDoctorBtn;
        private System.Windows.Forms.Button viewDoctorsBtn;
        private System.Windows.Forms.Button deleteDoctorBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hospital;
    }
}