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
    public partial class Main_SignUp : Form
    {
        public Main_SignUp()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Login obj = new Main_Login();
            obj.Show();
        }

        private void btn_SaveSignUp_Click(object sender, EventArgs e)
        {
            string CommandString;
            string ConnectingString;
            ConnectingString = "Data Source=DESKTOP-26JBM5S;Integrated Security=True";
            CommandString = "INSERT INTO Sing_Up VALUES('" + txtNfirst.Text + "','" + txtNlast.Text + "','" + txtUName.Text + "','" + txtUemail.Text + "','" + txtPassword.Text + "','" + txtCpassword.Text + "')";
            if (txtNfirst.Text != string.Empty || txtNlast.Text != string.Empty || txtUName.Text != string.Empty || txtUemail.Text != string.Empty || txtPassword.Text != string.Empty || txtCpassword.Text != string.Empty)
            {
                if (txtCpassword.Text == txtPassword.Text)
                {
                    SqlConnection conn = new SqlConnection(ConnectingString);
                    SqlCommand comm = new SqlCommand(CommandString, conn);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Your Registration Succesful");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter the Both Password Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Eomplete Every Column", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


            this.Hide();
            Main_Login obj = new Main_Login();
            obj.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
