﻿namespace diem.quang
{
    partial class monhoc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_monhoc = new System.Windows.Forms.DataGridView();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenmon = new System.Windows.Forms.TextBox();
            this.txt_mamon = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_tinchi = new System.Windows.Forms.ComboBox();
            this.cbo_theloai = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_trang = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xuatexcel = new System.Windows.Forms.Button();
            this.txt_timkiem2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_nhapexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_monhoc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.ForeColor = System.Drawing.Color.Gray;
            this.txt_timkiem.Location = new System.Drawing.Point(235, 21);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(98, 20);
            this.txt_timkiem.TabIndex = 6;
            this.txt_timkiem.Tag = "Nhập mã ";
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1182, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản Lý môn học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbl_monhoc
            // 
            this.tbl_monhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_monhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_monhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoc,
            this.tenmonhoc,
            this.matinchi,
            this.matheloai});
            this.tbl_monhoc.Location = new System.Drawing.Point(1, 102);
            this.tbl_monhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbl_monhoc.Name = "tbl_monhoc";
            this.tbl_monhoc.RowHeadersWidth = 51;
            this.tbl_monhoc.RowTemplate.Height = 24;
            this.tbl_monhoc.Size = new System.Drawing.Size(1176, 300);
            this.tbl_monhoc.TabIndex = 13;
            this.tbl_monhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.tbl_monhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_monhoc_CellContentClick);
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "Mã môn học";
            this.mamonhoc.MinimumWidth = 6;
            this.mamonhoc.Name = "mamonhoc";
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học ";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            // 
            // matinchi
            // 
            this.matinchi.DataPropertyName = "Số_tín_Chỉ";
            this.matinchi.HeaderText = "Số tín chỉ";
            this.matinchi.MinimumWidth = 6;
            this.matinchi.Name = "matinchi";
            // 
            // matheloai
            // 
            this.matheloai.DataPropertyName = "Thể_loại";
            this.matheloai.HeaderText = "Thể loại";
            this.matheloai.MinimumWidth = 6;
            this.matheloai.Name = "matheloai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thể loại: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số tín chỉ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên môn:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã môn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_tenmon
            // 
            this.txt_tenmon.Location = new System.Drawing.Point(154, 106);
            this.txt_tenmon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tenmon.Name = "txt_tenmon";
            this.txt_tenmon.Size = new System.Drawing.Size(155, 20);
            this.txt_tenmon.TabIndex = 1;
            this.txt_tenmon.TextChanged += new System.EventHandler(this.txt_tenkhoahoc_TextChanged);
            // 
            // txt_mamon
            // 
            this.txt_mamon.Location = new System.Drawing.Point(154, 50);
            this.txt_mamon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.Size = new System.Drawing.Size(76, 20);
            this.txt_mamon.TabIndex = 0;
            this.txt_mamon.TextChanged += new System.EventHandler(this.txt_makhoahoc_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_tinchi);
            this.groupBox3.Controls.Add(this.cbo_theloai);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_tenmon);
            this.groupBox3.Controls.Add(this.txt_mamon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 406);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1182, 221);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbo_tinchi
            // 
            this.cbo_tinchi.FormattingEnabled = true;
            this.cbo_tinchi.Items.AddRange(new object[] {
            "---- Chọn số tín chỉ ----"});
            this.cbo_tinchi.Location = new System.Drawing.Point(450, 49);
            this.cbo_tinchi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_tinchi.Name = "cbo_tinchi";
            this.cbo_tinchi.Size = new System.Drawing.Size(165, 21);
            this.cbo_tinchi.TabIndex = 11;
            // 
            // cbo_theloai
            // 
            this.cbo_theloai.FormattingEnabled = true;
            this.cbo_theloai.Location = new System.Drawing.Point(450, 104);
            this.cbo_theloai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_theloai.Name = "cbo_theloai";
            this.cbo_theloai.Size = new System.Drawing.Size(165, 21);
            this.cbo_theloai.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_trang);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_xuatexcel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 627);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1182, 65);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::diem.Properties.Resources.icons8_exit_24;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(1059, 23);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_thoat.Size = new System.Drawing.Size(98, 32);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_trang
            // 
            this.btn_trang.Image = global::diem.Properties.Resources.icons8_white_circle_24;
            this.btn_trang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trang.Location = new System.Drawing.Point(384, 23);
            this.btn_trang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_trang.Name = "btn_trang";
            this.btn_trang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_trang.Size = new System.Drawing.Size(98, 32);
            this.btn_trang.TabIndex = 10;
            this.btn_trang.Text = "Trắng";
            this.btn_trang.UseVisualStyleBackColor = true;
            this.btn_trang.Click += new System.EventHandler(this.btn_trang_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::diem.Properties.Resources.icons8_delete_24;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(276, 23);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_xoa.Size = new System.Drawing.Size(98, 32);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::diem.Properties.Resources.icons8_update_24;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(168, 23);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_sua.Size = new System.Drawing.Size(98, 32);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::diem.Properties.Resources.icons8_add_24;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(60, 23);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_them.Size = new System.Drawing.Size(98, 32);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xuatexcel
            // 
            this.btn_xuatexcel.Image = global::diem.Properties.Resources.icons8_export_excel_24;
            this.btn_xuatexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuatexcel.Location = new System.Drawing.Point(901, 23);
            this.btn_xuatexcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            this.btn_xuatexcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_xuatexcel.Size = new System.Drawing.Size(98, 32);
            this.btn_xuatexcel.TabIndex = 11;
            this.btn_xuatexcel.Text = "Xuất Excel";
            this.btn_xuatexcel.UseVisualStyleBackColor = true;
            this.btn_xuatexcel.Click += new System.EventHandler(this.btn_xuatexcel_Click);
            // 
            // txt_timkiem2
            // 
            this.txt_timkiem2.ForeColor = System.Drawing.Color.Gray;
            this.txt_timkiem2.Location = new System.Drawing.Point(428, 21);
            this.txt_timkiem2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_timkiem2.Name = "txt_timkiem2";
            this.txt_timkiem2.Size = new System.Drawing.Size(98, 20);
            this.txt_timkiem2.TabIndex = 7;
            this.txt_timkiem2.TextChanged += new System.EventHandler(this.txt_timkiem2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Controls.Add(this.txt_timkiem2);
            this.panel1.Controls.Add(this.btn_nhapexcel);
            this.panel1.Location = new System.Drawing.Point(1, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 57);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên môn:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã môn:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Image = global::diem.Properties.Resources.icons8_search_24;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(31, 14);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(98, 32);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_nhapexcel
            // 
            this.btn_nhapexcel.Image = global::diem.Properties.Resources.icons8_microsoft_excel_24;
            this.btn_nhapexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhapexcel.Location = new System.Drawing.Point(1014, 14);
            this.btn_nhapexcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nhapexcel.Name = "btn_nhapexcel";
            this.btn_nhapexcel.Size = new System.Drawing.Size(98, 32);
            this.btn_nhapexcel.TabIndex = 6;
            this.btn_nhapexcel.Text = "Nhập Excel";
            this.btn_nhapexcel.UseVisualStyleBackColor = true;
            this.btn_nhapexcel.Click += new System.EventHandler(this.btn_nhapexcel_Click);
            // 
            // monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbl_monhoc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "monhoc";
            this.Size = new System.Drawing.Size(1182, 692);
            this.Load += new System.EventHandler(this.monhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_monhoc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_nhapexcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbl_monhoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenmon;
        private System.Windows.Forms.TextBox txt_mamon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_trang;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xuatexcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_timkiem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_tinchi;
        private System.Windows.Forms.ComboBox cbo_theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn matheloai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
