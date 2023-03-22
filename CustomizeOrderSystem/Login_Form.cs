using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomizeOrderSystem
{
    public partial class Login_Form : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7UC1JC\SQLEXPRESS;Initial Catalog=CustomizeOrderSystem;Integrated Security=True");
        static SqlCommand scmd;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_Form rf = new Registration_Form();
            rf.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Fill all the text box");
                return;
            }
            con.Open();
            string query = "select Count(*) from Users where UserName=@UserName and Password=@Password";
            scmd = new SqlCommand(query, con);
            scmd.Parameters.AddWithValue("UserName", txt_UserName.Text);
            scmd.Parameters.AddWithValue("Password", txt_Password.Text);
            int rowcount = Convert.ToInt32(scmd.ExecuteScalar());
            con.Close();
            if (rowcount >0)
            {
                MessageBox.Show("WELCOME");
                this.Hide();
                CustomizeOrderSystem cos = new CustomizeOrderSystem();
                cos.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("invalid!");
            }

            bool Authenticate()
            {
                if (string.IsNullOrWhiteSpace(txt_UserName.Text) ||
                    string.IsNullOrWhiteSpace(txt_Password.Text) 
                   
                    )
                    return false;

                else
                    return true;
            }
        }
    }
}
