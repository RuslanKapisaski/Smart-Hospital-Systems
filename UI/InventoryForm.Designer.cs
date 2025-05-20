
namespace Hospital_System
{
    partial class InventoryForm
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
            this.addInventoryBtn = new System.Windows.Forms.Button();
            this.updateInventoryButton = new System.Windows.Forms.Button();
            this.removeInventoryButton = new System.Windows.Forms.Button();
            this.readInventoryButton = new System.Windows.Forms.Button();
            this.ServicesGroupBox = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ServicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addInventoryBtn
            // 
            this.addInventoryBtn.BackColor = System.Drawing.Color.Green;
            this.addInventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInventoryBtn.ForeColor = System.Drawing.Color.Ivory;
            this.addInventoryBtn.Location = new System.Drawing.Point(6, 54);
            this.addInventoryBtn.Name = "addInventoryBtn";
            this.addInventoryBtn.Size = new System.Drawing.Size(129, 59);
            this.addInventoryBtn.TabIndex = 1;
            this.addInventoryBtn.Text = "ADD";
            this.addInventoryBtn.UseVisualStyleBackColor = false;
            // 
            // updateInventoryButton
            // 
            this.updateInventoryButton.BackColor = System.Drawing.Color.Teal;
            this.updateInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateInventoryButton.ForeColor = System.Drawing.Color.Ivory;
            this.updateInventoryButton.Location = new System.Drawing.Point(6, 190);
            this.updateInventoryButton.Name = "updateInventoryButton";
            this.updateInventoryButton.Size = new System.Drawing.Size(129, 63);
            this.updateInventoryButton.TabIndex = 2;
            this.updateInventoryButton.Text = "UPDATE";
            this.updateInventoryButton.UseVisualStyleBackColor = false;
            // 
            // removeInventoryButton
            // 
            this.removeInventoryButton.BackColor = System.Drawing.Color.DarkRed;
            this.removeInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeInventoryButton.ForeColor = System.Drawing.Color.Ivory;
            this.removeInventoryButton.Location = new System.Drawing.Point(6, 119);
            this.removeInventoryButton.Name = "removeInventoryButton";
            this.removeInventoryButton.Size = new System.Drawing.Size(129, 65);
            this.removeInventoryButton.TabIndex = 3;
            this.removeInventoryButton.Text = "DELETE";
            this.removeInventoryButton.UseVisualStyleBackColor = false;
            // 
            // readInventoryButton
            // 
            this.readInventoryButton.BackColor = System.Drawing.Color.Purple;
            this.readInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readInventoryButton.ForeColor = System.Drawing.Color.Ivory;
            this.readInventoryButton.Location = new System.Drawing.Point(6, 259);
            this.readInventoryButton.Name = "readInventoryButton";
            this.readInventoryButton.Size = new System.Drawing.Size(129, 66);
            this.readInventoryButton.TabIndex = 4;
            this.readInventoryButton.Text = "READ";
            this.readInventoryButton.UseVisualStyleBackColor = false;
            // 
            // ServicesGroupBox
            // 
            this.ServicesGroupBox.Controls.Add(this.addInventoryBtn);
            this.ServicesGroupBox.Controls.Add(this.readInventoryButton);
            this.ServicesGroupBox.Controls.Add(this.removeInventoryButton);
            this.ServicesGroupBox.Controls.Add(this.updateInventoryButton);
            this.ServicesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesGroupBox.Location = new System.Drawing.Point(26, 55);
            this.ServicesGroupBox.Name = "ServicesGroupBox";
            this.ServicesGroupBox.Size = new System.Drawing.Size(191, 331);
            this.ServicesGroupBox.TabIndex = 5;
            this.ServicesGroupBox.TabStop = false;
            this.ServicesGroupBox.Text = "Services";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 504);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ServicesGroupBox);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.ServicesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addInventoryBtn;
        private System.Windows.Forms.Button updateInventoryButton;
        private System.Windows.Forms.Button removeInventoryButton;
        private System.Windows.Forms.Button readInventoryButton;
        private System.Windows.Forms.GroupBox ServicesGroupBox;
        private System.Windows.Forms.Splitter splitter1;
    }
}