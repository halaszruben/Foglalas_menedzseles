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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void manageClientsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxNumber.Text);
            int type = Convert.ToInt32(comboBoxRoomsType.SelectedValue.ToString());
            string phone = textBoxNumber.Text;

            if (room.addRoom(number, type, phone, "Yes"))
            {
                dataGridView1.DataSource = room.getRooms();
                MessageBox.Show("Room Added successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearTheFieldsButton_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            comboBoxRoomsType.SelectedIndex = 0;
            textBoxPhoneNumber.Text = "";
        }
    }
}
