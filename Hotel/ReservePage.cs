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

namespace Hotel
{
    public partial class ReservePage : Form
    {
        public ReservePage()
        {
            InitializeComponent();
        }

        private void labelphone_Click(object sender, EventArgs e)
        {

        }

        private void DoReserve_Click(object sender, EventArgs e)
        {
            // populate the datagridview
            try
            {
                string insertQuery = "INSERT INTO customer(id, name, num_of_days,room_num,phone) VALUES('" + id.Text + "','" + name.Text + "','" +days.Text+ "','" + Roomnum.Text + "','" + Phone.Text + "')";

                string mycon = @"server = localhost; database = hotel; uid = root; pwd = ; ";
                MySqlConnection connection = new MySqlConnection(mycon);

                connection.Open();
                MySqlCommand command;
                command = new MySqlCommand(insertQuery, connection);
                    
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
