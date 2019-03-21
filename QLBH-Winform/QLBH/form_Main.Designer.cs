namespace QLBH
{
    partial class form_Main
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
            this.btn_QLTB = new System.Windows.Forms.Button();
            this.btn_QLKH = new System.Windows.Forms.Button();
            this.btn_QLHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QLTB
            // 
            this.btn_QLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTB.Location = new System.Drawing.Point(144, 105);
            this.btn_QLTB.Name = "btn_QLTB";
            this.btn_QLTB.Size = new System.Drawing.Size(155, 32);
            this.btn_QLTB.TabIndex = 0;
            this.btn_QLTB.Text = "Quản lý thiết bị";
            this.btn_QLTB.UseVisualStyleBackColor = true;
            this.btn_QLTB.Click += new System.EventHandler(this.btn_QLTB_Click);
            // 
            // btn_QLKH
            // 
            this.btn_QLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLKH.Location = new System.Drawing.Point(144, 50);
            this.btn_QLKH.Name = "btn_QLKH";
            this.btn_QLKH.Size = new System.Drawing.Size(155, 32);
            this.btn_QLKH.TabIndex = 0;
            this.btn_QLKH.Text = "Quản lý khách hàng";
            this.btn_QLKH.UseVisualStyleBackColor = true;
            this.btn_QLKH.Click += new System.EventHandler(this.btn_QLKH_Click);
            // 
            // btn_QLHD
            // 
            this.btn_QLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD.Location = new System.Drawing.Point(144, 162);
            this.btn_QLHD.Name = "btn_QLHD";
            this.btn_QLHD.Size = new System.Drawing.Size(155, 32);
            this.btn_QLHD.TabIndex = 0;
            this.btn_QLHD.Text = "Quản lý hóa đơn";
            this.btn_QLHD.UseVisualStyleBackColor = true;
            this.btn_QLHD.Click += new System.EventHandler(this.btn_QLHD_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 235);
            this.Controls.Add(this.btn_QLHD);
            this.Controls.Add(this.btn_QLKH);
            this.Controls.Add(this.btn_QLTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_Main";
            this.ShowIcon = false;
            this.Text = "Phần mềm quản lý bán hàng by AresVN";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_QLTB;
        private System.Windows.Forms.Button btn_QLKH;
        private System.Windows.Forms.Button btn_QLHD;
    }
}

