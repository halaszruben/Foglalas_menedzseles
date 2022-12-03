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
    public partial class ManageReservationsForm : Form
    {
        public ManageReservationsForm()
        {
            InitializeComponent();
        }

        ROOM room= new ROOM();
        RESERVATION reservation= new RESERVATION();

        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            int type= Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            comboBoxRoomNumber.DataSource = room.roomByType(type);
            comboBoxRoomNumber.DisplayMember = "number";
            comboBoxRoomNumber.ValueMember = "number";

            dataGridView1.DataSource = reservation.getAllReserv();

        }

        private void clearTheFieldsButton_Click(object sender, EventArgs e)
        {
            textBoxReservId.Text = "";
            textBoxClientID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value= DateTime.Now;
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                comboBoxRoomNumber.DataSource = room.roomByType(type);
                comboBoxRoomNumber.DisplayMember = "number";
                comboBoxRoomNumber.ValueMember = "number";
            }
            catch(Exception)
            {
            }
            
        }

        private void buttonAddReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                if (DateTime.Compare(dateIn.Date,DateTime.Now.Date) < 0)
                {
                    MessageBox.Show("The Date In Must be < Or = then today", "Invalid Date in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(dateOut.Date, dateIn.Date) < 0)
                {
                    MessageBox.Show(dateOut.Day + " - " + dateIn.Day);
                    MessageBox.Show("The Date Out Must be < Or = then date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.addReservation(roomNumber, clientID, dateIn, dateOut))
                    {
                        room.setRoomFree(roomNumber,"No");
                        dataGridView1.DataSource = reservation.getAllReserv();
                        MessageBox.Show("New reservation added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation NOT added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        }

        private void buttonEditReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int reservID = Convert.ToInt32(textBoxReservId.Text);
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date In Must be < Or = then today", "Invalid Date in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The Date Out Must be < Or = then date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //reservId mi0784684201
                    if (reservation.editReserv(reservID, roomNumber, clientID, dateIn, dateOut))
                    {
                        room.setRoomFree(roomNumber,"No");
                        MessageBox.Show("Reservation data updated", "edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation NOT added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxReservId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            int roomId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            comboBoxRoomType.SelectedValue = room.getRoomType(roomId);
            comboBoxRoomNumber.SelectedValue = roomId;
            textBoxClientID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            dateTimePickerIN.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            dateTimePickerOUT.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);

        }

        private void buttonRemoveReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBoxReservId.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                if (reservation.removeReserv(reservId))
                {
                    dataGridView1.DataSource = reservation.getAllReserv();
                    room.setRoomFree(roomNumber, "Yes");
                    MessageBox.Show("Reservation Deleted", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Reservation Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
