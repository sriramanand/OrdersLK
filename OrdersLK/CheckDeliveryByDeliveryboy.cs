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
    public partial class CheckDeliveryByDeliveryboy : Form
    {
        public CheckDeliveryByDeliveryboy()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckDeliveryByDeliveryboy_Load(object sender, EventArgs e)
        {
            string selectQuery = "select * from Delivery where Status = 'Processing'";
            Functions.loadTable(selectQuery, delDataGridView);
        }

        private void back_Click(object sender, EventArgs e)
        {
            DeliveryMain mainForm = new DeliveryMain();
            this.Hide();
            mainForm.Show();
        }
    }
}
