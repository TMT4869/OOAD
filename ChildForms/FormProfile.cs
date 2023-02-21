using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace OOADProject.ChildForms
{
    public partial class FormProfile : Form
    {
        string query = "", connectionString = @"Data Source = LAPHAO\TIEUMANTHAU; Initial Catalog = QLNS; User ID = sa; Password = 15122001";

        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM nhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "userData");
            foreach (DataRow r in ds.Tables["userData"].Rows)
            {
                if (Convert.ToString(r["taiKhoan"]) == ClassAccount.username)
                {
                    id.Text = Convert.ToString(r["MSNV"]);
                    name.Text = Convert.ToString(r["tenNhanVien"]);
                    email.Text = Convert.ToString(r["email"]);
                    phonenum.Text = Convert.ToString(r["soDienThoai"]);
                    birthday.Text = Convert.ToDateTime(r["ngaySinh"]).ToString("dd/MM/yyyy");
                    position.Text = Convert.ToString(r["chucVu"]);
                    department.Text = Convert.ToString(r["tenPhongBan"]);
                }
            }
            connection.Close();
        }
    }
}
