namespace QLBH.QLKH
{
    partial class form_ThemSuaKH
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
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_Cancer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(44, 54);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(180, 22);
            this.txt_Ten.TabIndex = 0;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(44, 113);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(180, 22);
            this.txt_DiaChi.TabIndex = 0;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(44, 174);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(180, 22);
            this.txt_SDT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại";
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(113, 232);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(68, 30);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "Thêm";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_Cancer
            // 
            this.btn_Cancer.Location = new System.Drawing.Point(187, 232);
            this.btn_Cancer.Name = "btn_Cancer";
            this.btn_Cancer.Size = new System.Drawing.Size(68, 30);
            this.btn_Cancer.TabIndex = 2;
            this.btn_Cancer.Text = "Hủy";
            this.btn_Cancer.UseVisualStyleBackColor = true;
            this.btn_Cancer.Click += new System.EventHandler(this.btn_Cancer_Click);
            // 
            // form_ThemSuaKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 284);
            this.Controls.Add(this.btn_Cancer);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_Ten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_ThemSuaKH";
            this.Text = "Thông tin khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_Cancer;
    }
}