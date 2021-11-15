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
    public partial class ViewOrderForm : Form
    {
        public static int CustomerId;
        DataSet data;
        public ViewOrderForm(DataSet data)
        {
            InitializeComponent();
            this.data = data;

        }
        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvCustomer.SelectedItems)
            {
                CustomerId = int.Parse(item.SubItems[0].Text);
            }
            Operations op = new Operations();
            var data = op.GetItemList();
            dgvItems.Columns.Clear();
            dgvItems.DataSource = data.Tables[0];
        }
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvCustomer.SelectedItems)
            {
                CustomerId = int.Parse(item.SubItems[0].Text);
            }
            Operations op = new Operations();
            op.Deliver();
            if (MessageBox.Show("Food Delivery process started and will be delivered soon", "Success", MessageBoxButtons.OK) == DialogResult.OK)
            {
                AdminHome form = new AdminHome();
                form.Show();
                this.Close();
            }

        }
        private void TestForm_Load(object sender, EventArgs e)
        {

            CustomerId = int.Parse(data.Tables[0].Rows[0]["Id"].ToString());
            ListViewItem list = new ListViewItem(data.Tables[0].Rows[0]["Id"].ToString());
            list.SubItems.Add(data.Tables[0].Rows[0]["name"].ToString());
            list.SubItems.Add(data.Tables[0].Rows[0]["phone"].ToString());
            list.SubItems.Add(data.Tables[0].Rows[0]["address"].ToString());
            lvCustomer.Items.Add(list);

            for (int i = 1; i < data.Tables[0].Rows.Count; i++)
            {
                //if (lvCustomer.Items[i].SubItems[0].Text == data.Tables[0].Rows[i]["name"].ToString() && lvCustomer.Items.Count>0)
                //   continue;

                CustomerId = int.Parse(data.Tables[0].Rows[i]["Id"].ToString());
                list = new ListViewItem(data.Tables[0].Rows[i]["Id"].ToString());
                list.SubItems.Add(data.Tables[0].Rows[i]["name"].ToString());
                list.SubItems.Add(data.Tables[0].Rows[i]["phone"].ToString());
                list.SubItems.Add(data.Tables[0].Rows[i]["address"].ToString());
                lvCustomer.Items.Add(list);
            }
        }
    }

}
