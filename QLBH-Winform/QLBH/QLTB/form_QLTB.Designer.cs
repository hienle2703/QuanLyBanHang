namespace QLBH.QLTB
{
    public partial class form_QLTB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TimTB = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_TimTB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XoaTB = new System.Windows.Forms.Button();
            this.btn_SuaTB = new System.Windows.Forms.Button();
            this.btn_ThemTB = new System.Windows.Forms.Button();
            this.list_TB = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TimTB);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_TimTB);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txt_TimTB
            // 
            this.txt_TimTB.Location = new System.Drawing.Point(16, 22);
            this.txt_TimTB.Name = "txt_TimTB";
            this.txt_TimTB.Size = new System.Drawing.Size(222, 20);
            this.txt_TimTB.TabIndex = 1;
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
            // btn_TimTB
            // 
            this.btn_TimTB.Location = new System.Drawing.Point(244, 20);
            this.btn_TimTB.Name = "btn_TimTB";
            this.btn_TimTB.Size = new System.Drawing.Size(75, 23);
            this.btn_TimTB.TabIndex = 0;
            this.btn_TimTB.Text = "Tìm kiếm";
            this.btn_TimTB.UseVisualStyleBackColor = true;
            this.btn_TimTB.Click += new System.EventHandler(this.btn_TimTB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaTB);
            this.groupBox2.Controls.Add(this.btn_SuaTB);
            this.groupBox2.Controls.Add(this.btn_ThemTB);
            this.groupBox2.Location = new System.Drawing.Point(469, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 59);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btn_XoaTB
            // 
            this.btn_XoaTB.Location = new System.Drawing.Point(168, 19);
            this.btn_XoaTB.Name = "btn_XoaTB";
            this.btn_XoaTB.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaTB.TabIndex = 0;
            this.btn_XoaTB.Text = "Xóa";
            this.btn_XoaTB.UseVisualStyleBackColor = true;
            this.btn_XoaTB.Click += new System.EventHandler(this.btn_XoaTB_Click);
            // 
            // btn_SuaTB
            // 
            this.btn_SuaTB.Location = new System.Drawing.Point(87, 19);
            this.btn_SuaTB.Name = "btn_SuaTB";
            this.btn_SuaTB.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaTB.TabIndex = 0;
            this.btn_SuaTB.Text = "Sửa";
            this.btn_SuaTB.UseVisualStyleBackColor = true;
            this.btn_SuaTB.Click += new System.EventHandler(this.btn_SuaTB_Click);
            // 
            // btn_ThemTB
            // 
            this.btn_ThemTB.Location = new System.Drawing.Point(6, 19);
            this.btn_ThemTB.Name = "btn_ThemTB";
            this.btn_ThemTB.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemTB.TabIndex = 0;
            this.btn_ThemTB.Text = "Thêm";
            this.btn_ThemTB.UseVisualStyleBackColor = true;
            this.btn_ThemTB.Click += new System.EventHandler(this.btn_ThemTB_Click);
            // 
            // list_TB
            // 
            this.list_TB.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.list_TB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
            this.list_TB.Location = new System.Drawing.Point(26, 85);
            this.list_TB.MultiSelect = false;
            this.list_TB.Name = "list_TB";
            this.list_TB.Size = new System.Drawing.Size(696, 318);
            this.list_TB.TabIndex = 6;
            this.list_TB.UseCompatibleStateImageBehavior = false;
            this.list_TB.View = System.Windows.Forms.View.Details;
            this.list_TB.DoubleClick += new System.EventHandler(this.list_TB_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Mã thiết bị";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Tên Thiết Bị";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Loại";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thông Tin Chi Tiết";
            this.columnHeader5.Width = 200;
            // 
            // form_QLTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 445);
            this.Controls.Add(this.list_TB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_QLTB";
            this.Text = "Quản Lý Thiết Bị";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TimTB;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_TimTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XoaTB;
        private System.Windows.Forms.Button btn_SuaTB;
        private System.Windows.Forms.Button btn_ThemTB;
        private System.Windows.Forms.ListView list_TB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}