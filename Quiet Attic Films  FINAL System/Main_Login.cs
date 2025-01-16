using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiet_Attic_Films__FINAL_System
{
    public partial class Main_Login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Quiet_Attic_Films_FINALConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public Main_Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_1 obj = new Start_1();
            obj.Show();
        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_SignUp frm = new Main_SignUp();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Sing_Up WHERE UserName='" + txtUName.Text + "' and Password='" + txtPassword.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                this.Hide();
                MessageBox.Show("welcom to Quiet Attic production company Page");
                Home frm = new Home();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login !!! Try Again", "password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Password.Checked == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }
    }
}
