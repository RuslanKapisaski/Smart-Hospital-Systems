using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {

            InitializeComponent();
            RenderHtmlInformation();
        }

        private async void RenderHtmlInformation()
        {
            await webView21.EnsureCoreWebView2Async(null);

            string htmlContent = @"
        <!DOCTYPE html>
        <html>
        <head>
            <meta charset='UTF-8'>
            <title>Software Systems</title>
            <style>
                body {
                    font-family: 'Segoe UI', sans-serif;
                    background-color: #f9f9f9;
                    color: #333;
                    padding: 40px;
                    line-height: 1.6;
                }
                h1 {
                    color: #2c3e50;
                }
                h2 {
                    color: #34495e;
                    margin-top: 30px;
                }
                p {
                    margin-bottom: 15px;
                }
                ul {
                    padding-left: 20px;
                }
                footer {
                    margin-top: 50px;
                    font-size: 0.9em;
                    color: #888;
                }
            </style>
        </head>
        <body>
    <h1>Hospital Management System</h1>

    <p>The Hospital Management System is a comprehensive software solution designed to streamline and organize essential hospital operations. It provides an integrated interface for managing patients, doctors, appointments, and billing processes efficiently and securely.</p>

    <h2>Key Modules</h2>

    <h3>1. Patient Management</h3>
    <p>This module allows hospital staff to register new patients, update personal and medical information, and keep track of patient histories. All data is securely stored and easily retrievable for consultations and future visits.</p>

    <h3>2. Doctor Directory</h3>
    <p>Doctors can be added and managed through this section, including their specialties, availability, and contact details. It supports scheduling and links directly with the appointment system for real-time availability tracking.</p>

    <h3>3. Appointment Scheduling</h3>
    <p>Patients can book appointments with doctors based on availability. The system prevents double-booking and sends confirmations to both patients and doctors. Appointments can be updated, canceled, or rescheduled through the interface.</p>

    <h3>4. Payment and Billing</h3>
    <p>This module helps administrators manage medical billing and payments. It supports invoice generation, payment tracking, and integration with insurance details if applicable. Patients can check outstanding balances and payment History.</p>

    <h2>System Benefits</h2>
    <ul>
        <li>Improved patient experience through faster registration and scheduling</li>
        <li>Better coordination between doctors and departments</li>
        <li>Secure data storage and access control</li>
        <li>Efficient billing and financial tracking</li>
        <li>Scalable design suitable for clinics, hospitals, or multi-branch systems</li>
    </ul>

    <footer>
        <p>Developed with care to improve hospital workflows and patient care.</p>
    </footer>
</body>
        </html>";

            webView21.NavigateToString(htmlContent);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }


    }
}
