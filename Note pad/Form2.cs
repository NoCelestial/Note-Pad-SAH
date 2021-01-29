using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_pad
{
    public partial class frmgoto : Form
    {
        Form1 frmmain;
        public frmgoto(Form1 frm)
        {
            frmmain = frm;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtlinenum.Text = frmmain.getline().ToString();
            txtlinenum.SelectAll();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngoto_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtlinenum.Text) - 1;
            if (a > frmmain.getline())
            {
                MessageBox.Show("Your Selected Number Or Line Is Out Of Range !!", "Error");
                Form2_Load(null,null);
                txtlinenum.SelectAll();
                txtlinenum.Focus();
            }
            else
            {
                frmmain.truelinegeter(a);
                btncancel_Click(null, null);
            }
        }
    }
}
