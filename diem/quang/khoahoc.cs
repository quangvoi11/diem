using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace diem.giang
{
    public partial class khoahoc: UserControl
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-GIS261SR\\SQLEXPRESS;Initial Catalog=diem;Integrated Security=True");
        private void OpenConnection()
        {
            if (con.State == ConnectionState.Closed) con.Open();
        }
        private void CloseConnection()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
        public khoahoc()
        {
            InitializeComponent();
            load_table();
        }
        public bool check_duplicate(string masinhvien)
        {
            //connect
            OpenConnection();
            //command
            string sql = "select count(*) from sinhvien where masinhvien = @masinhvien";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@masinhvien", masinhvien);
            int count = (int)cmd.ExecuteScalar();
            //closeconnect
            CloseConnection();
            //check
            if (count > 0)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public void load_table()
        {
            //connect
            OpenConnection();
            //command 
            string sql = "select * from khoahoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            //adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //table
            DataTable tb = new DataTable();
            da.Fill(tb);
            //closecon
            CloseConnection();
            //datagridview
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "Nhập mã")
            {
                txt_timkiem.Text = "";
                txt_timkiem.ForeColor = Color.Black;
            }
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                txt_timkiem.Text = "Nhập mã";
                txt_timkiem.ForeColor = Color.Gray;
            }
        }

        private void txt_timkiem2_Enter(object sender, EventArgs e)
        {
            if (txt_timkiem2.Text == "Nhập tên")
            {
                txt_timkiem2.Text = "";
                txt_timkiem2.ForeColor = Color.Black;
            }
        }

        private void txt_timkiem2_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem2.Text == "")
            {
                txt_timkiem2.Text = "Nhập tên";
                txt_timkiem2.ForeColor = Color.Gray;
            }
        }

        private void txt_makhoahoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nambatdau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_namketthuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0) txt_makhoahoc.Enabled = false;
            txt_makhoahoc.Text = dataGridView1.Rows[i].Cells["makhoahoc"].Value.ToString();
            txt_tenkhoahoc.Text = dataGridView1.Rows[i].Cells["tenkhoahoc"].Value.ToString();
            txt_nambatdau.Text = dataGridView1.Rows[i].Cells["nambatdau"].Value.ToString();
            txt_namketthuc.Text = dataGridView1.Rows[i].Cells["namketthuc"].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //var
            string makhoahoc = txt_makhoahoc.Text;
            string tenkhoahoc = txt_tenkhoahoc.Text;
            string nambatdau = txt_nambatdau.Text;
            string namketthuc = txt_namketthuc.Text;
            if (string.IsNullOrEmpty(makhoahoc) ||
                string.IsNullOrEmpty(tenkhoahoc) ||
                string.IsNullOrEmpty(nambatdau) ||
                string.IsNullOrEmpty(namketthuc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (check_duplicate(makhoahoc))
            {
                txt_makhoahoc.Focus();
                return;
            }
            //connect
            OpenConnection();
            //command
            string sql = "insert into khoahoc values (@makhoahoc, @tenkhoahoc, @nambatdau, @namketthuc)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@makhoahoc", makhoahoc);
            cmd.Parameters.AddWithValue("@tenkhoahoc", tenkhoahoc);
            cmd.Parameters.AddWithValue("@nambatdau", nambatdau);
            cmd.Parameters.AddWithValue("@namketthuc", namketthuc);
            cmd.ExecuteNonQuery();
            //closecon
            CloseConnection();
            //messbox
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_table();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //var
                string makhoahoc = txt_makhoahoc.Text;
                string tenkhoahoc = txt_tenkhoahoc.Text;
                string nambatdau = txt_nambatdau.Text;
                string namketthuc = txt_namketthuc.Text;
                if (string.IsNullOrEmpty(makhoahoc) ||
                    string.IsNullOrEmpty(tenkhoahoc) ||
                    string.IsNullOrEmpty(nambatdau) ||
                    string.IsNullOrEmpty(namketthuc))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //connect
                OpenConnection();
                //command
                string sql = "update khoahoc set tenkhoahoc = @tenkhoahoc, nambatdau = @nambatdau, namketthuc = @namketthuc where makhoahoc = @makhoahoc";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@makhoahoc", makhoahoc);
                cmd.Parameters.AddWithValue("@tenkhoahoc", tenkhoahoc);
                cmd.Parameters.AddWithValue("@nambatdau", nambatdau);
                cmd.Parameters.AddWithValue("@namketthuc", namketthuc);
                cmd.ExecuteNonQuery();
                //closecon
                CloseConnection();
                //messbox
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_table();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string makhoahoc = dataGridView1.SelectedRows[0].Cells["makhoahoc"].Value.ToString();
                    //connect
                    OpenConnection();
                    //command
                    string sql = "delete from khoahoc where makhoahoc = @makhoahoc";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@makhoahoc", makhoahoc);
                    cmd.ExecuteNonQuery();
                    //closeconnect
                    CloseConnection();
                    //mess
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_table();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_trang_Click(object sender, EventArgs e)
        {
            txt_makhoahoc.Focus();
            txt_makhoahoc.Enabled = true;
            txt_makhoahoc.Text = "";
            txt_tenkhoahoc.Text = "";
            txt_nambatdau.Text = "";
            txt_namketthuc.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắn chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //var
            string tk = txt_timkiem.Text.Trim();
            string tk2 = txt_timkiem2.Text.Trim();
            //connect
            OpenConnection();
            //command
            string sql = "SELECT * FROM khoahoc " +
                     "WHERE makhoahoc LIKE @tk " +
                     "AND tenkhoahoc LIKE @tk2";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tk", "%" + tk + "%");
            cmd.Parameters.AddWithValue("@tk2", "%" + tk2 + "%");
            //adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //table
            DataTable tb = new DataTable();
            da.Fill(tb);
            //closecon
            CloseConnection();
            //datagridview
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
    }
}
