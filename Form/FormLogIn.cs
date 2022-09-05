using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Hotel
{
    public partial class FormLogIn : Form
    {
        DbConnector db;
        int attempt = 0, timer1=1;

        public FormLogIn()
        {
            
             InitializeComponent();

            db = new DbConnector();
            attempt = 3;
           
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_btn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Close_btn, "Close");
        }

        private void Minimize_Btn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Minimize_Btn, "Minimize ") ;
        }

        private void ViewPass_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            if (attempt != 0)
            {
                bool check = db.IsValidNamePass(textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim());
                if (textBoxUserName.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all field");
                }
                else
                {

                    if (check)
                    {
                        this.Hide();
                        FormDashboard fd = new FormDashboard();
                        fd.Username = textBoxUserName.Text;
                        textBoxUserName.Clear();
                        textBoxPassword.Clear();
                        fd.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login or Password");
                        attempt--;
                    }
                }

            }
            else
            {
                textBoxUserName.Enabled = false;
                textBoxPassword.Enabled = false;
                MessageBox.Show("You entered the wrong password 3 times, please wait "+timer1*60+" seconds to try again");
                Thread.Sleep(60000*timer1);
                textBoxUserName.Enabled = true;
                textBoxPassword.Enabled = true;
                attempt = 3;
                timer1++;

            }
        }
    }
}
