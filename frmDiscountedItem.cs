using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace PracticeExam
{
    public partial class frmDiscountedItem : Form
    {
        public frmDiscountedItem()
        {
            InitializeComponent();
        }

        public int catchInts(string number)
        {
            int d;
            if(false==int.TryParse(number, out d))
            {
                MessageBox.Show("Please input a valid integer", "Invalid Input");
                return d = 0;
            }
            return d;
        }

        public double catchDouble(string number)
        {
            
            double n;
            if(false==double.TryParse(number, out n))
            {
                MessageBox.Show("Please input a valid integer", "Invalid Input");
                return n = 0;
            }
            return n;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {            
            string item;
            int discount, quantity;
            double price, totalAmount, change;
            bool inputCheck;

            if(txtDiscount.Text==""||txtItemName.Text==""
                || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please create an input", "No Input");
                inputCheck = false;
            }
            else { inputCheck = true; }

            if (inputCheck==true)
            {
                item = txtItemName.Text;
                for (int i = 0; i < item.Length; i++)
                {
                    char c = item[i];
                    if (char.IsDigit(c) == true)
                    {
                        MessageBox.Show("Please input without numbers", "Invalid Item");
                        break;
                    }
                }

                discount = catchInts(txtDiscount.Text);
                quantity = catchInts(txtQuantity.Text);
                price = catchDouble(txtPrice.Text);
                

                discount = discount / 100;

                totalAmount = (price*(1-price*discount))*quantity;

                lblNoTotal.Text = Convert.ToString(totalAmount);               

            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double payment, totalAmount,change;

            totalAmount = Convert.ToDouble(lblNoTotal.Text);

            payment = catchDouble(txtPayment.Text);
            change = payment - totalAmount;
            lblNoChange.Text = Convert.ToString(Math.Round(change,1));
        }
    }
}
