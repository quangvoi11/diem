﻿namespace diem.giang
{
    partial class khoahoc
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_trang = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xuatexcel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_namketthuc = new System.Windows.Forms.TextBox();
            this.txt_nambatdau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenkhoahoc = new System.Windows.Forms.TextBox();
            this.txt_makhoahoc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.makhoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nambatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_timkiem2 = new System.Windows.Forms.TextBox();
            this.btn_nhapexcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_nhapfile = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(0, 622);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1182, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::diem.Properties.Resources.icons8_exit_24;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(772, 23);
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
            this.btn_xuatexcel.Location = new System.Drawing.Point(664, 23);
            this.btn_xuatexcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            this.btn_xuatexcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_xuatexcel.Size = new System.Drawing.Size(98, 32);
            this.btn_xuatexcel.TabIndex = 11;
            this.btn_xuatexcel.Text = "Xuất Excel";
            this.btn_xuatexcel.UseVisualStyleBackColor = true;
            this.btn_xuatexcel.Click += new System.EventHandler(this.btn_xuatexcel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_namketthuc);
            this.groupBox3.Controls.Add(this.txt_nambatdau);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_tenkhoahoc);
            this.groupBox3.Controls.Add(this.txt_makhoahoc);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 401);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1182, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txt_namketthuc
            // 
            this.txt_namketthuc.Location = new System.Drawing.Point(433, 106);
            this.txt_namketthuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_namketthuc.Name = "txt_namketthuc";
            this.txt_namketthuc.Size = new System.Drawing.Size(76, 20);
            this.txt_namketthuc.TabIndex = 11;
            this.txt_namketthuc.TextChanged += new System.EventHandler(this.txt_namketthuc_TextChanged);
            this.txt_namketthuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_namketthuc_KeyPress);
            // 
            // txt_nambatdau
            // 
            this.txt_nambatdau.Location = new System.Drawing.Point(433, 50);
            this.txt_nambatdau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nambatdau.Name = "txt_nambatdau";
            this.txt_nambatdau.Size = new System.Drawing.Size(76, 20);
            this.txt_nambatdau.TabIndex = 10;
            this.txt_nambatdau.TextChanged += new System.EventHandler(this.txt_nambatdau_TextChanged);
            this.txt_nambatdau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nambatdau_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năm kết thúc";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Năm bắt đầu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên khóa học";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã khóa học";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_tenkhoahoc
            // 
            this.txt_tenkhoahoc.Location = new System.Drawing.Point(154, 106);
            this.txt_tenkhoahoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tenkhoahoc.Name = "txt_tenkhoahoc";
            this.txt_tenkhoahoc.Size = new System.Drawing.Size(76, 20);
            this.txt_tenkhoahoc.TabIndex = 1;
            this.txt_tenkhoahoc.TextChanged += new System.EventHandler(this.txt_tenkhoahoc_TextChanged);
            // 
            // txt_makhoahoc
            // 
            this.txt_makhoahoc.Location = new System.Drawing.Point(154, 50);
            this.txt_makhoahoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_makhoahoc.Name = "txt_makhoahoc";
            this.txt_makhoahoc.Size = new System.Drawing.Size(76, 20);
            this.txt_makhoahoc.TabIndex = 0;
            this.txt_makhoahoc.TextChanged += new System.EventHandler(this.txt_makhoahoc_TextChanged);
            this.txt_makhoahoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_makhoahoc_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoahoc,
            this.tenkhoahoc,
            this.nambatdau,
            this.namketthuc});
            this.dataGridView1.Location = new System.Drawing.Point(2, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 300);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // makhoahoc
            // 
            this.makhoahoc.DataPropertyName = "makhoahoc";
            this.makhoahoc.HeaderText = "Mã khóa học";
            this.makhoahoc.MinimumWidth = 6;
            this.makhoahoc.Name = "makhoahoc";
            // 
            // tenkhoahoc
            // 
            this.tenkhoahoc.DataPropertyName = "tenkhoahoc";
            this.tenkhoahoc.HeaderText = "Tên khóa học";
            this.tenkhoahoc.MinimumWidth = 6;
            this.tenkhoahoc.Name = "tenkhoahoc";
            // 
            // nambatdau
            // 
            this.nambatdau.DataPropertyName = "nambatdau";
            this.nambatdau.HeaderText = "Năm bắt đầu";
            this.nambatdau.MinimumWidth = 6;
            this.nambatdau.Name = "nambatdau";
            // 
            // namketthuc
            // 
            this.namketthuc.DataPropertyName = "namketthuc";
            this.namketthuc.HeaderText = "Năm kết thúc";
            this.namketthuc.MinimumWidth = 6;
            this.namketthuc.Name = "namketthuc";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1182, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Khóa Học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // txt_timkiem
            // 
            this.txt_timkiem.ForeColor = System.Drawing.Color.Gray;
            this.txt_timkiem.Location = new System.Drawing.Point(146, 21);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(98, 20);
            this.txt_timkiem.TabIndex = 6;
            this.txt_timkiem.Text = "Nhập mã";
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Enter += new System.EventHandler(this.txt_timkiem_Enter);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // txt_timkiem2
            // 
            this.txt_timkiem2.ForeColor = System.Drawing.Color.Gray;
            this.txt_timkiem2.Location = new System.Drawing.Point(256, 21);
            this.txt_timkiem2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_timkiem2.Name = "txt_timkiem2";
            this.txt_timkiem2.Size = new System.Drawing.Size(98, 20);
            this.txt_timkiem2.TabIndex = 7;
            this.txt_timkiem2.Text = "Nhập tên";
            this.txt_timkiem2.TextChanged += new System.EventHandler(this.txt_timkiem2_TextChanged);
            this.txt_timkiem2.Enter += new System.EventHandler(this.txt_timkiem2_Enter);
            this.txt_timkiem2.Leave += new System.EventHandler(this.txt_timkiem2_Leave);
            // 
            // btn_nhapexcel
            // 
            this.btn_nhapexcel.Image = global::diem.Properties.Resources.icons8_microsoft_excel_24;
            this.btn_nhapexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhapexcel.Location = new System.Drawing.Point(1044, 14);
            this.btn_nhapexcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nhapexcel.Name = "btn_nhapexcel";
            this.btn_nhapexcel.Size = new System.Drawing.Size(98, 32);
            this.btn_nhapexcel.TabIndex = 6;
            this.btn_nhapexcel.Text = "Nhập Excel";
            this.btn_nhapexcel.UseVisualStyleBackColor = true;
            this.btn_nhapexcel.Click += new System.EventHandler(this.btn_nhapexcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_nhapfile);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Controls.Add(this.txt_timkiem2);
            this.panel1.Controls.Add(this.btn_nhapexcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 57);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_nhapfile
            // 
            this.txt_nhapfile.Location = new System.Drawing.Point(688, 21);
            this.txt_nhapfile.Name = "txt_nhapfile";
            this.txt_nhapfile.Size = new System.Drawing.Size(338, 20);
            this.txt_nhapfile.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // khoahoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "khoahoc";
            this.Size = new System.Drawing.Size(1182, 692);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xuatexcel;
        private System.Windows.Forms.Button btn_trang;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem2;
        private System.Windows.Forms.Button btn_nhapexcel;
        private System.Windows.Forms.TextBox txt_tenkhoahoc;
        private System.Windows.Forms.TextBox txt_makhoahoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_namketthuc;
        private System.Windows.Forms.TextBox txt_nambatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nambatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn namketthuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_nhapfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
