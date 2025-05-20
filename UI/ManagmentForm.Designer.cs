
namespace Hospital_System.UI
{
    partial class ManagmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagmentForm));
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.flowLayoutPanelAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDeveloper = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelDeveloper.SuspendLayout();
            this.SuspendLayout();
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // flowLayoutPanelAdmin
            // 
            this.flowLayoutPanelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAdmin.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelAdmin.Name = "flowLayoutPanelAdmin";
            this.flowLayoutPanelAdmin.Size = new System.Drawing.Size(633, 572);
            this.flowLayoutPanelAdmin.TabIndex = 0;
            // 
            // flowLayoutPanelDeveloper
            // 
            this.flowLayoutPanelDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelDeveloper.ColumnCount = 2;
            this.flowLayoutPanelDeveloper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowLayoutPanelDeveloper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowLayoutPanelDeveloper.Controls.Add(this.flowLayoutPanelAdmin, 0, 0);
            this.flowLayoutPanelDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDeveloper.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelDeveloper.Name = "flowLayoutPanelDeveloper";
            this.flowLayoutPanelDeveloper.RowCount = 1;
            this.flowLayoutPanelDeveloper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowLayoutPanelDeveloper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 578F));
            this.flowLayoutPanelDeveloper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 578F));
            this.flowLayoutPanelDeveloper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 578F));
            this.flowLayoutPanelDeveloper.Size = new System.Drawing.Size(1279, 578);
            this.flowLayoutPanelDeveloper.TabIndex = 0;
            this.flowLayoutPanelDeveloper.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelDeveloper_Paint);
            // 
            // ManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 578);
            this.Controls.Add(this.flowLayoutPanelDeveloper);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.Name = "ManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagmentForm";
            this.flowLayoutPanelDeveloper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Npgsql.NpgsqlCommand npgsqlCommand1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAdmin;
        public System.Windows.Forms.TableLayoutPanel flowLayoutPanelDeveloper;
    }
}