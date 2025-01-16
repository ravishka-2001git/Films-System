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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login obj = new Admin_login();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Location l = new Location();
            l.TopLevel = false;
            panelA2.Controls.Add(l);
            l.BringToFront();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Production_Admin PA = new Production_Admin();
            PA.TopLevel = false;
            panelA2.Controls.Add(PA);
            PA.BringToFront();
            PA.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Client_Registration C = new Client_Registration();
            C.TopLevel = false;
            panelA2.Controls.Add(C);
            C.BringToFront();
            C.Show();
        }

        private void btnA_Staff_Click(object sender, EventArgs e)
        {
            Staff S = new Staff();
            S.TopLevel = false;
            panelA2.Controls.Add(S);
            S.BringToFront();
            S.Show();
        }

        private void btnA_Properties_Click(object sender, EventArgs e)
        {
            Properties_1 Q = new Properties_1();
            Q.TopLevel = false;
            panelA2.Controls.Add(Q);
            Q.BringToFront();
            Q.Show();
        }

        private void btnA_Payment_Click(object sender, EventArgs e)
        {

        }

        private void btnA_UserAccess_Click(object sender, EventArgs e)
        {
            User_Access UA = new User_Access();
            UA.TopLevel = false;
            panelA2.Controls.Add(UA);
            UA.BringToFront();
            UA.Show();
        }
    }
}
