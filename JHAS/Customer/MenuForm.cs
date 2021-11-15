
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            var obj = new Operations();
            var r = obj.MenuForUser("Item");
            dgvMenu.DataSource = r.Tables[0];
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OrderMenu menu = new OrderMenu();
            menu.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerHomeForm form = new CustomerHomeForm();
            form.Show();
            this.Close();
        }
    }
}
