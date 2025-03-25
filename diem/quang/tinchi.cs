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

namespace diem.quang
{
    public partial class tinchi: UserControl
    {
        SqlConnection con = new SqlConnection("Data Source = QUANGVOIDEVICE\\SQLEXPRESS;Initial Catalog = diem; Integrated Security = True");

        private void OpenConnection()
        {
            if (con.State == ConnectionState.Closed) con.Open();
        }
        private void CloseConnection()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
        public tinchi()
        {
            InitializeComponent();
            load_table();
        }


        public bool check_duplicate_m(string matinchi)
        {
            //connect
            OpenConnection();
            //command
            string sql = "select count(*) from tinchi where matinchi = @matinchi";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matinchi", matinchi);
            int count = (int)cmd.ExecuteScalar();
            //closeconnect
            CloseConnection();
            //check
            if (count > 0)
            {
                MessageBox.Show("Mã tín chỉ đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        public bool check_duplicate_s(string sotinchi)
        {
            //connect
            OpenConnection();
            //command
            string sql = "select count(*) from tinchi where sotinchi = @sotinchi";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@sotinchi", sotinchi);
            int count = (int)cmd.ExecuteScalar();
            //closeconnect
            CloseConnection();
            //check
            if (count > 0)
            {
                MessageBox.Show("Số tín chỉ đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        public void load_table()
        {
            //connect
            OpenConnection();
            //command 
            string sql = "select * from tinchi";
            SqlCommand cmd = new SqlCommand(sql, con);
            //adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //table
            DataTable tb = new DataTable();
            da.Fill(tb);
            //closecon
            CloseConnection();
            //datagridview
            this.tbl_tinchi .DataSource = tb;
            this.tbl_tinchi.Refresh();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_nhapexcel_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắn chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_trang_Click(object sender, EventArgs e)
        {
            txt_matinchi.Focus();
            txt_matinchi.Enabled = true;
            txt_matinchi.Text = "";
            txt_sotinchi.Text = "";
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //var
            string matinchi = txt_matinchi.Text;
            string sotinchi = txt_sotinchi.Text;

            if (string.IsNullOrEmpty(matinchi) ||
                string.IsNullOrEmpty(sotinchi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (check_duplicate_m(matinchi))
            {
                txt_matinchi.Focus();
                return ;
            }

            if (check_duplicate_s(sotinchi))
            {
                txt_sotinchi.Focus();
                return;
            }
            //connect
            OpenConnection();
            //command
            string sql = "update tinchi set sotinchi = @sotinchi where matinchi = @matinchi";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matinchi", matinchi);
            cmd.Parameters.AddWithValue("@sotinchi", sotinchi);
            
            cmd.ExecuteNonQuery();
            //closecon
            CloseConnection();
            //messbox
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_table();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //var
            string matinchi = txt_matinchi.Text;
            string sotinchi = txt_sotinchi.Text;
            
            if (string.IsNullOrEmpty(matinchi) ||
                string.IsNullOrEmpty(sotinchi) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (check_duplicate_m(matinchi))
            {
                txt_matinchi.Focus();
                return;
            }

            if(check_duplicate_s(sotinchi))
            {
                txt_sotinchi.Focus();
                return;
            }
            //connect
            OpenConnection();
            //command
            string sql = "insert into tinchi values (@matinchi, @sotinchi)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matinchi", matinchi);
            cmd.Parameters.AddWithValue("@sotinchi", sotinchi);
            
            cmd.ExecuteNonQuery();
            //closecon
            CloseConnection();
            //messbox
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_table();
        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {

        }

        private void txt_tentheloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_matheloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ textbox và loại bỏ khoảng trắng dư thừa
            string tk = txt_timkiem.Text.Trim();
            string tk2 = txt_timkiem2.Text.Trim();

            // Mở kết nối
            OpenConnection();

            // Tạo câu truy vấn linh hoạt
            string sql = "Select * from tinchi where matinchi like @tk and sotinchi like @tk2 ";
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
            tbl_tinchi.DataSource = tb;
            tbl_tinchi.Refresh();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_timkiem2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbl_tinchi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_matinchi.Enabled = false;
            txt_matinchi.Text = tbl_tinchi.Rows[i].Cells[0].Value.ToString();
            txt_sotinchi.Text = tbl_tinchi.Rows[i].Cells[1].Value.ToString();
            
        }
    }
}
