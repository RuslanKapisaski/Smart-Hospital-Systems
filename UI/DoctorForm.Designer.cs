
namespace Hospital_System.UI
{
    partial class DoctorForm
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
            this.groupBoxDoctors = new System.Windows.Forms.GroupBox();
            this.addDoctorBtn = new System.Windows.Forms.Button();
            this.viewDoctorsBtn = new System.Windows.Forms.Button();
            this.editDoctorBtn = new System.Windows.Forms.Button();
            this.deleteDoctorBtn = new System.Windows.Forms.Button();
            this.groupBoxDoctors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDoctors
            // 
            this.groupBoxDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDoctors.Controls.Add(this.deleteDoctorBtn);
            this.groupBoxDoctors.Controls.Add(this.editDoctorBtn);
            this.groupBoxDoctors.Controls.Add(this.viewDoctorsBtn);
            this.groupBoxDoctors.Controls.Add(this.addDoctorBtn);
            this.groupBoxDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDoctors.Location = new System.Drawing.Point(629, 108);
            this.groupBoxDoctors.Name = "groupBoxDoctors";
            this.groupBoxDoctors.Size = new System.Drawing.Size(202, 374);
            this.groupBoxDoctors.TabIndex = 0;
            this.groupBoxDoctors.TabStop = false;
            this.groupBoxDoctors.Text = "Doctor Services";
            // 
            // addDoctorBtn
            // 
            this.addDoctorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDoctorBtn.Location = new System.Drawing.Point(39, 122);
            this.addDoctorBtn.Name = "addDoctorBtn";
            this.addDoctorBtn.Size = new System.Drawing.Size(124, 55);
            this.addDoctorBtn.TabIndex = 0;
            this.addDoctorBtn.Text = "ADD";
            this.addDoctorBtn.UseVisualStyleBackColor = true;
            // 
            // viewDoctorsBtn
            // 
            this.viewDoctorsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDoctorsBtn.Location = new System.Drawing.Point(39, 50);
            this.viewDoctorsBtn.Name = "viewDoctorsBtn";
            this.viewDoctorsBtn.Size = new System.Drawing.Size(124, 55);
            this.viewDoctorsBtn.TabIndex = 1;
            this.viewDoctorsBtn.Text = "VIEW";
            this.viewDoctorsBtn.UseVisualStyleBackColor = true;
            this.viewDoctorsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // editDoctorBtn
            // 
            this.editDoctorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editDoctorBtn.Location = new System.Drawing.Point(39, 196);
            this.editDoctorBtn.Name = "editDoctorBtn";
            this.editDoctorBtn.Size = new System.Drawing.Size(124, 55);
            this.editDoctorBtn.TabIndex = 2;
            this.editDoctorBtn.Text = "EDIT";
            this.editDoctorBtn.UseVisualStyleBackColor = true;
            // 
            // deleteDoctorBtn
            // 
            this.deleteDoctorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteDoctorBtn.Location = new System.Drawing.Point(39, 284);
            this.deleteDoctorBtn.Name = "deleteDoctorBtn";
            this.deleteDoctorBtn.Size = new System.Drawing.Size(124, 55);
            this.deleteDoctorBtn.TabIndex = 3;
            this.deleteDoctorBtn.Text = "DELETE";
            this.deleteDoctorBtn.UseVisualStyleBackColor = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 494);
            this.Controls.Add(this.groupBoxDoctors);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.groupBoxDoctors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDoctors;
        private System.Windows.Forms.Button addDoctorBtn;
        private System.Windows.Forms.Button editDoctorBtn;
        private System.Windows.Forms.Button viewDoctorsBtn;
        private System.Windows.Forms.Button deleteDoctorBtn;
    }
}