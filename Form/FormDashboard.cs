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

namespace Hotel
{
    public partial class FormDashboard : Form
    {
        public string Username;
        DbConnector db;
        public FormDashboard()
        {
            InitializeComponent();
            db = new DbConnector();

        }
       
        private void MovePanel(Control btn)
        {
            panelSlider.Top = btn.Top;
            panelSlider.Height = btn.Height;
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Log Out", "Log Out", MessageBoxButtons.YesNo);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
                FormLogIn fl = new FormLogIn();
                fl.Show();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUserName.Text = Username;
            userControlDashboard1.Show();
            if (!db.IsAdmin(Username))
            {
                buttonSetting.Hide();
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Show();


        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlSetting1.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
        }
         
        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Show();
            userControlRoom1.Clear();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();


        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Clear();
            userControlReservation1.Show();
            userControlDashboard1.Hide();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            userControlClient1.Hide();
            MovePanel(buttonSetting);
            userControlSetting1.Clear();
            userControlSetting1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
