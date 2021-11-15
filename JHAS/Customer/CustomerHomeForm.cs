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
    public partial class CustomerHomeForm : Form
    {
        public CustomerHomeForm()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Hide();
            
        }

        private void btnMenuFood_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }
        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            panelCustomer.Controls.Clear();
            var control = new CustomerProfileUpdation();
            panelCustomer.Controls.Add(control);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible)
            {
                flowLayoutPanel1.Hide();
            }
            else
            {
                flowLayoutPanel1.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Operations op = new Operations();
            var res = op.CustomerData("customer");
            panelCustomer.Controls.Clear();
            var control = new UserProfile(res);
            panelCustomer.Controls.Add(control);
        }
    }
}
