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
using xls = Microsoft.Office.Interop.Excel;
using diem.giang;


namespace diem.quang
{
    public partial class monhoc : UserControl
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
            try
            {
                // Kết nối với SQL Server

                OpenConnection();
                // Truy vấn dữ liệu
                string sql = @"Select m.mamonhoc, m.tenmonhoc, t.sotinchi, tentheloai
                                from monhoc m
                                join tinchi t on m.matinchi = t.matinchi
                                join theloai th on m.matheloai = th.matheloai";


                using (SqlCommand cmd = new SqlCommand(sql, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dtable = new DataTable();
                    da.Fill(dtable);

                    // Xuất dữ liệu sang Excel
                    ExportExcel(dtable, "Danh sách Môn Học");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;
            DialogResult kq = openFileDialog1.ShowDialog();
            if (kq == DialogResult.OK)
            {
                txt_nhapfile.Text = openFileDialog1.FileName;
                String tenfile = openFileDialog1.FileName;
                ReadExcel(tenfile);

                load_table();
            }
        }

        public void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "THỐNG KÊ MÔN HỌC";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ MÔN HỌC ";
            cl1.ColumnWidth = 12.5;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN MÔN HỌC ";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = " TÍN CHỈ";
            cl3.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "THỂ LOẠI";
            cl4.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            //cl5.Value2 = "LOẠI SÁCH";
            //cl5.ColumnWidth = 25.0;
            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";


            //Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            //cl7.Value2 = "ĐIỂM";
            //cl7.ColumnWidth = 10;
            //Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            //cl8.Value2 = "GHI CHÚ";
            //cl8.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void ReadExcel(string filename)
        {
            try
            {
                if (string.IsNullOrEmpty(filename))
                {
                    MessageBox.Show("Chưa chọn file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                xls.Application Excel = new xls.Application();
                xls.Workbook workbook = Excel.Workbooks.Open(filename);
                xls.Worksheet worksheet = workbook.Sheets[1]; // Chọn sheet đầu tiên

                int i = 2; // Đọc dữ liệu từ dòng thứ 2 (bỏ qua tiêu đề)
                bool hasData = false;
                bool hasError = false; // Biến kiểm tra xem có lỗi không

                while (worksheet.Cells[i, 1].Value != null)
                {
                    try
                    {
                        int mamon = Convert.ToInt32(worksheet.Cells[i, 1].Value);
                        string tenmon = worksheet.Cells[i, 2].Text;
                        int matinchi = Convert.ToInt32(worksheet.Cells[i, 3].Value);
                        int matheloai = Convert.ToInt32(worksheet.Cells[i, 4].Value);


                        Themmoimonhoc(mamon, tenmon, matinchi, matheloai); // Thêm vào DB
                        hasData = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mã môn đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_mamon.Focus();
                        return;
                    }
                    i++;
                }

                workbook.Close(false);
                Excel.Quit();

                if (!hasError && hasData)
                {
                    MessageBox.Show("Nhập file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("");
            }
        }

        private void Themmoimonhoc(int mamon, string tenmon, int matinchi, int matheloai)
        {
            OpenConnection();

            string sql = "INSERT INTO monhoc values (@mamonhoc, @tenmonhoc, @matinchi, @matheloai)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mamonhoc", mamon);
            cmd.Parameters.AddWithValue("@tenmonhoc", tenmon);
            cmd.Parameters.AddWithValue("@matinchi", matinchi);
            cmd.Parameters.AddWithValue("@matheloai", matheloai);

            cmd.ExecuteNonQuery();
           
        }

    }
}
