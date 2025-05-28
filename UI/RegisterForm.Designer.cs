namespace Hospital_System.UI

{
    using System.Windows.Forms;

    partial class RegisterForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            passInput = new MaskedTextBox();
            label5 = new Label();
            emailInput = new MaskedTextBox();
            label4 = new Label();
            label1 = new Label();
            repassInput = new MaskedTextBox();
            label3 = new Label();
            registerBtn = new Button();
            lNameInput = new MaskedTextBox();
            label2 = new Label();
            fNameInput = new MaskedTextBox();
            label6 = new Label();
            birthDatePicker = new DateTimePicker();
            label7 = new Label();
            SuspendLayout();
            // 
            // passInput
            // 
            passInput.Location = new System.Drawing.Point(307, 307);
            passInput.Margin = new Padding(4);
            passInput.Name = "passInput";
            passInput.Size = new System.Drawing.Size(344, 25);
            passInput.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            label5.Location = new System.Drawing.Point(222, 307);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 17);
            label5.TabIndex = 16;
            label5.Text = "Password:";
            // 
            // emailInput
            // 
            emailInput.Location = new System.Drawing.Point(307, 260);
            emailInput.Margin = new Padding(4);
            emailInput.Name = "emailInput";
            emailInput.Size = new System.Drawing.Size(344, 25);
            emailInput.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            label4.Location = new System.Drawing.Point(222, 260);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 17);
            label4.TabIndex = 14;
            label4.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            label1.Location = new System.Drawing.Point(319, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(241, 31);
            label1.TabIndex = 13;
            label1.Text = "Hospital Systems";
            // 
            // repassInput
            // 
            repassInput.Location = new System.Drawing.Point(307, 360);
            repassInput.Margin = new Padding(4);
            repassInput.Name = "repassInput";
            repassInput.Size = new System.Drawing.Size(344, 25);
            repassInput.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            label3.Location = new System.Drawing.Point(200, 360);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 17);
            label3.TabIndex = 21;
            label3.Text = "Re-password:";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            registerBtn.Location = new System.Drawing.Point(400, 488);
            registerBtn.Margin = new Padding(4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new System.Drawing.Size(160, 52);
            registerBtn.TabIndex = 23;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // lNameInput
            // 
            lNameInput.Location = new System.Drawing.Point(307, 211);
            lNameInput.Margin = new Padding(4);
            lNameInput.Name = "lNameInput";
            lNameInput.Size = new System.Drawing.Size(344, 25);
            lNameInput.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            label2.Location = new System.Drawing.Point(215, 214);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 17);
            label2.TabIndex = 24;
            label2.Text = "Last Name:";
            // 
            // fNameInput
            // 
            fNameInput.Location = new System.Drawing.Point(307, 162);
            fNameInput.Margin = new Padding(4);
            fNameInput.Name = "fNameInput";
            fNameInput.Size = new System.Drawing.Size(344, 25);
            fNameInput.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            label6.Location = new System.Drawing.Point(215, 162);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 17);
            label6.TabIndex = 26;
            label6.Text = "First Name:";
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new System.Drawing.Point(307, 424);
            birthDatePicker.Margin = new Padding(4);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new System.Drawing.Size(344, 25);
            birthDatePicker.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            label7.Location = new System.Drawing.Point(200, 432);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(72, 17);
            label7.TabIndex = 29;
            label7.Text = "Birth Date: ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AntiqueWhite;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(925, 550);
            Controls.Add(label7);
            Controls.Add(birthDatePicker);
            Controls.Add(fNameInput);
            Controls.Add(label6);
            Controls.Add(lNameInput);
            Controls.Add(label2);
            Controls.Add(registerBtn);
            Controls.Add(repassInput);
            Controls.Add(label3);
            Controls.Add(passInput);
            Controls.Add(label5);
            Controls.Add(emailInput);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "A";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        public MaskedTextBox passInput;
        public Label label5;
        public MaskedTextBox emailInput;
        public Label label4;
        public Label label1;
        public MaskedTextBox repassInput;
        public Label label3;
        public Button registerBtn;
        public MaskedTextBox lNameInput;
        public Label label2;
        public MaskedTextBox fNameInput;
        public Label label6;
        public DateTimePicker birthDatePicker;
        public Label label7;
    }
}