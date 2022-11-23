using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservations
{
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            comboBoxRoomsType.DataSource = room.roomTypeList();
            comboBoxRoomsType.DisplayMember = "label";
            comboBoxRoomsType.ValueMember = "category_id";

            dataGridView1.DataSource = room.getRooms();
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(comboBoxRoomsType.SelectedValue.ToString());
            string phone = textBoxPhoneNumber.Text;
            string free = "";

            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (radioButtonYes.Checked)
                {
                    free = "YES";
                }
                else if (radioButtonNo.Checked)
                {
                    free = "NO";
                }

                if (room.addRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Added successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTheFieldsButton_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            comboBoxRoomsType.SelectedIndex = 0;
            textBoxPhoneNumber.Text = "";
            radioButtonYes.Checked = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomsType.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            textBoxPhoneNumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            string free = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if(free.Equals("YES"))
            {
                radioButtonYes.Checked = true;
            }
            else if(free.Equals("NO"))
            {
                radioButtonNo.Checked = true;
            }
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(comboBoxRoomsType.SelectedValue.ToString());
            String phone = textBoxPhoneNumber.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (radioButtonYes.Checked)
                {
                    free = "YES";
                }
                else if (radioButtonNo.Checked)
                {
                    free = "NO";
                }

                if (room.editRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (room.removeRoom(number))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
