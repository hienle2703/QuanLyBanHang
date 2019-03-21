namespace QLBH.QLHD
{
    partial class form_XemHD
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_MaHD = new System.Windows.Forms.Label();
            this.txt_HoTenKH = new System.Windows.Forms.Label();
            this.txt_NgayLap = new System.Windows.Forms.Label();
            this.txt_NgayGiao = new System.Windows.Forms.Label();
            this.txt_TinhTrang = new System.Windows.Forms.Label();
            this.cb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_TongTien = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.Label();
            this.txt_TienTra = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_cancer = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.AutoSize = true;
            this.txt_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHD.Location = new System.Drawing.Point(39, 28);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(81, 20);
            this.txt_MaHD.TabIndex = 0;
            this.txt_MaHD.Text = "txt_MaHD";
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.AutoSize = true;
            this.txt_HoTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenKH.Location = new System.Drawing.Point(39, 71);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Size = new System.Drawing.Size(105, 20);
            this.txt_HoTenKH.TabIndex = 0;
            this.txt_HoTenKH.Text = "txt_HoTenKH";
            // 
            // txt_NgayLap
            // 
            this.txt_NgayLap.AutoSize = true;
            this.txt_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayLap.Location = new System.Drawing.Point(38, 113);
            this.txt_NgayLap.Name = "txt_NgayLap";
            this.txt_NgayLap.Size = new System.Drawing.Size(98, 20);
            this.txt_NgayLap.TabIndex = 0;
            this.txt_NgayLap.Text = "txt_NgayLap";
            // 
            // txt_NgayGiao
            // 
            this.txt_NgayGiao.AutoSize = true;
            this.txt_NgayGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayGiao.Location = new System.Drawing.Point(38, 158);
            this.txt_NgayGiao.Name = "txt_NgayGiao";
            this.txt_NgayGiao.Size = new System.Drawing.Size(105, 20);
            this.txt_NgayGiao.TabIndex = 0;
            this.txt_NgayGiao.Text = "txt_NgayGiao";
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.AutoSize = true;
            this.txt_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TinhTrang.Location = new System.Drawing.Point(38, 208);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(84, 20);
            this.txt_TinhTrang.TabIndex = 0;
            this.txt_TinhTrang.Text = "Tình trạng:";
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.FormattingEnabled = true;
            this.cb_TinhTrang.Location = new System.Drawing.Point(43, 234);
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(121, 21);
            this.cb_TinhTrang.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sản phẩm:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(326, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(249, 170);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Thiết bị";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SL";
            this.columnHeader3.Width = 25;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.AutoSize = true;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(327, 231);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(79, 20);
            this.txt_TongTien.TabIndex = 0;
            this.txt_TongTien.Text = "Tổng tiền:";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.AutoSize = true;
            this.txt_GiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiamGia.Location = new System.Drawing.Point(327, 258);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(76, 20);
            this.txt_GiamGia.TabIndex = 0;
            this.txt_GiamGia.Text = "Giảm giá:";
            // 
            // txt_TienTra
            // 
            this.txt_TienTra.AutoSize = true;
            this.txt_TienTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TienTra.Location = new System.Drawing.Point(328, 285);
            this.txt_TienTra.Name = "txt_TienTra";
            this.txt_TienTra.Size = new System.Drawing.Size(66, 20);
            this.txt_TienTra.TabIndex = 0;
            this.txt_TienTra.Text = "Tiền trả:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(428, 322);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(95, 30);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu tình trạng";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_cancer
            // 
            this.btn_cancer.Location = new System.Drawing.Point(529, 322);
            this.btn_cancer.Name = "btn_cancer";
            this.btn_cancer.Size = new System.Drawing.Size(46, 30);
            this.btn_cancer.TabIndex = 3;
            this.btn_cancer.Text = "Hủy";
            this.btn_cancer.UseVisualStyleBackColor = true;
            this.btn_cancer.Click += new System.EventHandler(this.btn_cancer_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 80;
            // 
            // form_XemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.btn_cancer);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cb_TinhTrang);
            this.Controls.Add(this.txt_TinhTrang);
            this.Controls.Add(this.txt_NgayGiao);
            this.Controls.Add(this.txt_NgayLap);
            this.Controls.Add(this.txt_HoTenKH);
            this.Controls.Add(this.txt_TienTra);
            this.Controls.Add(this.txt_GiamGia);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_MaHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_XemHD";
            this.Text = "Thông tin hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_MaHD;
        private System.Windows.Forms.Label txt_HoTenKH;
        private System.Windows.Forms.Label txt_NgayLap;
        private System.Windows.Forms.Label txt_NgayGiao;
        private System.Windows.Forms.Label txt_TinhTrang;
        private System.Windows.Forms.ComboBox cb_TinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label txt_TongTien;
        private System.Windows.Forms.Label txt_GiamGia;
        private System.Windows.Forms.Label txt_TienTra;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_cancer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}