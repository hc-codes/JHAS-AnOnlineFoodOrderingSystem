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
    public partial class AddNewItems : UserControl
    {
        public AddNewItems()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item obj = new Item();
            Operations op = new Operations();
            obj.Name = txtItemName.Text;
            obj.Category = txtItemCat.Text;
            obj.Price = int.Parse(txtItemPrice.Text);
            obj.Quantity = int.Parse(txtItemQty.Text);
            op.AddItem(obj);
            MessageBox.Show("Item inserted successfully", "Success");
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }
            }
        }
    }
}
