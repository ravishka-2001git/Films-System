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
    public partial class User_Access : Form
    {
        public User_Access()
        {
            InitializeComponent();
        }

        private void User_Access_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quiet_Attic_Films_FINALAddData.Sing_Up' table. You can move, or remove it, as needed.
            this.sing_UpTableAdapter.Fill(this.quiet_Attic_Films_FINALAddData.Sing_Up);

        }

        private void btnA_Save_Click(object sender, EventArgs e)
        {
            string CommandString;
            string ConnectingString;
            ConnectingString = "Data Source=LAPTOP-VP56FVLS\\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films_FINAL;Integrated Security=True";
            CommandString = "INSERT INTO Sing_Up VALUES('" + txt_ANfirst.Text + "','" + txt_ANlast.Text + "','" + txt_AUName.Text + "','" + txt_AUemail.Text + "','" + txt_APassword.Text + "','" + txt_ACpassword.Text + "')";
            if (txt_ANfirst.Text != string.Empty || txt_ANlast.Text != string.Empty || txt_AUName.Text != string.Empty || txt_AUemail.Text != string.Empty || txt_APassword.Text != string.Empty || txt_ACpassword.Text != string.Empty)
            {
                if (txt_ACpassword.Text == txt_APassword.Text)
                {
                    SqlConnection conn = new SqlConnection(ConnectingString);
                    SqlCommand comm = new SqlCommand(CommandString, conn);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                 
                }
            }
            else
            {
                
            }
        }

        private void btnA_Update_Click(object sender, EventArgs e)
        {
           
        }
    }
}
