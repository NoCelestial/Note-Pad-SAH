using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;

namespace Note_pad
{
    public partial class Form1 : Form
    {
        int index;
        string filename;
        string fileloc;
        Boolean fileflag;
        bool w;

        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiexit_Click(object sender, EventArgs e)
        {
            Form1_FormClosing(null, null);
        }
        private void tsmifont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtshow.Font;
            fontDialog1.ShowDialog();
            txtshow.Font = fontDialog1.Font;
        }

        private void tsmistatusbar_Click(object sender, EventArgs e)
        {
            statusbar.Visible = ((ToolStripMenuItem)sender).Checked;
        }

        private void tsmiforecolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtshow.ForeColor = colorDialog1.Color;
        }

        private void tsmibackcolor_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            txtshow.BackColor = colorDialog2.Color;
        }

        private void stmiwordwrap_Click(object sender, EventArgs e)
        {
            txtshow.WordWrap = stmiwordwrap.Checked;
            if (stmiwordwrap.Checked)
                tsmigoto.Enabled = false;
            else
                tsmigoto.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileflag != true)
            {
                DialogResult r;
                r = MessageBox.Show("Do You Want Save This File ?", "Save ...", MessageBoxButtons.YesNo);
                switch (r)
                {
                    case (DialogResult.Yes):
                        tsmisave_Click(null, null);
                        break;
                    case (DialogResult.No):
                        //System.IO.File.Delete(@"F:\SAH\Note Pad\Log\logfile.txt");
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusbar.Visible = false;
            fileflag = true;
            string[] log = new string[8];
            
            try
            {
                log = System.IO.File.ReadAllLines(@"C:\SAH\Note Pad\Log\logfile.txt");
                this.Width = Convert.ToInt32(log[0]);
                this.Height = Convert.ToInt32(log[7]);
                txtshow.BackColor = Color.FromName(log[4]);
                txtshow.ForeColor = Color.FromName(log[5]);
                txtshow.WordWrap = Convert.ToBoolean(log[6]);

            }
            catch
            {
                setDefalutFormToolStripMenuItem_Click(null, null);

            }
            try
            {
                string m = System.IO.File.ReadAllText(fileloc);
                if (fileflag)
                    txtshow.Text = m;
            }
            catch
            {

            }


        }

        private void tsmisave_Click(object sender, EventArgs e)
        {

            if (fileloc == null)
            {
                saveFileDialog1.Filter = "Text files (*.txt) | *.txt";
                saveFileDialog1.FileName = "untitled";
                saveFileDialog1.ShowDialog();
                fileloc = saveFileDialog1.FileName;
                filename = saveFileDialog1.FileName;
            }
            string[] log = new string[8];
            log[0] = this.Width.ToString();
            log[1] = txtshow.Font.Name;
            log[2] = txtshow.Font.Size.ToString();
            log[3] = txtshow.Font.Style.ToString();
            log[4] = txtshow.BackColor.Name.ToString();
            log[5] = txtshow.ForeColor.Name.ToString();
            log[6] = txtshow.WordWrap.ToString();
            log[7] = this.Height.ToString();
            System.IO.Directory.CreateDirectory(@"C:\SAH");
            System.IO.Directory.CreateDirectory(@"C:\SAH\Note Pad");
            System.IO.Directory.CreateDirectory(@"C:\SAH\Note Pad\Log");
            System.IO.File.WriteAllLines(@"C:\SAH\Note Pad\Log\logfile.txt", log);
            System.IO.File.WriteAllText(fileloc, txtshow.Text);
            fileflag = true;
            this.Text = fileloc + "_ Note Pad SAH _";

        }

        private void tsmisaveas_Click(object sender, EventArgs e)
        {
            fileloc = null;
            tsmisave_Click(null, null);
        }

        private void setDefalutFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtshow.WordWrap = false;
            txtshow.BackColor = Color.White;
            txtshow.ForeColor = Color.Black;

        }

        private void tsmiopen_Click(object sender, EventArgs e)
        {
            tsminew_Click(null, null);
            openFileDialog1.FileName = "untitled.txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            fileloc = openFileDialog1.FileName;
            try
            {
                txtshow.Text = System.IO.File.ReadAllText(fileloc);
            }
            catch
            {

            }
            this.Text = fileloc + "_Note Pad SAH_";
            fileflag = true;

        }

        private void tsminew_Click(object sender, EventArgs e)
        {
            if (fileflag != true)
            {
                Form1_FormClosing(null, null);
                setDefalutFormToolStripMenuItem_Click(null, null);

            }
            this.Text = "Note Pad SAH";
            fileflag = true;
            fileloc = null;
            txtshow.Clear();

        }

        private void txtshow_TextChanged(object sender, EventArgs e)
        {
            getrowcol();
            if (w)
            {
                tsmlready.Text = "You Are Writing";
                w = false;
            }
            else
            {
                tsmlready.Text = "Get Is Ready For Use You ... ";
                w = true;
            }

            fileflag = false;
            setenabel();
        }

        private void tsmifind_Click(object sender, EventArgs e)
        {
            frmfind find = new frmfind(this);
            find.Show(this);
        }

        private void tsmicopy_Click(object sender, EventArgs e)
        {
            txtshow.Copy();
        }

        private void tsmicut_Click(object sender, EventArgs e)
        {
            txtshow.Cut();
        }

        private void tsmipaste_Click(object sender, EventArgs e)
        {
            txtshow.Paste();
        }

        private void tsmiundo_Click(object sender, EventArgs e)
        {
            txtshow.Undo();
        }

        private void tsmiredo_Click(object sender, EventArgs e)
        {

        }

        private void tsmiselall_Click(object sender, EventArgs e)
        {
            txtshow.SelectAll();
        }

        private void tsmiabout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show(this);
        }

        public Boolean find(string txt)
        {

            int a;
            a = txtshow.Text.IndexOf(txt, index);
            if (a == -1)
            {
                MessageBox.Show("Your Text Is Not Defined !!", "Erorr", MessageBoxButtons.OK);
                index = 0;
                return false;
            }
            else
            {
                txtshow.SelectionStart = a;
                txtshow.SelectionLength = txt.Length;
                txtshow.Focus();
                index = a + 1;
                return true;
            }
        }

        public Boolean wrap(string txt)
        {
            int a;
            a = txtshow.Text.IndexOf(txt, index);
            if (a == -1)
            {
                index = 0;
                txtshow.SelectionStart = 0;
                txtshow.SelectionLength = txt.Length;
                txtshow.Focus();
                return false;
            }
            else
            {
                txtshow.SelectionStart = a;
                txtshow.SelectionLength = txt.Length;
                txtshow.Focus();
                index = a + 1;
                return true;
            }
        }

        private void tsmigoto_Click(object sender, EventArgs e)
        {
            frmgoto fromgoto = new frmgoto(this);
            fromgoto.ShowDialog();
        }

        public int getline()
        {
            return txtshow.Lines.Count();
        }

        public void truelinegeter(int x)
        {
            txtshow.SelectionStart = txtshow.GetFirstCharIndexFromLine(x);
        }

        private void tsmireplace_Click(object sender, EventArgs e)
        {

        }

        public void getrowcol()
        {
            int row = txtshow.GetLineFromCharIndex(txtshow.SelectionStart) + 1;
            int col = txtshow.SelectionStart - txtshow.GetFirstCharIndexOfCurrentLine() + 1;
            tsmlrow.Text = "Ln " + row.ToString();
            tsmlcol.Text = "Col " + col.ToString();
        }

        private void txtshow_TextChanged(object sender, KeyEventArgs e)
        {
            getrowcol();
            setenabel();
        }

        private void txtshow_TextChanged(object sender, MouseEventArgs e)
        {
            getrowcol();
            setenabel();
        }

        private void txtshow_TextChanged(object sender, KeyPressEventArgs e)
        {
            getrowcol();
            setenabel();
        }

        private void txtshow_Click(object sender, EventArgs e)
        {
            getrowcol();
            setenabel();
        }

        public void setenabel()
        {
            tsmicopy.Enabled = txtshow.SelectionLength > 0;
            tsmicut.Enabled = txtshow.SelectionLength > 0;
            tsmipaste.Enabled = Clipboard.ContainsText();
            tsmidel.Enabled = txtshow.SelectionLength > 0;
            tsmisave.Enabled = !fileflag;
            tsmifind.Enabled = txtshow.TextLength > 0;

        }

        private void tsmidel_Click(object sender, EventArgs e)
        {
            txtshow.Clear();
        }

        private void set(object sender, EventArgs e)
        {
            setenabel();
        }

        private void tsmiprint_Click(object sender, EventArgs e)
        {
            DialogResult print;
            printDialog1.Document = printDocument1;
            print = printDialog1.ShowDialog(this);

            if (print == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtshow.Text, txtshow.Font, Brushes.Black, 0, 0);
        }

        private void tsmiprintp_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show(this);
        }
    }
}
