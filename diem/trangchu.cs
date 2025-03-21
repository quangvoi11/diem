using diem.giang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diem
{
    public partial class trangchu: Form
    {
        public trangchu()
        {
            InitializeComponent();
        }
        public bool batloi_mail(string mail)
        {
            //trim
            mail = mail.Trim();
            //regex
            string pattern = @"^[a-zA-Z0-9][\w.-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(mail, pattern))
            {
                MessageBox.Show("Mail không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        public bool batloi_sdt(string dienthoai)
        {
            //trim
            dienthoai = dienthoai.Trim();
            //regex
            string pattern = @"^(84|0[3-9])[0-9]{8}$";
            if (!Regex.IsMatch(dienthoai, pattern))
            {
                MessageBox.Show("Điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }

        private void menu_trangchu_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear(); // Xóa nội dung cũ

            trangchu frmTrangChu = new trangchu(); // Tạo form trang chủ mới
            Control panelTrangChu = frmTrangChu.Controls["panel_main"]; // Lấy panel_main từ trangchu
            
            panelTrangChu.Dock = DockStyle.Fill; // Đổ đầy vào panel_main
            panel_main.Controls.Add(panelTrangChu); // Thêm vào panel_main hiện tại

            this.Text = "TRANG CHỦ"; // Đổi tiêu đề Form
        }

        private void btn_khoahoc_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear(); // Xóa control cũ (nếu có)

            khoahoc khoahoc = new khoahoc();
            khoahoc.Dock = DockStyle.Fill; // Đổ đầy panel

            panel_main.Controls.Add(khoahoc); // Thêm vào panel

            this.Text = "KHÓA HỌC"; // Đặt tiêu đề form
        }
    }
}
