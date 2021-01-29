namespace Note_pad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtshow = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsminew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiopen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisdf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmisave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiprint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiprintp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiexit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiundo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiredo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmicut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmipaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiselall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmifind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmireplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmigoto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmformat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmibackcolor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiforecolor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmifont = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiwordwrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmistatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmhrlp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiabout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.tsmlcol = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmlrow = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmlsap = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmlready = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtshow
            // 
            this.txtshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtshow.Location = new System.Drawing.Point(0, 25);
            this.txtshow.Margin = new System.Windows.Forms.Padding(4);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtshow.Size = new System.Drawing.Size(734, 431);
            this.txtshow.TabIndex = 0;
            this.txtshow.WordWrap = false;
            this.txtshow.Click += new System.EventHandler(this.txtshow_Click);
            this.txtshow.TextChanged += new System.EventHandler(this.txtshow_TextChanged);
            this.txtshow.Enter += new System.EventHandler(this.txtshow_TextChanged);
            this.txtshow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtshow_TextChanged);
            this.txtshow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtshow_TextChanged);
            this.txtshow.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtshow_TextChanged);
            this.txtshow.MouseEnter += new System.EventHandler(this.txtshow_TextChanged);
            this.txtshow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtshow_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmfile,
            this.toolStripMenuItem11,
            this.tsmformat,
            this.tsmview,
            this.tsmhrlp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(734, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmfile
            // 
            this.tsmfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsminew,
            this.tsmiopen,
            this.tsmisdf,
            this.toolStripSeparator,
            this.tsmisave,
            this.tsmisaveas,
            this.toolStripSeparator1,
            this.tsmiprint,
            this.tsmiprintp,
            this.toolStripSeparator2,
            this.tsmiexit});
            this.tsmfile.Name = "tsmfile";
            this.tsmfile.Size = new System.Drawing.Size(37, 19);
            this.tsmfile.Text = "&File";
            this.tsmfile.DropDownOpening += new System.EventHandler(this.set);
            // 
            // tsminew
            // 
            this.tsminew.Image = ((System.Drawing.Image)(resources.GetObject("tsminew.Image")));
            this.tsminew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsminew.Name = "tsminew";
            this.tsminew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsminew.Size = new System.Drawing.Size(257, 22);
            this.tsminew.Text = "&New";
            this.tsminew.Click += new System.EventHandler(this.tsminew_Click);
            // 
            // tsmiopen
            // 
            this.tsmiopen.Image = ((System.Drawing.Image)(resources.GetObject("tsmiopen.Image")));
            this.tsmiopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiopen.Name = "tsmiopen";
            this.tsmiopen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiopen.Size = new System.Drawing.Size(257, 22);
            this.tsmiopen.Text = "&Open";
            this.tsmiopen.Click += new System.EventHandler(this.tsmiopen_Click);
            // 
            // tsmisdf
            // 
            this.tsmisdf.Name = "tsmisdf";
            this.tsmisdf.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmisdf.Size = new System.Drawing.Size(257, 22);
            this.tsmisdf.Text = "Set Defalut Form";
            this.tsmisdf.Click += new System.EventHandler(this.setDefalutFormToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmisave
            // 
            this.tsmisave.Image = ((System.Drawing.Image)(resources.GetObject("tsmisave.Image")));
            this.tsmisave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmisave.Name = "tsmisave";
            this.tsmisave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmisave.Size = new System.Drawing.Size(257, 22);
            this.tsmisave.Text = "&Save";
            this.tsmisave.Click += new System.EventHandler(this.tsmisave_Click);
            // 
            // tsmisaveas
            // 
            this.tsmisaveas.Image = ((System.Drawing.Image)(resources.GetObject("tsmisaveas.Image")));
            this.tsmisaveas.Name = "tsmisaveas";
            this.tsmisaveas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmisaveas.Size = new System.Drawing.Size(257, 22);
            this.tsmisaveas.Text = "Save &As";
            this.tsmisaveas.Click += new System.EventHandler(this.tsmisaveas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmiprint
            // 
            this.tsmiprint.Image = ((System.Drawing.Image)(resources.GetObject("tsmiprint.Image")));
            this.tsmiprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiprint.Name = "tsmiprint";
            this.tsmiprint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiprint.Size = new System.Drawing.Size(257, 22);
            this.tsmiprint.Text = "&Print";
            this.tsmiprint.Click += new System.EventHandler(this.tsmiprint_Click);
            // 
            // tsmiprintp
            // 
            this.tsmiprintp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiprintp.Image")));
            this.tsmiprintp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiprintp.Name = "tsmiprintp";
            this.tsmiprintp.Size = new System.Drawing.Size(257, 22);
            this.tsmiprintp.Text = "Print Pre&view";
            this.tsmiprintp.Click += new System.EventHandler(this.tsmiprintp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmiexit
            // 
            this.tsmiexit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiexit.Image")));
            this.tsmiexit.Name = "tsmiexit";
            this.tsmiexit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.tsmiexit.Size = new System.Drawing.Size(257, 22);
            this.tsmiexit.Text = "E&xit";
            this.tsmiexit.Click += new System.EventHandler(this.tsmiexit_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiundo,
            this.tsmiredo,
            this.toolStripSeparator8,
            this.tsmicut,
            this.tsmicopy,
            this.tsmipaste,
            this.tsmidel,
            this.toolStripSeparator9,
            this.tsmiselall,
            this.toolStripSeparator10,
            this.tsmifind,
            this.tsmireplace,
            this.tsmigoto});
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(39, 19);
            this.toolStripMenuItem11.Text = "&Edit";
            this.toolStripMenuItem11.DropDownOpening += new System.EventHandler(this.set);
            // 
            // tsmiundo
            // 
            this.tsmiundo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiundo.Image")));
            this.tsmiundo.Name = "tsmiundo";
            this.tsmiundo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiundo.Size = new System.Drawing.Size(164, 22);
            this.tsmiundo.Text = "&Undo";
            this.tsmiundo.Click += new System.EventHandler(this.tsmiundo_Click);
            // 
            // tsmiredo
            // 
            this.tsmiredo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiredo.Image")));
            this.tsmiredo.Name = "tsmiredo";
            this.tsmiredo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiredo.Size = new System.Drawing.Size(164, 22);
            this.tsmiredo.Text = "&Redo";
            this.tsmiredo.Click += new System.EventHandler(this.tsmiredo_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmicut
            // 
            this.tsmicut.Image = ((System.Drawing.Image)(resources.GetObject("tsmicut.Image")));
            this.tsmicut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmicut.Name = "tsmicut";
            this.tsmicut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmicut.Size = new System.Drawing.Size(164, 22);
            this.tsmicut.Text = "Cu&t";
            this.tsmicut.Click += new System.EventHandler(this.tsmicut_Click);
            // 
            // tsmicopy
            // 
            this.tsmicopy.Image = ((System.Drawing.Image)(resources.GetObject("tsmicopy.Image")));
            this.tsmicopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmicopy.Name = "tsmicopy";
            this.tsmicopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmicopy.Size = new System.Drawing.Size(164, 22);
            this.tsmicopy.Text = "&Copy";
            this.tsmicopy.Click += new System.EventHandler(this.tsmicopy_Click);
            // 
            // tsmipaste
            // 
            this.tsmipaste.Image = ((System.Drawing.Image)(resources.GetObject("tsmipaste.Image")));
            this.tsmipaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmipaste.Name = "tsmipaste";
            this.tsmipaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmipaste.Size = new System.Drawing.Size(164, 22);
            this.tsmipaste.Text = "&Paste";
            this.tsmipaste.Click += new System.EventHandler(this.tsmipaste_Click);
            // 
            // tsmidel
            // 
            this.tsmidel.Name = "tsmidel";
            this.tsmidel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmidel.Size = new System.Drawing.Size(164, 22);
            this.tsmidel.Text = "Delete";
            this.tsmidel.Click += new System.EventHandler(this.tsmidel_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiselall
            // 
            this.tsmiselall.Image = ((System.Drawing.Image)(resources.GetObject("tsmiselall.Image")));
            this.tsmiselall.Name = "tsmiselall";
            this.tsmiselall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiselall.Size = new System.Drawing.Size(164, 22);
            this.tsmiselall.Text = "Select &All";
            this.tsmiselall.Click += new System.EventHandler(this.tsmiselall_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmifind
            // 
            this.tsmifind.Image = ((System.Drawing.Image)(resources.GetObject("tsmifind.Image")));
            this.tsmifind.Name = "tsmifind";
            this.tsmifind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmifind.Size = new System.Drawing.Size(164, 22);
            this.tsmifind.Text = "&Find ...";
            this.tsmifind.Click += new System.EventHandler(this.tsmifind_Click);
            // 
            // tsmireplace
            // 
            this.tsmireplace.Image = ((System.Drawing.Image)(resources.GetObject("tsmireplace.Image")));
            this.tsmireplace.Name = "tsmireplace";
            this.tsmireplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmireplace.Size = new System.Drawing.Size(164, 22);
            this.tsmireplace.Text = "&Replace";
            this.tsmireplace.Click += new System.EventHandler(this.tsmireplace_Click);
            // 
            // tsmigoto
            // 
            this.tsmigoto.Image = ((System.Drawing.Image)(resources.GetObject("tsmigoto.Image")));
            this.tsmigoto.Name = "tsmigoto";
            this.tsmigoto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmigoto.Size = new System.Drawing.Size(164, 22);
            this.tsmigoto.Text = "&Go to ...";
            this.tsmigoto.Click += new System.EventHandler(this.tsmigoto_Click);
            // 
            // tsmformat
            // 
            this.tsmformat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmibackcolor,
            this.tsmiforecolor,
            this.tsmifont,
            this.stmiwordwrap});
            this.tsmformat.Name = "tsmformat";
            this.tsmformat.Size = new System.Drawing.Size(57, 19);
            this.tsmformat.Text = "F&ormat";
            this.tsmformat.DropDownOpening += new System.EventHandler(this.set);
            // 
            // tsmibackcolor
            // 
            this.tsmibackcolor.Name = "tsmibackcolor";
            this.tsmibackcolor.Size = new System.Drawing.Size(166, 22);
            this.tsmibackcolor.Text = "&Back Grand Color";
            this.tsmibackcolor.Click += new System.EventHandler(this.tsmibackcolor_Click);
            // 
            // tsmiforecolor
            // 
            this.tsmiforecolor.Name = "tsmiforecolor";
            this.tsmiforecolor.Size = new System.Drawing.Size(166, 22);
            this.tsmiforecolor.Text = "&Fore Colore";
            this.tsmiforecolor.Click += new System.EventHandler(this.tsmiforecolor_Click);
            // 
            // tsmifont
            // 
            this.tsmifont.Name = "tsmifont";
            this.tsmifont.Size = new System.Drawing.Size(166, 22);
            this.tsmifont.Text = "Fon&t";
            this.tsmifont.Click += new System.EventHandler(this.tsmifont_Click);
            // 
            // stmiwordwrap
            // 
            this.stmiwordwrap.CheckOnClick = true;
            this.stmiwordwrap.Name = "stmiwordwrap";
            this.stmiwordwrap.Size = new System.Drawing.Size(166, 22);
            this.stmiwordwrap.Text = "&Word Wrap";
            this.stmiwordwrap.Click += new System.EventHandler(this.stmiwordwrap_Click);
            // 
            // tsmview
            // 
            this.tsmview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmistatusbar});
            this.tsmview.Name = "tsmview";
            this.tsmview.Size = new System.Drawing.Size(44, 19);
            this.tsmview.Text = "&View";
            this.tsmview.DropDownOpening += new System.EventHandler(this.set);
            // 
            // tsmistatusbar
            // 
            this.tsmistatusbar.CheckOnClick = true;
            this.tsmistatusbar.Name = "tsmistatusbar";
            this.tsmistatusbar.Size = new System.Drawing.Size(126, 22);
            this.tsmistatusbar.Text = "&Status Bar";
            this.tsmistatusbar.Click += new System.EventHandler(this.tsmistatusbar_Click);
            // 
            // tsmhrlp
            // 
            this.tsmhrlp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiabout});
            this.tsmhrlp.Name = "tsmhrlp";
            this.tsmhrlp.Size = new System.Drawing.Size(44, 19);
            this.tsmhrlp.Text = "&Help";
            this.tsmhrlp.DropDownOpening += new System.EventHandler(this.set);
            // 
            // tsmiabout
            // 
            this.tsmiabout.Image = ((System.Drawing.Image)(resources.GetObject("tsmiabout.Image")));
            this.tsmiabout.Name = "tsmiabout";
            this.tsmiabout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmiabout.Size = new System.Drawing.Size(153, 22);
            this.tsmiabout.Text = "&About...";
            this.tsmiabout.Click += new System.EventHandler(this.tsmiabout_Click);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlcol,
            this.tsmlrow,
            this.tsmlsap,
            this.tsmlready});
            this.statusbar.Location = new System.Drawing.Point(0, 434);
            this.statusbar.Name = "statusbar";
            this.statusbar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusbar.Size = new System.Drawing.Size(734, 22);
            this.statusbar.TabIndex = 2;
            this.statusbar.Text = "statusStrip1";
            // 
            // tsmlcol
            // 
            this.tsmlcol.Name = "tsmlcol";
            this.tsmlcol.Size = new System.Drawing.Size(40, 17);
            this.tsmlcol.Text = "Col 1 ,";
            // 
            // tsmlrow
            // 
            this.tsmlrow.Name = "tsmlrow";
            this.tsmlrow.Size = new System.Drawing.Size(32, 17);
            this.tsmlrow.Text = "Ln 1 ";
            // 
            // tsmlsap
            // 
            this.tsmlsap.Name = "tsmlsap";
            this.tsmlsap.Size = new System.Drawing.Size(16, 17);
            this.tsmlsap.Text = " | ";
            // 
            // tsmlready
            // 
            this.tsmlready.Name = "tsmlready";
            this.tsmlready.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmlready.Size = new System.Drawing.Size(151, 17);
            this.tsmlready.Text = "Get Is Ready For Use You ... ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 456);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Note Pad SAH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmfile;
        private System.Windows.Forms.ToolStripMenuItem tsminew;
        private System.Windows.Forms.ToolStripMenuItem tsmiopen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmisave;
        private System.Windows.Forms.ToolStripMenuItem tsmisaveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiprint;
        private System.Windows.Forms.ToolStripMenuItem tsmiprintp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiexit;
        private System.Windows.Forms.ToolStripMenuItem tsmhrlp;
        private System.Windows.Forms.ToolStripMenuItem tsmiabout;
        private System.Windows.Forms.ToolStripMenuItem tsmformat;
        private System.Windows.Forms.ToolStripMenuItem tsmiforecolor;
        private System.Windows.Forms.ToolStripMenuItem tsmifont;
        private System.Windows.Forms.ToolStripMenuItem tsmview;
        private System.Windows.Forms.ToolStripMenuItem tsmistatusbar;
        private System.Windows.Forms.ToolStripMenuItem stmiwordwrap;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmibackcolor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmisdf;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.ToolStripStatusLabel tsmlrow;
        private System.Windows.Forms.ToolStripStatusLabel tsmlready;
        private System.Windows.Forms.ToolStripStatusLabel tsmlsap;
        private System.Windows.Forms.ToolStripStatusLabel tsmlcol;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem tsmiundo;
        private System.Windows.Forms.ToolStripMenuItem tsmiredo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmicut;
        private System.Windows.Forms.ToolStripMenuItem tsmicopy;
        private System.Windows.Forms.ToolStripMenuItem tsmipaste;
        private System.Windows.Forms.ToolStripMenuItem tsmidel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsmiselall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem tsmifind;
        private System.Windows.Forms.ToolStripMenuItem tsmireplace;
        private System.Windows.Forms.ToolStripMenuItem tsmigoto;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

