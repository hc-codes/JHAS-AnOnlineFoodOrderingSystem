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
    public partial class OrderMenu : Form
    {
        float tempTotal = 0;
        public static float netTotal = 0;
        public OrderMenu()
        {
            InitializeComponent();
        }
        private void cbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var obj = new Operations();
            string selectedItem = cbCategory.Text;
            var res = obj.SubCategory("Item", "Name", selectedItem, "Category");
            cbItem.DisplayMember = "Name";
            cbItem.DataSource = res.Tables["Name"];
        }
        private void OrderMenu_Load(object sender, EventArgs e)
        {
            var obj = new Operations();
            var res = obj.GetSingleItem("Item", "Category");
            cbCategory.DisplayMember = "Category";
            cbCategory.DataSource = res.Tables["Category"];
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = new Operations();
            string selectedItem = cbItem.Text;
            var res = obj.SubCategory("Item", "Price", selectedItem, "Name");
            var price = res.Tables[0].Rows[0]["Price"].ToString();
            txtPrice.Text = price;
            int quantity = int.Parse(nudQuantity.Value.ToString());
            txtTotal.Text = (float.Parse(price) * quantity).ToString();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            var obj = new Operations();
            string selectedItem = cbItem.Text;
            var res = obj.SubCategory("Item", "Price", selectedItem, "Name");
            var price = res.Tables[0].Rows[0]["Price"].ToString();
            txtPrice.Text = price;
            int quantity = int.Parse(nudQuantity.Value.ToString());
            txtTotal.Text = (float.Parse(price) * quantity).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool entered = false;
            foreach (ListViewItem item in lvItems.Items)
            {
                ListViewItem list = new ListViewItem();
                if (item.SubItems[0].Text == cbItem.Text)
                {
                    int quantity = int.Parse(nudQuantity.Value.ToString());
                    float price = float.Parse(item.SubItems[1].Text.ToString());
                    item.SubItems[1].Text = price.ToString();
                    quantity = quantity + int.Parse(item.SubItems[2].Text);
                    item.SubItems[2].Text = quantity.ToString();
                    item.SubItems[3].Text = (quantity * price).ToString();
                    //lvItems.Items.Add(item);
                    //  netTotal = int.Parse(item.SubItems[3].Text.ToString()); //50+100 +100
                    entered = true;
                    tempTotal += float.Parse(txtTotal.Text);
                }


            }
            if (!entered)
            {
                ListViewItem list = new ListViewItem(cbItem.Text);
                list.SubItems.Add(txtPrice.Text);
                list.SubItems.Add(nudQuantity.Value.ToString());
                float total = float.Parse(txtPrice.Text.ToString()) * int.Parse(nudQuantity.Value.ToString());
                list.SubItems.Add(total.ToString());
                lvItems.Items.Add(list);
                tempTotal += float.Parse(txtTotal.Text);
            }

            lblNetTotal.Text = tempTotal.ToString();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvItems.SelectedItems)
            {
                lvItems.Items.Remove(item);
                tempTotal -= float.Parse(item.SubItems[3].Text);
                lblNetTotal.Text = tempTotal.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lvItems.Items.Count == 0)
            {
                MessageBox.Show("No items Added", "Error", MessageBoxButtons.RetryCancel);
            }
            else if (MessageBox.Show("Are you sure to confirm order", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                netTotal = float.Parse(lblNetTotal.Text);
                Operations op = new Operations();
                foreach (ListViewItem item in lvItems.Items)
                {
                    Order obj = new Order();
                    obj.Name = item.SubItems[0].Text;
                    obj.Price = float.Parse(item.SubItems[1].Text);
                    obj.Quantity = int.Parse(item.SubItems[2].Text);
                    obj.Amount = float.Parse(item.SubItems[3].Text);
                    obj.Id = LoginForm.customerId;
                    op.SaveOrder(obj);
                    var res = op.SubCategory("Item", "Quantity", obj.Name, "Name");
                    var quantity = int.Parse(res.Tables[0].Rows[0]["Quantity"].ToString());
                    op.UpdateQuantity(quantity - obj.Quantity, obj.Name, "Quantity", "Item", "Name");
                }

                Bill bill = new Bill(lvItems);
                bill.Show();
                this.Hide();
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            this.Close();
        }
    }
}
