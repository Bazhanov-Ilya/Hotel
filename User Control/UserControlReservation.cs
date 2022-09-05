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
    public partial class UserControlReservation : UserControl
    {
        DbConnector db;
        private string RID = "", No = "";
        private int Price;



        int change, days;
        public UserControlReservation()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            comboBoxRoomType.SelectedIndex = 0;
            comboBoxRoomNo.SelectedIndex = 0;
            comboBoxClientFN.SelectedIndex = 0;
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }
        private void Clear1()
        {
            comboBoxRoomType1.SelectedIndex = 0;
            comboBoxRoomNo1.SelectedIndex = 0;
            comboBoxClientFN1.SelectedIndex = 0;
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (comboBoxRoomType.SelectedIndex == 0 || comboBoxRoomNo.SelectedIndex == 0 || comboBoxClientFN.SelectedIndex == 0 || comboBoxClientLN.SelectedIndex == 0) 
                MessageBox.Show("Please fill out all fields");
            else
            {
                check = db.AddReservation(comboBoxRoomType.SelectedItem.ToString(), comboBoxRoomNo.SelectedItem.ToString(), comboBoxClientID.SelectedItem.ToString(), dateTimePickerIn.Value, dateTimePickerOut.Value, Price.ToString());
                db.UpdateReservationRoom(comboBoxRoomNo.SelectedItem.ToString(), "No");
                if (check)
                    Clear();
            }
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT  Reservation_Table.Reservation_ID, Reservation_Table.Reservation_Room_Type, Reservation_Table.Reservation_Room_Number, Client_Table.Client_FirstName, Client_Table.Client_LastName, Reservation_Table.Reservation_In, Reservation_Table.Reservation_Out, Reservation_Table.Reservation_Price FROM Client_Table INNER JOIN Reservation_Table ON Client_Table.Client_ID = Reservation_Table.Reservation_Client_ID", dataGridViewReservation);
        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoomNo.Clear();
        }

        private void textBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT  Reservation_Table.Reservation_ID, Reservation_Table.Reservation_Room_Type, Reservation_Table.Reservation_Room_Number, Client_Table.Client_FirstName, Client_Table.Client_LastName, Reservation_Table.Reservation_In, Reservation_Table.Reservation_Out FROM Client_Table INNER JOIN Reservation_Table ON Client_Table.Client_ID = Reservation_Table.Reservation_Client_ID WHERE Reservation_Room_Number LIKE '%" + textBoxSearchRoomNo.Text + "%'", dataGridViewReservation);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {
                if (comboBoxRoomType1.SelectedIndex == 0 ||comboBoxRoomNo1.SelectedIndex == 0)
                    MessageBox.Show("Please fill out all fields");
                else
                {
                    check = db.UpdateReservation(RID, comboBoxRoomType1.SelectedItem.ToString(), comboBoxRoomNo1.SelectedItem.ToString(), comboBoxClientID1.SelectedItem.ToString(), dateTimePickerIn1.Value, dateTimePickerOut1.Value);
                    db.UpdateReservationRoom(No, "Yes");
                    db.UpdateReservationRoom(comboBoxRoomNo1.SelectedItem.ToString(), "No");
                    if (check)
                        Clear1();
                }
            } 
            else
            {
                MessageBox.Show("Please first select row from table");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bool check, add;
            if (RID != "")
            {
                if (comboBoxRoomType1.SelectedIndex == 0 || comboBoxClientFN1.SelectedIndex == 0)
                    MessageBox.Show("Please fill out all fields");
                else
                {

                    DialogResult result = MessageBox.Show("Are you want to Cancel Reservation", "Cancel Reservation", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result)
                    {
                        add = db.AddHistory(comboBoxClientID1.Text);
                        check = db.DeleteReservation(RID);
                        db.UpdateReservationRoom(No, "Yes");
                        if (check && add)
                            Clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table");
            }
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.SelectedIndex = 0;
            comboBoxRoomNo.SelectedIndex = 0;
            comboBoxRoomType1.SelectedIndex = 0;
            comboBoxRoomNo1.SelectedIndex = 0;
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type ='" + comboBoxRoomType.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number",comboBoxRoomNo);
            //db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Number<>(SELECT  Reservation_Table.Reservation_Room_Number FROM Reservation_Table CROSS JOIN Room_Table WHERE (Reservation_Table.Reservation_Out > '" + dateTimePickerIn.Value.ToString() + "') OR (Reservation_Table.Reservation_In < '" + dateTimePickerOut.Value.ToString() + "'))", comboBoxRoomNo);                
        }

        private void comboBoxRoomType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type ='" + comboBoxRoomType1.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxRoomNo1);
        }

        private void tabPageUapdateAndCancelReservation_Enter(object sender, EventArgs e)
        {
            db.ClientFirstName("SELECT Client_FirstName FROM Client_Table", comboBoxClientFN1);
            labelPrice1.Text = Price.ToString();
            if (dateTimePickerIn1.Value < DateTime.Now)
            {
                dateTimePickerIn1.Enabled = false;
                change = 1;
            }
            else
            {
                dateTimePickerIn1.Enabled = true;
                change = 0;
            }
        }

       

        private void tabPageReservationHistory_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM History_Table", dataGridViewReservationHistory);
        }

        private void textBoxRoomNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM History_Table WHERE Reservation_Room_Number LIKE '%" + textBoxRoomNo.Text + "%'", dataGridViewReservationHistory);
        }

        private void textBoxSearchClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void dateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePickerOut.Value < dateTimePickerIn.Value)
            {
                dateTimePickerOut.Value = DateTime.Now;
                MessageBox.Show("Check-out date cannot be less than the check-in date\n", "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            comboBoxRoomNo.SelectedIndex = 0;
            labelPrice.Text = "0";
        }

        private void dateTimePickerOut1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerOut1.Value < DateTime.Now)
            {
                dateTimePickerOut1.Value = DateTime.Now;
                MessageBox.Show("Check-out date cannot be less than the now date\n", "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            comboBoxRoomNo1.SelectedIndex = 0;
            labelPrice1.Text = "0";
        }

        private void dateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerIn.Value < DateTime.Now)
            {
                dateTimePickerIn.Value = DateTime.Now;
                MessageBox.Show("Check-in date cannot be less than the now date\n", "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            comboBoxRoomNo.SelectedIndex = 0;
            labelPrice.Text = "0";

        }

        private void comboBoxClientFN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Client_LastName FROM Client_Table WHERE Client_FirstName ='" + comboBoxClientFN1.SelectedItem.ToString() + "' ", comboBoxClientLN1);
        }

        private void comboBoxClientFN_SelectedIndexChanged(object sender, EventArgs e)
        {
                db.RoomTypeAndNo("SELECT Client_LastName FROM Client_Table WHERE Client_FirstName ='" + comboBoxClientFN.SelectedItem.ToString() + "' ", comboBoxClientLN);
        }

        private void tabPageAddReservation_Enter(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Client_FirstName FROM Client_Table", comboBoxClientFN);
        }

        private void comboBoxClientLN_SelectedValueChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Client_ID FROM Client_Table WHERE Client_FirstName ='" + comboBoxClientFN.SelectedItem.ToString() + "' AND Client_LastName ='" + comboBoxClientLN.SelectedItem.ToString() + "' ", comboBoxClientID);
        }

        private void comboBoxClientLN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Client_ID FROM Client_Table WHERE Client_FirstName ='" + comboBoxClientFN1.SelectedItem.ToString() + "' AND Client_LastName ='" + comboBoxClientLN1.SelectedItem.ToString() + "' ", comboBoxClientID1);

        }

      
    

        private void dateTimePickerIn1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerIn1.Value < DateTime.Now && change == 1)
            {
                dateTimePickerIn1.Value =DateTime.Now;
                MessageBox.Show("Check-in date cannot be less than the now date\n", "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void comboBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan interval = dateTimePickerOut.Value.Subtract(dateTimePickerIn.Value);
            days = (int)interval.TotalDays;
           
            Price = db.ReceivePrice("SELECT Room_Price FROM Room_Table WHERE Room_Number = '"+ comboBoxRoomNo.SelectedItem.ToString()+ "'", days);
            labelPrice.Text = Price.ToString();
        }

        private void comboBoxRoomNo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan interval = dateTimePickerOut1.Value.Subtract(dateTimePickerIn1.Value);
            days = (int)interval.TotalDays;

            Price = db.ReceivePrice("SELECT Room_Price FROM Room_Table WHERE Room_Number = '" + comboBoxRoomNo1.SelectedItem.ToString() + "'", days);
            labelPrice1.Text = Price.ToString();
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                comboBoxRoomType1.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[2].Value.ToString();
                comboBoxClientFN1.SelectedItem = row.Cells[3].Value.ToString();
                comboBoxClientLN1.SelectedItem = row.Cells[4].Value.ToString();
                dateTimePickerIn1.Text = row.Cells[5].Value.ToString();
                dateTimePickerOut1.Text = row.Cells[6].Value.ToString();
                Price = (int)row.Cells[7].Value;

            }
        }

    }
}

