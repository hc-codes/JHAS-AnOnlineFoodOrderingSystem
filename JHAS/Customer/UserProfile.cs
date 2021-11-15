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
    public partial class UserProfile : UserControl
    {
        public UserProfile(DataSet res)
        {
            InitializeComponent();
            lblName.Text = res.Tables[0].Rows[0]["name"].ToString();
            lblPhone.Text = res.Tables[0].Rows[0]["phone"].ToString();
            lblBalance.Text = res.Tables[0].Rows[0]["balance"].ToString();
            lblAddress.Text = res.Tables[0].Rows[0]["address"].ToString();

        }
    }
}
