using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHAS
{
    public partial class PaymentForm : Form
    {
        float balance;
        float total;
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            total = OrderMenu.netTotal;
            lblTotal.Text = total.ToString();
            balance = LoginForm.Balance;
            lblWalletBalance.Text = balance.ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (rbCOD.Checked)
            {
                btnContinue.Enabled = true;
                MessageBox.Show("Thank you, Your Order will be delivered soon", "Success", MessageBoxButtons.OK);
                this.Close();
                CustomerHomeForm form = new CustomerHomeForm();
                form.Show();
            }
            else
            {
                if (total > balance && rbPay.Checked)
                {
                    btnContinue.Enabled = false;
                    errorProvider1.SetError(rbPay, "Insufficient Balance");
                }
                else
                {
                    if (txtPassword.Text == LoginForm.password)
                    {
                        btnContinue.Enabled = true;
                        balance = balance - total;
                        Operations op = new Operations();
                        op.UpdatePrice(balance, LoginForm.username, "balance", "customer", "username");
                        MessageBox.Show("Thank you, Your Order will be delivered soon", "Success", MessageBoxButtons.OK);
                        this.Close();
                        CustomerHomeForm form = new CustomerHomeForm();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void rbCOD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCOD.Checked)
            {
                panelShow.Visible = false;
            }
            else
            {
                panelShow.Visible = true;
                lblPassword.Text = "Enter your password to make payment";
            }
        }

       
    }
}
