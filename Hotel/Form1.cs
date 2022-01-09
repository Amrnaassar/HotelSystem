using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
            {
                Booking b = new Booking();
                b.Show();
                this.Hide();
                
                
            }
            else
            {
                MessageBox.Show("Enter valid Username or Password!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
