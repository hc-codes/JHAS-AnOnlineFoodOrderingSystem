using JHAS;
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
    public partial class LoginForm : Form
    {
        Validator val = new Validator();
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string username, password;
        public static int customerId;
        public static float Balance;
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

            string uVal = val.Validate(txtUsername.Text);
            if (txtUsername.Text != String.Empty)
            {
                if (txtPassword.Text != String.Empty)
                    btnSubmit.Enabled = true;
                lblUsernamePlaceholder.Visible = false;
                if (uVal != null)
                {
                    errorProvider1.SetError(txtUsername, uVal);
                    txtUsername.BackColor = Color.Yellow;
                }
                else
                {
                    txtUsername.BackColor = SystemColors.Window;
                    errorProvider1.SetError(txtUsername, null);
                }
            }
            else
            {
                errorProvider1.SetError(txtUsername, uVal);
                lblUsernamePlaceholder.Visible = true;
                btnSubmit.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string pVal = val.Validate(txtPassword.Text);
            if (txtPassword.Text != String.Empty)
            {
                if (txtUsername.Text != String.Empty)
                    btnSubmit.Enabled = true;
                lblPasswordPlaceholder.Visible = false;
                if (pVal != null)
                {
                    errorProvider1.SetError(txtPassword, pVal);
                    txtPassword.BackColor = Color.Yellow;
                }
                else
                {
                    txtPassword.BackColor = SystemColors.Window;
                    errorProvider1.SetError(txtPassword, null);
                }
            }
            else
            {
                errorProvider1.SetError(txtPassword, pVal);
                lblPasswordPlaceholder.Visible = true;
                btnSubmit.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var create = new CreateAccountForm();
            create.Show();
            this.Hide();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                //txtPassword.Show();
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;


            // Check for admin
            var res = val.CheckCredentials(username);
            if (username == "admin")
            {
                if (password == "admin")
                {
                    AdminHome form = new AdminHome();
                    this.Hide();
                    form.Show(this);
                    Hide();
                }
                else
                    MessageBox.Show("Wrong password");
            }
            else
            {
                //Check for correct login credentials
                if (res.Tables[0].Rows.Count > 0)
                {
                    if (res.Tables[0].Rows[0]["Password"].ToString() == password)
                    {
                        Balance = float.Parse(res.Tables[0].Rows[0]["balance"].ToString());
                        customerId = int.Parse(res.Tables[0].Rows[0]["Id"].ToString());
                        CustomerHomeForm form = new CustomerHomeForm();
                        form.Show(this);
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.RetryCancel);
                    }
                }
                else
                    MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.RetryCancel);
            }
           
        }
    }
}
