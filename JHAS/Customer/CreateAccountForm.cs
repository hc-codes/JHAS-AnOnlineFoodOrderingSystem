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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }
        Validator val = new Validator();
        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
                //txtPassword.Show();
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            string uName=txtUsername.Text;
            var res = val.CheckCredentials(uName);
            if (res.Tables[0].Rows.Count>0)
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.RetryCancel);
            }
            else
            {
                User user = new User();
                user.Name = txtName.Text;
                user.Password = txtPassword.Text;
                user.Username = txtUsername.Text;
                user.Address = txtAddress.Text;
                user.Phone = Int64.Parse(txtPhone.Text);
                Operations op = new Operations(user);
                op.SaveUser();
                MessageBox.Show("Account created succesfully", "Success");
                CreateAccountForm_Load(sender, e);

            }

        }

        private void lblGoback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string nameVal = val.Validate(txtName.Text);
            errorProvider1.SetError(txtName, nameVal);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string userVal = val.Validate(txtUsername.Text);
            errorProvider1.SetError(txtUsername, userVal);

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string passVal = val.Validate(txtPassword.Text);
            errorProvider1.SetError(txtPassword, passVal);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
            string phoneVal = val.Validate(txtPassword.Text);
            errorProvider1.SetError(txtPhone, phoneVal);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Both password should be same");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
            
        }

       
    }
}
