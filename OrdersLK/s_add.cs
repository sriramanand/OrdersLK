

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
    public partial class s_add : Form
    {
        private string tempPID;
        private double tempTotal;
        private string tempUnitPrice;
        private string tempItem;
        private DateTime tempDate;
        private double count = 0;
        private string tempBuyerId;
        private string tempMail;
        private string tempAgent;
        private string tempOrderId;
        private string tempAvailable;
        private int tempAvailableInt;

        private string tempCost;
        private double tempCostTotal;
        private double unitCount = 0;

        public s_add()
        {
            InitializeComponent();
        }

        private void s_add_Load(object sender, EventArgs e)
        {
            this.tempDate = DateTime.Now;
            lblDate.Text = this.tempDate.ToShortDateString();
            Functions.LoadComboBoxes("SELECT * FROM Product", comboItems, "ProductName");
            Functions.LoadComboBoxes("SELECT * FROM Customer", comboCustomerName, "CustomerName");
            Functions.LoadComboBoxes("SELECT * FROM Employee", comboAgent, "FirstName");
            txtInvoiceNo.Text = this.tempOrderId = Functions.getNextID("OrderId", "Orders", "ORD");
            lblQuantityTotal.Text = "Rs. 0.00";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice3 = null;
            choice3 = comboAgent.Text;

            this.tempAgent = Functions.getValue("Employee", "FirstName", choice3, "EmpId");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice2 = null;
            choice2 = comboCustomerName.Text;

            this.tempBuyerId = Functions.getValue("Customer", "CustomerName", choice2, "CustomerId");
            this.tempMail = Functions.getValue("Customer", "CustomerName", choice2, "Email");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.ResetText();

            string choice = null;
            choice = comboItems.Text;
            this.tempItem = choice;

            txtMRP.Text = this.tempUnitPrice = Functions.getValue("Product", "ProductName", choice, "SellingPrice");
            this.tempCost = Functions.getValue("Product", "ProductName", choice, "UnitPrice");
            txtAvailable.Text = this.tempAvailable = Functions.getValue("Product", "ProductName", choice, "QuantityAvailable");
            this.tempAvailableInt = Int32.Parse(this.tempAvailable);
            this.tempPID = Functions.getValue("Product", "ProductName", choice, "ProductId");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string qty = (txtQuantity.Text);

            if (String.IsNullOrEmpty(qty))
            {
                lblQuantityTotal.Text = "Rs. 0.00";
            }
            else
            {
                int qtyInt = 0;
                bool yes = int.TryParse(qty, out qtyInt);

                if (yes)
                {
                    double unitCost = Double.Parse(txtMRP.Text);
                    this.tempTotal = unitCost * (Int32.Parse(qty));
                    lblQuantityTotal.Text = string.Concat("Rs. ", tempTotal.ToString(), ".00");

                    double buyingCost = Double.Parse(this.tempCost);
                    this.tempCostTotal = buyingCost * (Int32.Parse(qty));
                }
                else
                {
                    MessageBox.Show(this, "Invalid input", "Enter valid quantity amount");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mailOrder = null, orderQuery, orderItemQuery;
            float totalBill = float.Parse(txtGrandTotal.Text);
            double totalCost = this.unitCount;
            try
            {
                if (!string.IsNullOrEmpty(txtInvoiceNo.Text) ||
                    !string.IsNullOrEmpty(this.tempBuyerId) ||
                    cartTable.Rows.Count != 0 ||
                    !string.IsNullOrEmpty(this.tempAgent))
                {

                    orderQuery = "INSERT INTO Orders (OrderId, OrderDate, OrderStatus, PaymentStatus, CustomerId, EmpId, TotalAmount, CostOfAmount) VALUES ("

                   + "'" + this.tempOrderId + "', "
                   + "'" + this.tempDate + "', "
                   + "'Confirmed', "
                   + "'Pending',"
                   + "'" + this.tempBuyerId + "', "
                   + "'" + this.tempAgent + "', "
                   + totalBill + ","
                   + totalCost + ")";

                    Functions.ExecuteQuery(orderQuery);


                    for (int i = 0; i < cartTable.Rows.Count - 1; i++)
                    {
                        string _orderItemId = Functions.getNextID("OrderItemId", "OrderItem", "OIT");
                        orderItemQuery = "INSERT INTO OrderItem (OrderItemId, OrderId, ProductId, Quantity) VALUES ("
                            + "'" + _orderItemId + "',"
                            + "'" + this.tempOrderId + "',"
                            + "'" + cartTable.Rows[i].Cells[0].Value.ToString() + "',"
                            + cartTable.Rows[i].Cells[3].Value + ")";

                        string _productAlter = "UPDATE Product SET QuantityAvailable = '"
                            + (this.tempAvailableInt - Int32.Parse(cartTable.Rows[i].Cells[3].Value.ToString()))
                            + "' WHERE ProductId = '" + cartTable.Rows[i].Cells[0].Value.ToString() + "'";

                        Functions.ExecuteQuery(orderItemQuery);
                        Functions.ExecuteQuery(_productAlter);

                        mailOrder += ""
                            + cartTable.Rows[i].Cells[0].Value 
                            + " - " + cartTable.Rows[i].Cells[1].Value 
                            + " (" + cartTable.Rows[i].Cells[3].Value 
                            + ") =" + cartTable.Rows[i].Cells[4].Value 
                            + " \n";

                    }

                    MessageBox.Show(this, "Order has been placed.\nPlease wait the mail is being processed...");

                    if (!String.IsNullOrEmpty(this.tempMail))
                    {
                        try
                        {
                            mailOrder += "------------------------------------------ \n"
                                + "Grand total = " + this.count + "\n";

                            emailThis mail = new emailThis();
                            mail.sendMail(this.tempMail, mailOrder);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Error", "Mail has not been sent.\nReason: " + ex);
                        }
                    }
                }

                else
                {
                    MessageBox.Show(this, "Invalid inputs", "Please recheck your entry");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error", "Invoice duplicating is not allowed\n" + ex);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in cartTable.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    this.count = this.count - Double.Parse(row.Cells[4].Value.ToString());
                    cartTable.Rows.Remove(row);
                    txtGrandTotal.Text = string.Concat(this.count.ToString(), ".00");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "0" || String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show(this, "Error", "Select quantity");
            }

            else if (Int32.Parse(txtQuantity.Text) > this.tempAvailableInt)
            {
                MessageBox.Show(this, "Enter a valid quantity");
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)cartTable.Rows[0].Clone();
                row.Cells[0].Value = this.tempPID;
                row.Cells[1].Value = this.tempItem;
                row.Cells[2].Value = this.tempUnitPrice;
                row.Cells[3].Value = txtQuantity.Text;
                row.Cells[4].Value = this.tempTotal;
                cartTable.Rows.Add(row);

                this.count = this.count + this.tempTotal;
                this.unitCount = this.unitCount + this.tempCostTotal;
                txtGrandTotal.Text = string.Concat(this.count.ToString(), ".00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b_add ba = new b_add();
            ba.ShowDialog();
            Functions.LoadComboBoxes("SELECT * FROM Customer", comboCustomerName, "CustomerName");
            comboCustomerName.SelectedIndex = comboCustomerName.FindString(ba.customerObj);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
