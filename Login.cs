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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check
            Cashier cashier1 = new Cashier("Vince Lawrence Baraclan", "Engineering", "Snowdragon", "Vinice2004");


            if (cashier1.validateLogin(txtUsername.Text.Trim(), txtPassword.Text) == true)
            {
                this.Hide();
                frmDiscountedItem frmNewForm = new frmDiscountedItem();
                frmNewForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("INVALID INPUT\nTRY AGAIN","INVALID INPUT");
            }
        }
    }
}
