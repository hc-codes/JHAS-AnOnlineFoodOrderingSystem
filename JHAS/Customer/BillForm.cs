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
    public partial class Bill : Form
    {
        ListView listView;
        public Bill(ListView lvItems)
        {
            InitializeComponent();
            listView = lvItems;
           
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.Items)
            {
                ListViewItem list = new ListViewItem(item.SubItems[0].Text);
                list.SubItems.Add(item.SubItems[1].Text);
                list.SubItems.Add(item.SubItems[2].Text);
                list.SubItems.Add(item.SubItems[3].Text);
                lvBill.Items.Add(list);

            }
            Operations op = new Operations();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
            var res=op.GetSingleItem("Orders", "Id");
            lblGrandTotal.Text = (OrderMenu.netTotal).ToString();
            Invoice invoice = new Invoice();
            invoice.Date = DateTime.Now.ToString("dd-mm-yyyy");
            invoice.Time = DateTime.Now.ToString("tt");
            invoice.Amount = OrderMenu.netTotal;
            invoice.CustomerId = LoginForm.customerId;
            invoice.OrderId = int.Parse(res.Tables[0].Rows[0]["Id"].ToString());
            op.SaveBill(invoice);

           
            lblBillNo.Text = res.Tables[0].Rows[0]["Id"].ToString();

        }

        private void lblHotelName_Click(object sender, EventArgs e)
        {

        }

        private void btnExitBill_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
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
                if (MessageBox.Show("Are you sure to proceed", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PaymentForm form = new PaymentForm();
                    this.Close();
                    form.Show();
                }
            }
        }
    }
}
