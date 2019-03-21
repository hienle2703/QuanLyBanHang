using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private void btn_QLKH_Click(object sender, EventArgs e)
        {
            form_QLKH form_QLKH = new form_QLKH();
            form_QLKH.Show();
        }

        private void btn_QLTB_Click(object sender, EventArgs e)
        {
            QLTB.form_QLTB form_QLTB = new QLTB.form_QLTB();
            form_QLTB.Show();
        }

        private void btn_QLHD_Click(object sender, EventArgs e)
        {
            QLHD.form_QLHD form_QLHD = new QLHD.form_QLHD();
            form_QLHD.Show();
        }
    }
}
