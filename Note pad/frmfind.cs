using System;
using System.Windows.Forms;

namespace Note_pad
{
    public partial class frmfind : Form
    {
        Form1 frmmain;
        public frmfind(Form1 frm)
        {
            frmmain = frm;
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (chbwrap.Checked)
                frmmain.wrap(txtwhat.Text);
            else
                frmmain.find(txtwhat.Text);
        }
   
        
    }
}
