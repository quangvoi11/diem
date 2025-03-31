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
using xls = Microsoft.Office.Interop.Excel;
using diem.quang;

namespace diem.giang
{
    public partial class khoahoc : UserControl
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
        public khoahoc()
        {
            InitializeComponent();
            load_table();
        }
        public bool check_duplicate(string makhoahoc)
        {
            //connect
            OpenConnection();
            //command
            string sql = "select count(*) from khoahoc where makhoahoc = @makhoahoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@makhoahoc", makhoahoc);
            int count = (int)cmd.ExecuteScalar();
            //closeconnect
            CloseConnection();
            //check
            if (count > 0)
            {
                MessageBox.Show("Mã khóa học đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
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
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối với SQL Server

                OpenConnection();
                // Truy vấn dữ liệu
                string sql = "SELECT * FROM khoahoc";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dtable = new DataTable();
                    da.Fill(dtable);

                    // Xuất dữ liệu sang Excel
                    ExportExcel(dtable, "Danh sách Khóa Học");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_timkiem2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nhapexcel_Click(object sender, EventArgs e)
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
            head.Value2 = "THỐNG KÊ KHÓA HỌC";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ KHÓA HỌC ";
            cl1.ColumnWidth = 12.5;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN KHÓA HỌC ";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NĂM BẮT ĐẦU";
            cl3.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "NĂM KẾT THÚC";
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
                        int makhoahoc = Convert.ToInt32(worksheet.Cells[i, 1].Value);
                        string tenkhoahoc = worksheet.Cells[i, 2].Text;
                        int nambatdau = Convert.ToInt32(worksheet.Cells[i, 3].Value);
                        int namketthuc = Convert.ToInt32(worksheet.Cells[i, 4].Value);


                        Themmoisach(makhoahoc, tenkhoahoc, nambatdau, namketthuc); // Thêm vào DB
                        hasData = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mã sách đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_makhoahoc.Focus();
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

        private void Themmoisach(int makhoahoc, string tenkhoahoc, int nambatdau, int namketthuc)
        {
            OpenConnection();
            string sql = "insert into khoahoc values (@makhoahoc, @tenkhoahoc, @nambatdau, @namketthuc)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@makhoahoc", makhoahoc);
            cmd.Parameters.AddWithValue("@tenkhoahoc", tenkhoahoc);
            cmd.Parameters.AddWithValue("@nambatdau", nambatdau);
            cmd.Parameters.AddWithValue("@namketthuc", namketthuc);

            cmd.ExecuteNonQuery();
        }

    



    }
}
