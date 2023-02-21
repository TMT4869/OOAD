using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADProject.ChildForms
{
    public partial class FormChangePassword : Form
    {
        string query = "", connectionString = @"Data Source = LAPHAO\TIEUMANTHAU; Initial Catalog = QLNS; User ID = sa; Password = 15122001";

        public FormChangePassword()
        {
            InitializeComponent();
        }

        private bool checkPW()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            query = "SELECT * FROM taiKhoan where taiKhoan='" + ClassAccount.username + "' and matKhau='" + tbOldPass.Texts + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            if(dt.Rows.Count > 0)
            {
                labelCheck2.Visible = false;
                return true;
            }
            else 
            {
                labelCheck2.Visible = true;
                labelCheck1.Visible = false;
                labelCheck3.Visible = false;
                return false;
            }
            connection.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((tbNewPass.Texts == "") | (tbConfirm.Texts == "") | (tbOldPass.Texts == ""))
            {
                labelCheck3.Visible = true;
            }
            else
            {
                if (checkPW())
                {

                    if ((tbNewPass.Texts != tbConfirm.Texts))
                    {
                        labelCheck1.Visible = true;
                    }
                    else
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        query = "UPDATE taiKhoan SET matKhau='" + tbNewPass.Texts + "' WHERE taiKhoan='" + ClassAccount.username + "'";
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công");
                        labelCheck1.Visible = false;
                        connection.Close();
                    }
                }
            }
        }
    }
}
