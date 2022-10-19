using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelReservations
{
    //This is where the connection will happen between the DB and our APP
    internal class CONNECT
    {
        private MySqlConnection conncetion = new MySqlConnection("" +
            "datasource=localhost;port=3306;username=root;password=;database=HotelReservationsDB;");

        public MySqlConnection getConnection(){
            return conncetion;
        }

        public void openConnection() { 
            if(conncetion.State == ConnectionState.Closed)
                conncetion.Open();
        }

        public void closeConnection() {
            if (conncetion.State == ConnectionState.Open)
                conncetion.Close();
        }
    }
}
