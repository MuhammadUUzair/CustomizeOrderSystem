using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomizeOrderSystem
{
    public partial class Registration_Form : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7UC1JC\SQLEXPRESS;Initial Catalog=CustomizeOrderSystem;Integrated Security=True");
        static SqlCommand scmd;
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Fill all the text box");
                return;
            }
            con.Open();
            string query = "insert into Users (FirstName,LastName,UserName,Password) values(@FirstName,@LastName,@UserName,@Password)";
            scmd = new SqlCommand(query, con);
            scmd.Parameters.AddWithValue("FirstName", txt_FirstName.Text);
            scmd.Parameters.AddWithValue("LastName", txt_LastName.Text);
            scmd.Parameters.AddWithValue("UserName", txt_UserName.Text);
            scmd.Parameters.AddWithValue("Password", txt_Password.Text);
            scmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered sucessfully");


        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form lf = new Login_Form();
            lf.ShowDialog();
            this.Close();

        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(txt_UserName.Text) ||
                string.IsNullOrWhiteSpace(txt_Password.Text) ||
                string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_LastName.Text)
                )
                return false;

            else
                return true;
        }
    }
}
