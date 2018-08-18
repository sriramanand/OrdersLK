using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersLK
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
            //if (usernamebox.Text.ToLower() == "adil" && passwordbox.Text == "12345678")
            //{
            //    Home home = new Home();
            //    this.Hide();
            //    home.Show();
            //}
            //else
            //    MessageBox.Show("Invalid Credential");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
