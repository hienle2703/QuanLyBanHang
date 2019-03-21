namespace QLBH
{
    partial class form_QLKH
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
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.btn_SuaKH = new System.Windows.Forms.Button();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.txt_TimKH = new System.Windows.Forms.TextBox();
            this.btn_TimKH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_KH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.Location = new System.Drawing.Point(6, 19);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemKH.TabIndex = 0;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.UseVisualStyleBackColor = true;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.Location = new System.Drawing.Point(87, 19);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaKH.TabIndex = 0;
            this.btn_SuaKH.Text = "Sửa";
            this.btn_SuaKH.UseVisualStyleBackColor = true;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.Location = new System.Drawing.Point(168, 19);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaKH.TabIndex = 0;
            this.btn_XoaKH.Text = "Xóa";
            this.btn_XoaKH.UseVisualStyleBackColor = true;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // txt_TimKH
            // 
            this.txt_TimKH.Location = new System.Drawing.Point(16, 22);
            this.txt_TimKH.Name = "txt_TimKH";
            this.txt_TimKH.Size = new System.Drawing.Size(222, 20);
            this.txt_TimKH.TabIndex = 1;
            // 
            // btn_TimKH
            // 
            this.btn_TimKH.Location = new System.Drawing.Point(244, 20);
            this.btn_TimKH.Name = "btn_TimKH";
            this.btn_TimKH.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKH.TabIndex = 0;
            this.btn_TimKH.Text = "Tìm kiếm";
            this.btn_TimKH.UseVisualStyleBackColor = true;
            this.btn_TimKH.Click += new System.EventHandler(this.btn_TimKH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TimKH);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_TimKH);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaKH);
            this.groupBox2.Controls.Add(this.btn_SuaKH);
            this.groupBox2.Controls.Add(this.btn_ThemKH);
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // list_KH
            // 
            this.list_KH.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.list_KH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list_KH.Location = new System.Drawing.Point(30, 99);
            this.list_KH.MultiSelect = false;
            this.list_KH.Name = "list_KH";
            this.list_KH.Size = new System.Drawing.Size(711, 318);
            this.list_KH.TabIndex = 5;
            this.list_KH.UseCompatibleStateImageBehavior = false;
            this.list_KH.View = System.Windows.Forms.View.Details;
            this.list_KH.DoubleClick += new System.EventHandler(this.list_KH_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Mã khách hàng";
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
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số điện thoại";
            this.columnHeader4.Width = 100;
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
            // form_QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.list_KH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_QLKH";
            this.Text = "Quản lý khách hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.Button btn_SuaKH;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.TextBox txt_TimKH;
        private System.Windows.Forms.Button btn_TimKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView list_KH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_clear;
    }
}