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
    public partial class UserControlSetting : UserControl
    {
        DbConnector db;
        private string ID = "", Admin;
        public UserControlSetting()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            tabControlUser.SelectedTab = tabPageAddUser;
        }
         public void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageUapdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked == true)
                Admin = "Yes";
            if (radioButtonNo.Checked == true)
                Admin = "No";
            bool check;
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty || Admin=="")
                MessageBox.Show("Please fill out all fields");
            else
            {
                check = db.AddUser(textBoxUsername.Text, textBoxPassword.Text,Admin);
                if (check)
                    Clear();
            }
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table", dataGridViewUser);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (radioButtonYes1.Checked == true)
                    Admin = "Yes";
                if (radioButtonNo1.Checked == true)
                    Admin = "No";
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty || Admin=="")
                    MessageBox.Show("Please fill out all fields");
                else
                {
                    check = db.UpdateUser(ID,textBoxUsername1.Text, textBoxPassword1.Text, Admin);
                    if (check)
                        Clear1();
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (radioButtonYes1.Checked == true)
                    Admin = "Yes";
                if (radioButtonNo1.Checked == true)
                    Admin = "No";
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty || Admin=="")
                    MessageBox.Show("Please fill out all fields");
                else
                {

                    DialogResult result = MessageBox.Show("Are you want to Delete User", "Delete User", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteUser(ID);
                        if (check)
                            Clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table");
            }
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                //textBoxPassword1.Text = row.Cells[2].Value.ToString();
                Admin = row.Cells[3].Value.ToString();
                if (Admin == "Yes")
                    radioButtonYes1.Checked = true;
                if (Admin == "No")
                    radioButtonNo1.Checked = true;
            }
        }

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table WHERE User_Name LIKE '%"+textBoxSearchUsername.Text+"%'", dataGridViewUser);
        }
    }
}
