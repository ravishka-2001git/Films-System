using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Films__FINAL_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin frm = new Admin();
            frm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            User frm = new User();
            frm.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_1 frm = new Payment_1();
            frm.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Login obj = new Main_Login();
            obj.Show();
        }
    }
}
