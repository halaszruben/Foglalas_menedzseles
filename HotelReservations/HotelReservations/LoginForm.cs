using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelReservations
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //If there is a password and username
            if (table.Rows.Count > 0) {
                this.Hide();
                MainMenuForm mform = new MainMenuForm();
                mform.Show();
            }
            else {
                if (textBoxUsername.Text.Trim().Equals("")) {
                    MessageBox.Show("Enter Your Username in order to login!",
                        "Username Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (textBoxPassword.Text.Trim().Equals("")) {
                    MessageBox.Show("Enter Your Password in order to login!",
                        "Password Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                } else {
                    MessageBox.Show("Wrong Username or Password!",
                        "Wrong Inputs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
