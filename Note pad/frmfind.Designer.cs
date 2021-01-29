namespace Note_pad
{
    partial class frmfind
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
            this.lblwhat = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.chbmatch = new System.Windows.Forms.CheckBox();
            this.rdbup = new System.Windows.Forms.RadioButton();
            this.txtwhat = new System.Windows.Forms.TextBox();
            this.chbwrap = new System.Windows.Forms.CheckBox();
            this.grbdirection = new System.Windows.Forms.GroupBox();
            this.rdbdown = new System.Windows.Forms.RadioButton();
            this.grbdirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblwhat
            // 
            this.lblwhat.AutoSize = true;
            this.lblwhat.Location = new System.Drawing.Point(14, 27);
            this.lblwhat.Name = "lblwhat";
            this.lblwhat.Size = new System.Drawing.Size(71, 16);
            this.lblwhat.TabIndex = 0;
            this.lblwhat.Text = "Find What :";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(392, 76);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(87, 28);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(392, 20);
            this.btnfind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(87, 28);
            this.btnfind.TabIndex = 1;
            this.btnfind.Text = "Find Next";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // chbmatch
            // 
            this.chbmatch.AutoSize = true;
            this.chbmatch.Location = new System.Drawing.Point(17, 76);
            this.chbmatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbmatch.Name = "chbmatch";
            this.chbmatch.Size = new System.Drawing.Size(96, 20);
            this.chbmatch.TabIndex = 2;
            this.chbmatch.Text = "Match Case ";
            this.chbmatch.UseVisualStyleBackColor = true;
            // 
            // rdbup
            // 
            this.rdbup.AutoSize = true;
            this.rdbup.Location = new System.Drawing.Point(7, 32);
            this.rdbup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbup.Name = "rdbup";
            this.rdbup.Size = new System.Drawing.Size(43, 20);
            this.rdbup.TabIndex = 0;
            this.rdbup.Text = "Up";
            this.rdbup.UseVisualStyleBackColor = true;
            // 
            // txtwhat
            // 
            this.txtwhat.Location = new System.Drawing.Point(106, 23);
            this.txtwhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtwhat.Name = "txtwhat";
            this.txtwhat.Size = new System.Drawing.Size(259, 23);
            this.txtwhat.TabIndex = 0;
            // 
            // chbwrap
            // 
            this.chbwrap.AutoSize = true;
            this.chbwrap.Location = new System.Drawing.Point(17, 116);
            this.chbwrap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbwrap.Name = "chbwrap";
            this.chbwrap.Size = new System.Drawing.Size(102, 20);
            this.chbwrap.TabIndex = 3;
            this.chbwrap.Text = "Wrap around";
            this.chbwrap.UseVisualStyleBackColor = true;
            // 
            // grbdirection
            // 
            this.grbdirection.Controls.Add(this.rdbdown);
            this.grbdirection.Controls.Add(this.rdbup);
            this.grbdirection.Location = new System.Drawing.Point(233, 76);
            this.grbdirection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbdirection.Name = "grbdirection";
            this.grbdirection.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbdirection.Size = new System.Drawing.Size(132, 60);
            this.grbdirection.TabIndex = 4;
            this.grbdirection.TabStop = false;
            this.grbdirection.Text = "Direction";
            // 
            // rdbdown
            // 
            this.rdbdown.AutoSize = true;
            this.rdbdown.Checked = true;
            this.rdbdown.Location = new System.Drawing.Point(59, 32);
            this.rdbdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbdown.Name = "rdbdown";
            this.rdbdown.Size = new System.Drawing.Size(59, 20);
            this.rdbdown.TabIndex = 1;
            this.rdbdown.TabStop = true;
            this.rdbdown.Text = "Down";
            this.rdbdown.UseVisualStyleBackColor = true;
            // 
            // frmfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 155);
            this.Controls.Add(this.grbdirection);
            this.Controls.Add(this.chbwrap);
            this.Controls.Add(this.txtwhat);
            this.Controls.Add(this.chbmatch);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblwhat);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfind";
            this.ShowIcon = false;
            this.Text = "Find";
            this.grbdirection.ResumeLayout(false);
            this.grbdirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwhat;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.CheckBox chbmatch;
        private System.Windows.Forms.RadioButton rdbup;
        private System.Windows.Forms.TextBox txtwhat;
        private System.Windows.Forms.CheckBox chbwrap;
        private System.Windows.Forms.GroupBox grbdirection;
        private System.Windows.Forms.RadioButton rdbdown;
    }
}