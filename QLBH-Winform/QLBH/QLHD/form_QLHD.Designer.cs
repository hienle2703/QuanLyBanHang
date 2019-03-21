namespace QLBH.QLHD
{
     partial class form_QLHD
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
            this.btn_XemHD = new System.Windows.Forms.Button();
            this.btn_SuaHD = new System.Windows.Forms.Button();
            this.btn_XoaHD = new System.Windows.Forms.Button();
            this.txt_TimHD = new System.Windows.Forms.TextBox();
            this.btn_TimHD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_HD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_XemHD
            // 
            this.btn_XemHD.Location = new System.Drawing.Point(6, 19);
            this.btn_XemHD.Name = "btn_XemHD";
            this.btn_XemHD.Size = new System.Drawing.Size(75, 23);
            this.btn_XemHD.TabIndex = 0;
            this.btn_XemHD.Text = "Xem";
            this.btn_XemHD.UseVisualStyleBackColor = true;
            this.btn_XemHD.Click += new System.EventHandler(this.btn_XemHD_Click);
            // 
            // btn_SuaHD
            // 
            this.btn_SuaHD.Enabled = false;
            this.btn_SuaHD.Location = new System.Drawing.Point(87, 19);
            this.btn_SuaHD.Name = "btn_SuaHD";
            this.btn_SuaHD.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaHD.TabIndex = 0;
            this.btn_SuaHD.Text = "Sửa";
            this.btn_SuaHD.UseVisualStyleBackColor = true;
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.Enabled = false;
            this.btn_XoaHD.Location = new System.Drawing.Point(168, 19);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaHD.TabIndex = 0;
            this.btn_XoaHD.Text = "Xóa";
            this.btn_XoaHD.UseVisualStyleBackColor = true;
            // 
            // txt_TimHD
            // 
            this.txt_TimHD.Location = new System.Drawing.Point(16, 22);
            this.txt_TimHD.Name = "txt_TimHD";
            this.txt_TimHD.Size = new System.Drawing.Size(222, 20);
            this.txt_TimHD.TabIndex = 1;
            // 
            // btn_TimHD
            // 
            this.btn_TimHD.Location = new System.Drawing.Point(244, 20);
            this.btn_TimHD.Name = "btn_TimHD";
            this.btn_TimHD.Size = new System.Drawing.Size(75, 23);
            this.btn_TimHD.TabIndex = 0;
            this.btn_TimHD.Text = "Tìm kiếm";
            this.btn_TimHD.UseVisualStyleBackColor = true;
            this.btn_TimHD.Click += new System.EventHandler(this.btn_TimHD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TimHD);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_TimHD);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(325, 20);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(32, 23);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "❌";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaHD);
            this.groupBox2.Controls.Add(this.btn_SuaHD);
            this.groupBox2.Controls.Add(this.btn_XemHD);
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // list_HD
            // 
            this.list_HD.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.list_HD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.list_HD.Location = new System.Drawing.Point(30, 99);
            this.list_HD.MultiSelect = false;
            this.list_HD.Name = "list_HD";
            this.list_HD.Size = new System.Drawing.Size(711, 318);
            this.list_HD.TabIndex = 5;
            this.list_HD.UseCompatibleStateImageBehavior = false;
            this.list_HD.View = System.Windows.Forms.View.Details;
            this.list_HD.DoubleClick += new System.EventHandler(this.list_HD_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Mã hóa đơn";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Họ tên khách hàng";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày lập phiếu";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày giao hàng";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tình trạng";
            this.columnHeader5.Width = 100;
            // 
            // form_QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.list_HD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_QLHD";
            this.Text = "Quản lý hóa đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_XemHD;
        private System.Windows.Forms.Button btn_SuaHD;
        private System.Windows.Forms.Button btn_XoaHD;
        private System.Windows.Forms.TextBox txt_TimHD;
        private System.Windows.Forms.Button btn_TimHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView list_HD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}