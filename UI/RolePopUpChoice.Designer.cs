namespace Hospital_System.UI
{
    partial class RolePopUpChoice
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
            System.Windows.Forms.GroupBox groupBoxChoiceRole;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolePopUpChoice));
            label1 = new System.Windows.Forms.Label();
            radioBtnDoctor = new System.Windows.Forms.RadioButton();
            radioBtnPatient = new System.Windows.Forms.RadioButton();
            groupBoxChoiceRole = new System.Windows.Forms.GroupBox();
            groupBoxChoiceRole.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxChoiceRole
            // 
            groupBoxChoiceRole.BackColor = System.Drawing.Color.Transparent;
            groupBoxChoiceRole.Controls.Add(label1);
            groupBoxChoiceRole.Controls.Add(radioBtnDoctor);
            groupBoxChoiceRole.Controls.Add(radioBtnPatient);
            groupBoxChoiceRole.Font = new System.Drawing.Font("Segoe UI", 10.8679247F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            groupBoxChoiceRole.ForeColor = System.Drawing.Color.Black;
            groupBoxChoiceRole.Location = new System.Drawing.Point(75, 99);
            groupBoxChoiceRole.Name = "groupBoxChoiceRole";
            groupBoxChoiceRole.Size = new System.Drawing.Size(318, 263);
            groupBoxChoiceRole.TabIndex = 0;
            groupBoxChoiceRole.TabStop = false;
            groupBoxChoiceRole.Text = "Role Request";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.150944F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 204);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(143, 223);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 17);
            label1.TabIndex = 2;
            label1.Text = "Please, select your role.";
            // 
            // radioBtnDoctor
            // 
            radioBtnDoctor.AutoSize = true;
            radioBtnDoctor.Location = new System.Drawing.Point(25, 160);
            radioBtnDoctor.Name = "radioBtnDoctor";
            radioBtnDoctor.Size = new System.Drawing.Size(80, 25);
            radioBtnDoctor.TabIndex = 1;
            radioBtnDoctor.TabStop = false;//
            radioBtnDoctor.Checked = false;//
            radioBtnDoctor.Text = "Doctor";
            radioBtnDoctor.UseVisualStyleBackColor = true;
            radioBtnDoctor.Click += radioBtnDoctor_Click;
            // 
            // radioBtnPatient
            // 
            radioBtnPatient.AutoSize = true;
            radioBtnPatient.Location = new System.Drawing.Point(25, 86);
            radioBtnPatient.Name = "radioBtnPatient";
            radioBtnPatient.Size = new System.Drawing.Size(83, 25);
            radioBtnPatient.TabIndex = 0;
            radioBtnPatient.TabStop = false;//
            radioBtnPatient.Text = "Patient";
            radioBtnDoctor.Checked = false; //
            radioBtnPatient.UseVisualStyleBackColor = true;
            radioBtnPatient.Click += radioBtnPatient_Click;
            // 
            // RolePopUpChoice
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBoxChoiceRole);
            ForeColor = System.Drawing.Color.Ivory;
            Name = "RolePopUpChoice";
            Text = "RolePopUpChoice";
            groupBoxChoiceRole.ResumeLayout(false);
            groupBoxChoiceRole.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnDoctor;
        private System.Windows.Forms.RadioButton radioBtnPatient;
        private System.Windows.Forms.Label label1;
    }
}