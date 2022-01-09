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
    public partial class PricePage : Form
    {
        public PricePage()
        {
            InitializeComponent();
        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void BoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoPrice_Click(object sender, EventArgs e)
        {
            string mycon = @"server = localhost; database = hotel; uid = root; pwd = ; ";


            MySqlConnection connection = new MySqlConnection(mycon);
            connection.Open();

            string select = "SELECT * FROM room WHERE room_num = " + (BoxPrice.Text);
            MySqlCommand command = new MySqlCommand(select, connection);
            MySqlDataReader mdr;
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show(mdr.GetDouble("price").ToString());
                
            }
            else
            {
                MessageBox.Show("User Not Found");
            }
            BoxPrice.Text = "";
        }
    }
}
