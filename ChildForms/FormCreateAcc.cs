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
using System.Xml.Linq;

namespace OOADProject.ChildForms
{
    public partial class FormCreateAcc : Form
    {
        string query = "", connectionString = @"Data Source = LAPHAO\TIEUMANTHAU; Initial Catalog = QLNS; User ID = sa; Password = 15122001";

        public FormCreateAcc()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabAdd);
            tabControl1.TabPages.Remove(tabEdit);
            showData();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabAdd);
            tabControl1.TabPages.Remove(tabEmployee);
            tabControl1.TabPages.Remove(tabAcc);
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabEdit);
            tabControl1.TabPages.Remove(tabEmployee);
            tabControl1.TabPages.Remove(tabAcc);
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabEdit);
            tabControl1.TabPages.Add(tabEmployee);
            showData();
            tabControl1.TabPages.Add(tabAcc);
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabAdd);
            tabControl1.TabPages.Add(tabEmployee);
            showData();
            tabControl1.TabPages.Add(tabAcc);
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            string valueToSearch = tbSearch.Texts.ToString();
            searchData(valueToSearch);
        }

        public void showData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM nhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewEmployee.AutoGenerateColumns = false;
            dataGridViewEmployee.DataSource = dt;
        }
        
        public void searchData(string valueToSearch)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            query = "SELECT * FROM nhanVien WHERE CONCAT(MSNV, tenNhanVien, taiKhoan, chucVu, tenPhongBan, email, ngaySinh, soDienThoai) like '%"+valueToSearch+"%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewEmployee.AutoGenerateColumns = false;
            dataGridViewEmployee.DataSource = dt;
        }

        private void btnSearchAcc_Click(object sender, EventArgs e)
        {
            string valueToSearch = tbID.Text.ToString();
            searchDataByID(valueToSearch);
            tbName.Text = ClassAccount.name;
            tbEmail.Text = ClassAccount.email;
            tbPN.Text = ClassAccount.PN;
            if (ClassAccount.BD == DateTime.Now)
            {
                tbBD.Text = null;
            }
            else
            {
                tbBD.Text = ClassAccount.BD.ToString("dd/MM/yyyy");
            }
            tbPosition.Text = ClassAccount.position;
            tbDepartment.Text = ClassAccount.department;
            tbAcc.Text = ClassAccount.acc;
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {

        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string MSNV = tbID1.Text.ToString();
            //tryToAddEmployee(MSNV);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                query = "INSERT INTO nhanVien(tenNhanVien,chucVu,tenPhongBan,email,ngaySinh,soDienThoai) VALUES(@name,@position,@department,@email,@bd,@pn)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(ID);
                    cmd.Parameters.AddWithValue("@name", tbName1.Text);
                    cmd.Parameters.AddWithValue("@position", tbPosition1.Text);
                    cmd.Parameters.AddWithValue("@department", tbDepartment1.Text);
                    cmd.Parameters.AddWithValue("@email", tbEmail1.Text);
                    cmd.Parameters.AddWithValue("@pn", tbPN1.Text);
                    cmd.Parameters.Add("@bd", SqlDbType.Date).Value = BD1.Value.Date;

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Lỗi");
                    else
                        MessageBox.Show("Thêm nhân viên thành công");
                    cmd.Connection.Close();
                }
            }
        }

        private void dataGridViewEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewEmployee.Rows[e.RowIndex];
            ClassAccount.id = (int)selectedRow.Cells["MSNV"].Value;
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) 
            {
                deleteEmployee(ClassAccount.id);
                showData();
            }
        }

        public void searchDataByID(string valueToSearch)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM nhanVien WHERE MSNV like '%" + valueToSearch + "%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
                if (Convert.ToString(r["MSNV"]) == valueToSearch)
                {
                    ClassAccount.name = Convert.ToString(r["tenNhanVien"]);
                    ClassAccount.email = Convert.ToString(r["email"]);
                    ClassAccount.PN = Convert.ToString(r["soDienThoai"]);
                    ClassAccount.BD = Convert.ToDateTime(r["ngaySinh"]);
                    ClassAccount.position = Convert.ToString(r["chucVu"]);
                    ClassAccount.department = Convert.ToString(r["tenPhongBan"]);
                    ClassAccount.acc = Convert.ToString(r["taiKhoan"]);
                }
                else
                {
                    ClassAccount.name = null;
                    ClassAccount.email = null;
                    ClassAccount.PN = null;
                    ClassAccount.BD = DateTime.Now;
                    ClassAccount.position = null;
                    ClassAccount.department = null;
                    ClassAccount.acc = null;
                }
            connection.Close();
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string valueToSearch = tbID2.Text.ToString();
            searchDataByID(valueToSearch);
            tbName2.Text = ClassAccount.name;
            tbEmail2.Text = ClassAccount.email;
            tbPN2.Text = ClassAccount.PN;
            BD2.Value = ClassAccount.BD;
            BD2.Format = DateTimePickerFormat.Short;
            tbPosition2.Text = ClassAccount.position;
            tbDepartment2.Text = ClassAccount.department;
        }

        private void deleteEmployee(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                query = "DELETE FROM nhanVien where MSNV=@id";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Lỗi");
                    else
                        MessageBox.Show("Xóa nhân viên thành công");
                    cmd.Connection.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn cập nhật nhân viên này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                updateEmployee(int.Parse(tbID2.Text));
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void updateEmployee(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                query = "UPDATE nhanVien SET tenNhanVien=@name, chucVu=@position, tenPhongBan=@department, email=@email, ngaySinh=@bd, soDienThoai=@pn WHERE MSNV=@id";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.AddWithValue("@name", tbName2.Text);
                    cmd.Parameters.AddWithValue("@position", tbPosition2.Text);
                    cmd.Parameters.AddWithValue("@department", tbDepartment2.Text);
                    cmd.Parameters.AddWithValue("@email", tbEmail2.Text);
                    cmd.Parameters.AddWithValue("@pn", tbPN2.Text);
                    cmd.Parameters.Add("@bd", SqlDbType.Date).Value = BD2.Value.Date;
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Lỗi");
                    else
                        MessageBox.Show("Cập nhật thông tin thành công");
                    cmd.Connection.Close();
                }
            }
        }
        /*private void tryToAddEmployee(string ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                query = "IF NOT EXISTS (Select MSNV From nhanVien where MSNV = @id)\r\n" +
                    "SET IDENTITY_INSERT nhanVien ON\r\n"+
                    "INSERT INTO nhanVien(MSNV,tenNhanVien,chucVu,tenPhongBan,email,ngaySinh,soDienThoai) VALUES(@id,@name,@position,@department,@email,@bd,@pn)" +
                    "SET IDENTITY_INSERT nhanVien OFF\r\n";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(ID);
                    cmd.Parameters.AddWithValue("@name", tbName1.Text);
                    cmd.Parameters.AddWithValue("@position", tbPosition1.Text);
                    cmd.Parameters.AddWithValue("@department", tbDepartment1.Text);
                    cmd.Parameters.AddWithValue("@email", tbEmail1.Text);
                    cmd.Parameters.AddWithValue("@pn", tbPN1.Text);
                    cmd.Parameters.Add("@bd", SqlDbType.Date).Value = BD1.Value.Date;

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Đã tồn tại MSNV này");
                    cmd.Connection.Close();
                }
            }
        }*/
    }
}
