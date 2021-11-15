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
    public partial class CustomerProfileUpdation : UserControl
    {
        public CustomerProfileUpdation()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Operations op = new Operations();
            op.UpdateUser(txtPassword.Text, txtAddress.Text);
            MessageBox.Show("Details Updated Succesfully");
            txtAddress.Text = txtPassword.Text = String.Empty;
        }
    }
}
