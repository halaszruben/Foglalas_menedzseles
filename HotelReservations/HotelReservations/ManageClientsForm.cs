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
    public partial class ManageClientsForm : Form
    {
        CLIENT client = new CLIENT();

        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void clearTheFieldsButton_Click(object sender, EventArgs e)
        {
            textBoxID.Text = ("");
            textBoxFirstName.Text = ("");
            textBoxLastName.Text = ("");
            textBoxPhoneNumber.Text = ("");
            textBoxCountry.Text = ("");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String phone = textBoxPhoneNumber.Text;
            String country = textBoxCountry.Text;

            if (fname.Trim().Equals("")) {
                MessageBox.Show("ERROR - Missing First Name!",
                        "Client Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (lname.Trim().Equals("")) {
                MessageBox.Show("ERROR - Missing Last Name!",
                        "Client Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (phone.Trim().Equals("")) {
                MessageBox.Show("ERROR - Missing phone number!",
                        "Client Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Boolean insertClient = client.insertClient(fname, lname, phone, country);

                if (insertClient)
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("The new Client has been inserted succesfully!",
                        "Client is Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Something went wrong inserting the Client!",
                        "Client is NOT Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id;
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String phone = textBoxPhoneNumber.Text;
            String country = textBoxCountry.Text;

            try {

                id = Convert.ToInt32(textBoxID.Text);

                if (fname.Trim().Equals(""))
                {
                    MessageBox.Show("ERROR - Missing First Name!",
                            "Client Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lname.Trim().Equals(""))
                {
                    MessageBox.Show("ERROR - Missing Last Name!",
                            "Client Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phone.Trim().Equals(""))
                {
                    MessageBox.Show("ERROR - Missing phone number!",
                            "Client Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean editClient = client.editClient(id, fname, lname, phone, country);

                    if (editClient)
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("The new Client informations have been updated succesfully!",
                            "Client is Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Something went wrong updating the Client informations!",
                            "Client is NOT Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ID-ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Displays the selected row from the datagridview to the textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPhoneNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxCountry.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try {
                int id = Convert.ToInt32(textBoxID.Text);

                if (client.removeClient(id)) {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("The Client has been removed succesfully!",
                        "Client is Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTheFieldsButton.PerformClick();
                }
                else {
                    MessageBox.Show("ERROR - Something went wrong when trying to remove the Client!",
                            "Client has NOT been Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ID-ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
