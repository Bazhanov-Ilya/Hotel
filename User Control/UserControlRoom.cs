using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        DbConnector db;
        private string No = "", Free = "";
        public UserControlRoom()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex=0;
            textBoxPhoneNo.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            textBoxRoomPrice.Clear();
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }
        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            textBoxPhoneNo1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            textBoxRoomPrice1.Clear();
            No = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked == true)
                Free = "Yes";
            if (radioButtonNo.Checked == true)
                Free = "No";
            bool check;
            if (comboBoxType.SelectedIndex == 0 || textBoxPhoneNo.Text.Trim() == string.Empty || Free == "" || textBoxRoomPrice.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all fields");
            else
            {
                check = db.AddRoom(comboBoxType.SelectedItem.ToString(), textBoxPhoneNo.Text, Free, textBoxRoomPrice.Text);
                if (check)
                    Clear();
            }
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table", dataGridViewRoom);
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoomNo.Clear();
        }

        private void textBoxSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table WHERE Room_Number LIKE '%" + textBoxSearchRoomNo.Text + "%'", dataGridViewRoom);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (No != "")
            {
                if (radioButtonYes1.Checked == true)
                    Free = "Yes";
                if (radioButtonNo1.Checked == true)
                    Free = "No";
                if (comboBoxType1.SelectedIndex == 0 || textBoxPhoneNo1.Text.Trim() == string.Empty || Free == "" || textBoxRoomPrice1.Text.Trim() == string.Empty)
                    MessageBox.Show("Please fill out all fields");
                else
                {
                    check = db.UpdateRoom(No, comboBoxType1.SelectedItem.ToString(), textBoxPhoneNo1.Text, Free, textBoxRoomPrice1.Text);
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
            if (No != "")
            {
                if (comboBoxType1.SelectedIndex == 0 || textBoxPhoneNo1.Text.Trim() == string.Empty || Free == "")
                    MessageBox.Show("Please fill out all fields");
                else
                {

                    DialogResult result = MessageBox.Show("Are you want to Delete Room", "Delete Room", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteRoom(No);
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

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
        }

        private void textBoxPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;
            
        }

        private void textBoxSearchRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxPhoneNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPhoneNo1.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if (Free == "Yes")
                    radioButtonYes1.Checked = true;
                if (Free == "No")
                    radioButtonNo1.Checked = true;
                textBoxRoomPrice1.Text = row.Cells[4].Value.ToString();

            }
        }
 
    }
}
