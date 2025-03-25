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
using System.Net.NetworkInformation;

namespace diem.quang
{
    public partial class monhoc : UserControl
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
        public monhoc()
        {
            InitializeComponent();
            load_table();
            Load_combo_theloai();
            Load_combo_tinchi();
        }

        public bool check_duplicate(string mamonhoc)
        {
            //connect
            OpenConnection();
            //command
            string sql = "select count(*) from monhoc where mamonhoc = @mamonhoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mamonhoc", mamonhoc);
            int count = (int)cmd.ExecuteScalar();
            //closeconnect
            CloseConnection();
            //check
            if (count > 0)
            {
                MessageBox.Show("Mã môn học đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        public void Load_combo_theloai()
        {
            OpenConnection();
            String sql = "Select * from theloai";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd;

            DataTable tb = new DataTable();
            da1.Fill(tb);
            cmd.Dispose();
            con.Close();
            //bo sung them 1 dong vao vi tri dau tien cua bang tb
            DataRow r = tb.NewRow();
            r["matheloai"] = DBNull.Value;
            r["tentheloai"] = "----- chọn thể loại -----";
            tb.Rows.InsertAt(r, 0);
            cbo_theloai.DataSource = tb;
            cbo_theloai.DisplayMember = "tentheloai";
            cbo_theloai.ValueMember = "matheloai";
        }


        public void Load_combo_tinchi()
        {
            OpenConnection();
            String sql = "Select * from tinchi";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd;

            DataTable tb = new DataTable();
            da1.Fill(tb);
            cmd.Dispose();
            con.Close();

            // Thêm cột hiển thị văn bản
            tb.Columns.Add("sotinchi_text", typeof(string));
            //bo sung them 1 dong vao vi tri dau tien cua bang tb
            DataRow r = tb.NewRow();
            r["matinchi"] = DBNull.Value;
            r["sotinchi_text"] = "----- chọn số tín chỉ -----";
            tb.Rows.InsertAt(r, 0);

            foreach (DataRow row in tb.Rows)
            {
                if (row["sotinchi"] != DBNull.Value) // Kiểm tra xem cột sotinchi có giá trị không
                    row["sotinchi_text"] = row["sotinchi"].ToString(); // Chuyển giá trị số tín chỉ thành chuỗi và gán vào cột sotinchi_text
            }

            cbo_tinchi.DataSource = tb;
            cbo_tinchi.DisplayMember = "sotinchi_text";
            cbo_tinchi.ValueMember = "matinchi";
        }

        public void load_table()
        {
            //connect
            OpenConnection();
            //command 
            string sql = @"select m.mamonhoc, m.tenmonhoc , tinchi.sotinchi as Số_tín_chỉ, theloai.tentheloai as Thể_loại
                            from monhoc m
                            join theloai on m.matheloai = theloai.matheloai
                            join tinchi on m.matinchi = tinchi.matinchi";
            SqlCommand cmd = new SqlCommand(sql, con);
            //adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //table
            DataTable tb = new DataTable();
            da.Fill(tb);
            //closecon
            CloseConnection();
            //datagridview
            this.tbl_monhoc.DataSource = tb;
            this.tbl_monhoc.Refresh();
        }
        private void monhoc_Load(object sender, EventArgs e)
        {
            // test repo nanana
            // if you see this, it means that the repo is working
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_timkiem2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
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
            string sql = @"
                        SELECT 
                            m.mamonhoc, 
                            m.tenmonhoc, 
                            t.sotinchi AS Số_tín_chỉ, 
                            l.tentheloai AS Thể_loại 
                        FROM monhoc AS m
                        JOIN theloai AS l ON m.matheloai = l.matheloai
                        JOIN tinchi AS t ON m.matinchi = t.matinchi
                        WHERE m.mamonhoc LIKE @tk
                        AND m.tenmonhoc LIKE @tk2";
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
            tbl_monhoc.DataSource = tb;
            tbl_monhoc.Refresh();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nhapexcel_Click(object sender, EventArgs e)
        {

        }

        private void txt_namketthuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nambatdau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_tenkhoahoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_makhoahoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắn chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_trang_Click(object sender, EventArgs e)
        {
            txt_mamon.Focus();
            txt_mamon.Enabled = true;
            txt_mamon.Text = "";
            txt_tenmon.Text = "";
            cbo_theloai.SelectedIndex = 0;
            cbo_tinchi.SelectedIndex = 0;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mamon = txt_mamon.Text.Trim();
                    //connect
                    OpenConnection();
                string sqlCheck = "SELECT COUNT(*) FROM phancong WHERE mamonhoc = @mamonhoc";
                using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, con))
                {
                    cmdCheck.Parameters.AddWithValue("@mamonhoc", mamon);
                    int count = (int)cmdCheck.ExecuteScalar();  

                    if (count > 0)
                    {
                        MessageBox.Show("Môn học này đang được giảng dạy và không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //command
                string sql = "delete from monhoc where mamonhoc = @mamonhoc";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@mamonhoc", mamon);
                    cmd.ExecuteNonQuery();
                    //closeconnect
                    CloseConnection();
                    //mess
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_table();
                }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
                
            //var
                string mamon = txt_mamon.Text;
                string tenmon = txt_tenmon.Text;
                string theloai = cbo_theloai.SelectedValue.ToString();
                string tinchi = cbo_tinchi.SelectedValue.ToString();
                if (string.IsNullOrEmpty(mamon) ||
                string.IsNullOrEmpty(tenmon) ||
                string.IsNullOrEmpty(theloai) ||
                string.IsNullOrEmpty(tinchi))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //connect
                OpenConnection();
                //command
                string sql = "update monhoc set tenmonhoc = @tenmonhoc, matinchi = @matinchi, matheloai = @matheloai where mamonhoc = @mamonhoc";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mamonhoc", mamon);
                cmd.Parameters.AddWithValue("@tenmonhoc", tenmon);
                cmd.Parameters.AddWithValue("@matinchi", tinchi);
                cmd.Parameters.AddWithValue("@matheloai", theloai);
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
            string mamon = txt_mamon.Text;
            string tenmon = txt_tenmon.Text;
            string theloai = cbo_theloai.SelectedValue.ToString();
            string tinchi = cbo_tinchi.SelectedValue.ToString();
            if (string.IsNullOrEmpty(mamon) ||
                string.IsNullOrEmpty(tenmon) ||
                string.IsNullOrEmpty(theloai) ||
                string.IsNullOrEmpty(tinchi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (check_duplicate(mamon))
            {
                txt_mamon.Focus();
                return;
            }
            //connect
            OpenConnection();
            //command
            string sql = "insert into monhoc values (@mamonhoc, @tenmonhoc, @matinchi, @matheloai)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mamonhoc", mamon);
            cmd.Parameters.AddWithValue("@tenmonhoc", tenmon);
            cmd.Parameters.AddWithValue("@matinchi", tinchi);
            cmd.Parameters.AddWithValue("@matheloai", theloai);
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int i = e.RowIndex;
            txt_mamon.Enabled = false;
            txt_mamon.Text = tbl_monhoc.Rows[i].Cells[0].Value.ToString();
            txt_tenmon.Text = tbl_monhoc.Rows[i].Cells[1].Value.ToString();
            string sotinchi = tbl_monhoc.Rows[i].Cells[2].Value.ToString();
            cbo_tinchi.Text = sotinchi;  // Gán trực tiếp
            string theloai = tbl_monhoc.Rows[i].Cells[3].Value.ToString();
            cbo_theloai.Text = theloai;  // Gán trực tiếp

        }

        private void tbl_monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
