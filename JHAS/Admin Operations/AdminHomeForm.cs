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
    public partial class AdminHome : Form
    {
        string title = "";
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            Operations op = new Operations();
            var res = op.CustomerList("customer");
            if(res.Tables[0].Rows.Count>0)
            {
                ViewOrderForm form = new ViewOrderForm(res);
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("No Orders");
            //title = "ORDER LIST";
            //var obj = new Operations();
            //var r = obj.ViewOrders("Orders", "customer");
            //panelAdminHome.Controls.Clear();
            //var control = new View(r, title);
            //panelAdminHome.Controls.Add(control);

        }
        private void btnCollection_Click(object sender, EventArgs e)
        {

            var obj = new Operations();
            var r = obj.View("Bill");
            panelAdminHome.Controls.Clear();
            title = "Today's Collection";
            var control = new View(r, title);
            panelAdminHome.Controls.Add(control);
            //panelAdminHome.Controls.Clear();
            //var control = new AdminCollections();
            //panelAdminHome.Controls.Add(control);
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            var obj = new Operations();
            var r = obj.MenuView("Item");
            panelAdminHome.Controls.Clear();
            var control = new View(r,title);
            title = "MENU";
            panelAdminHome.Controls.Add(control);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();

        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            panelAdminHome.Controls.Clear();
            var control = new RefillItem();
            panelAdminHome.Controls.Add(control);
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            panelAdminHome.Controls.Clear();
            var control = new AddNewItems();
            panelAdminHome.Controls.Add(control);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panelAdminHome.Controls.Clear();
            var control = new UpdatePrice();
            panelAdminHome.Controls.Add(control);
        }
    }
}
