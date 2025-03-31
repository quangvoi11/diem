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
//using static System.Net.Mime.MediaTypeNames;

namespace diem.quang
{
    public partial class theloai: UserControl
    {
        SqlConnection con = quanlidiem.con;
             
        private void OpenConnection()
        {
            if (con.State == ConnectionState.Closed) con.Open();
        }
        private void CloseConnection()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
        public theloai()
        {
            InitializeComponent();
            load_table();
        }

        public bool check_duplicate(string matheloai)
        {
            //connect
            OpenConnection();
            //command
            string sql = "select count(*) from theloai where matheloai = @matheloai";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matheloai", matheloai);
            int count = (int)cmd.ExecuteScalar();
            //closeconnect
            CloseConnection();
            //check
            if (count > 0)
            {
                MessageBox.Show("Mã thể loại đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }


        public void load_table()
        {
            //connect
            OpenConnection();
            //command 
            string sql = "Select * from theloai";
            SqlCommand cmd = new SqlCommand(sql, con);
            //adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //table
            DataTable tb = new DataTable();
            da.Fill(tb);
            //closecon
            CloseConnection();
            //datagridview
            this.tbl_theloai.DataSource = tb;
        }


        private void tbl_monhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_matheloai.Enabled = false;
            txt_matheloai.Text = tbl_theloai.Rows[i].Cells[0].Value.ToString();
            txt_tentheloai.Text = tbl_theloai.Rows[i].Cells[1].Value.ToString();
            
        }

        private void cbo_tinchi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
            string tk = txt_timkiem.Text.Trim();
            string tk2 = txt_timkiem2.Text.Trim();
            // Mở kết nối
            OpenConnection();
            // Tạo câu truy vấn linh hoạt
            string sql = "select * from theloai where matheloai like @tk and tentheloai like @tk2";
            SqlCommand cmd = new SqlCommand(sql, con);

            // Nếu ô tìm kiếm rỗng, nó sẽ không ảnh hưởng đến kết quả
            cmd.Parameters.AddWithValue("@tk", "%" + tk + "%");
            cmd.Parameters.AddWithValue("@tk2", "%" + tk2 + "%");

            // Adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Table
            DataTable tb = new DataTable();
            da.Fill(tb);

            // Đóng kết nối
            CloseConnection();

            // Hiển thị dữ liệu lên DataGridView
            tbl_theloai.DataSource = tb;
            tbl_theloai.Refresh();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //var
            string matl = txt_matheloai.Text;
            string tentl = txt_tentheloai.Text;
            
            if (string.IsNullOrEmpty(matl) ||
                string.IsNullOrEmpty(tentl) 
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (check_duplicate(matl))
            {
                txt_matheloai.Focus();
                return;
            }
            //connect
            OpenConnection();
            //command
            string sql = "insert into theloai values (@matheloai, @tentheloai)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matheloai", matl);
            cmd.Parameters.AddWithValue("@tentheloai", tentl);
            
            cmd.ExecuteNonQuery();
            //closecon
            CloseConnection();
            //messbox
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_table();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string matl = txt_matheloai.Text;
            string tentl = txt_tentheloai.Text;

            if (string.IsNullOrEmpty(matl) ||
                string.IsNullOrEmpty(tentl)
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //connect
            OpenConnection();
            //command
            string sql = "update theloai set tentheloai = @tentheloai where matheloai = @matheloai";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matheloai", matl);
            cmd.Parameters.AddWithValue("@tentheloai", tentl);
            
            cmd.ExecuteNonQuery();
            //closecon
            CloseConnection();
            //messbox
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_table();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string matl = txt_matheloai.Text.Trim();
                //connect
                OpenConnection();
                string sqlCheck = "SELECT COUNT(*) FROM monhoc WHERE matheloai = @matheloai";
                using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, con))
                {
                    cmdCheck.Parameters.AddWithValue("@matheloai", matl);
                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Thể loại này đang được áp dụng trong các môn học và không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //command
                string sql = "delete from theloai where matheloai = @matheloai";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@matheloai", matl);
                cmd.ExecuteNonQuery();
                //closeconnect
                CloseConnection();
                //mess
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_table();
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_trang_Click(object sender, EventArgs e)
        {
            txt_matheloai.Focus();
            txt_matheloai.Enabled = true;
            txt_matheloai.Text = "";
            txt_tentheloai.Text = "";
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắn chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
