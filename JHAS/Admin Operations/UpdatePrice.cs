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
    public partial class UpdatePrice : UserControl
    {
        public UpdatePrice()
        {
            InitializeComponent();
            var obj = new Operations();
            var res = obj.GetSingleItem("Item", "Name");
            cbItems.DisplayMember = "Name";
            cbItems.DataSource = res.Tables["Name"];
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            string selectedItem = cbItems.Text;
            var obj = new Operations();
            obj.UpdatePrice(float.Parse(txtUpdatePrice.Text), selectedItem, "Price", "Item", "Name");
            MessageBox.Show("Updated Successfully", "Success");
            this.cbItems.Text = default;
            txtUpdatePrice.Text = String.Empty;
        }
    }
}
