using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            this.Load += AboutForm_Load;
        }


        public void AboutForm_Load(object sender, EventArgs e)
        {
           string htmlContent = @"
                <html>
                <head>
                    <style>
                        body {
                            font-family: Arial, sans-serif;
                            padding: 20px;
                            background-color: #f8f9fa;
                            color: #333;
                        }
                        h1 {
                            color: #2c3e50;
                        }
                        h2 {
                            margin-top: 30px;
                            color: #34495e;
                        }
                        ul {
                            margin-top: 10px;
                            padding-left: 20px;
                        }
                        li {
                            margin-bottom: 8px;
                        }
                    </style>
                </head>
                <body>
                    <h1>Hospital Management System</h1>
                    <p>This Hospital Management System is designed to efficiently handle all major hospital operations through an integrated database. It covers hospital administration, patient care, appointments, inventory, billing, and user management. Below is a breakdown of the system's core functionalities based on the relational schema.</p>

                    <h2>Benefits</h2>
                    <ul>
                        <li>Centralized patient and doctor data</li>
                        <li>Accurate appointment tracking</li>
                        <li>Real-time inventory updates</li>
                        <li>Reliable billing History</li>
                        <li>Role-based user authentication</li>
                        <li>Scalable structure supporting multi-hospital management</li>
                    </ul>
                </body>
                </html>";

            webBrowser2.DocumentText = htmlContent;
        }
    }

}
