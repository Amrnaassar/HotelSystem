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
    public partial class ShowRoomPage : Form
    {
        public ShowRoomPage()
        {
            InitializeComponent();
        }

        private void LabelAllRoom_Click(object sender, EventArgs e)
        {

        }

        private void ShowRooms_Click(object sender, EventArgs e)
        {
            try
            {
                string mycon = @"server = localhost; database = hotel; uid = root; pwd = ; ";


                MySqlConnection connection = new MySqlConnection(mycon);
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM hotel.room", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "room");
                dataGridView1.DataSource = ds.Tables["room"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
