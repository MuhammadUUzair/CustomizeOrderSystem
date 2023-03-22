using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomizeOrderSystem
{
    public partial class CustomizeOrderSystem : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7UC1JC\SQLEXPRESS;Initial Catalog=CustomizeOrderSystem;Integrated Security=True");
        static SqlCommand scmd;
        static int getid;
        public CustomizeOrderSystem()
        {
            InitializeComponent();
            display();
        } 

        private void btn_INSERT_Click(object sender, EventArgs e)
        {
            if (!authenticate())
            {
                MessageBox.Show("fill all the boxes");

                return;

            }
            con.Open();
            string query = "insert into SystemTable (OrderNo,OrderDetail) values(@OrderNo,@OrderDetail)";
            scmd = new SqlCommand(query, con);
            scmd.Parameters.AddWithValue("OrderNo", Convert.ToInt32(txt_OrderNo.Text));
            scmd.Parameters.AddWithValue("OrderDetail", txt_OrderDetail.Text);
            scmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record added sucessfully");
            display();

        }
        bool authenticate()
        {
            if (string.IsNullOrWhiteSpace(txt_OrderNo.Text) || (string.IsNullOrWhiteSpace(txt_OrderDetail.Text)))
                return false;

            else
                return true;

        }

        private void btn_SHOWDATA_Click(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            con.Open();
            string query = "select * from SystemTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dgv.DataSource = dt1;
            con.Close();
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from SystemTable where id=@getid";
            scmd = new SqlCommand(query, con);
            scmd.Parameters.AddWithValue("getid", getid);
            
            scmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record deleted sucessfully");
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getid = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["ID"].Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update SystemTable set OrderNo=@OrderNo,OrderDetail=@OrderDetail where id=@getid";
            scmd = new SqlCommand(query, con);
            scmd.Parameters.AddWithValue("OrderNo", Convert.ToInt32(txt_OrderNo.Text));
            scmd.Parameters.AddWithValue("OrderDetail", txt_OrderDetail.Text);
            scmd.Parameters.AddWithValue("getid", getid);

            con.Close();

            MessageBox.Show("Record updated sucessfully");
        }
    }
}
