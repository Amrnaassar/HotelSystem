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
    public partial class CancelPage : Form
    {
        public CancelPage()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelPage_Load(object sender, EventArgs e)
        {

        }

        private void DoCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string mycon = @"server = localhost; database = hotel; uid = root; pwd = ; ";
                string del = "DELETE FROM hotel.customer WHERE id = " + BoxCancel.Text;
                MySqlConnection connection = new MySqlConnection(mycon);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(del, connection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("User not deleted");


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BoxCancel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
