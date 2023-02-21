using System;
using System.Collections;
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
    public partial class FormListEmployee : Form
    {
        string query = "", connectionString = @"Data Source = LAPHAO\TIEUMANTHAU; Initial Catalog = QLNS; User ID = sa; Password = 15122001";

        public FormListEmployee()
        {
            InitializeComponent();
            showData();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            string valueToSearch = tbSearch.Texts.ToString();
            searchData(valueToSearch);
        }

        public void searchData(string valueToSearch)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            query = "SELECT * FROM nhanVien WHERE CONCAT(MSNV, tenNhanVien, taiKhoan, chucVu, tenPhongBan, email, ngaySinh, soDienThoai) like '%" + valueToSearch + "%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        public void showData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM nhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
    }
}
