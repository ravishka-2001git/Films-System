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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void btnU_CR_Click(object sender, EventArgs e)
        {
            Client_Registration C = new Client_Registration();
            C.TopLevel = false;
            panel2.Controls.Add(C);
            C.BringToFront();
            C.Show();
        }

        private void btnU_production_Click(object sender, EventArgs e)
        {
            Production P = new Production();
            P.TopLevel = false;
            panel2.Controls.Add(P);
            P.BringToFront();
            P.Show();

        }
    }
}
