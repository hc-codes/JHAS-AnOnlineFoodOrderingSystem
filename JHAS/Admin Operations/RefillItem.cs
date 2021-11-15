using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHAS
{
    public partial class RefillItem : UserControl
    {
        public RefillItem()
        {
            InitializeComponent();
            var obj = new Operations();
            var res = obj.GetSingleItem("Item", "Name");
            cbItems.DisplayMember = "Name";
            cbItems.DataSource = res.Tables["Name"];

        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            string selectedItem = cbItems.Text;
            var obj = new Operations();
            string quantity = nudQuantity.Value.ToString();
            obj.Update(int.Parse(quantity), selectedItem,"Quantity","Item","Name");
            MessageBox.Show("Updated Successfully", "Success");
            this.cbItems.Text = default;
            this.nudQuantity.Value = 1;
            
        }
    }
}
