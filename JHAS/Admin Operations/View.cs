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
    public partial class View : UserControl
    {
        public View(DataSet r,string title)
        {
            InitializeComponent();
            lblView.Text = title;
            dgvOrders.DataSource = r.Tables[0];
            //dgvOrders.Columns[0].HeaderText = "Customer Name";
            //dgvOrders.Columns[1].HeaderText = "Phone";
            //dgvOrders.Columns[2].HeaderText = "Address";
            //dgvOrders.Columns[3].HeaderText = "Item Name";
            

        }

    }
}
