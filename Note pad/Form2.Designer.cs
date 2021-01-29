namespace Note_pad
{
    partial class frmgoto
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
            this.btncancel = new System.Windows.Forms.Button();
            this.txtlinenum = new System.Windows.Forms.TextBox();
            this.lbllinenum = new System.Windows.Forms.Label();
            this.btngoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(223, 81);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtlinenum
            // 
            this.txtlinenum.Location = new System.Drawing.Point(12, 44);
            this.txtlinenum.Name = "txtlinenum";
            this.txtlinenum.Size = new System.Drawing.Size(286, 20);
            this.txtlinenum.TabIndex = 0;
            // 
            // lbllinenum
            // 
            this.lbllinenum.AutoSize = true;
            this.lbllinenum.Location = new System.Drawing.Point(9, 18);
            this.lbllinenum.Name = "lbllinenum";
            this.lbllinenum.Size = new System.Drawing.Size(73, 13);
            this.lbllinenum.TabIndex = 2;
            this.lbllinenum.Text = "Line Number :";
            // 
            // btngoto
            // 
            this.btngoto.Location = new System.Drawing.Point(131, 81);
            this.btngoto.Name = "btngoto";
            this.btngoto.Size = new System.Drawing.Size(75, 23);
            this.btngoto.TabIndex = 1;
            this.btngoto.Text = "Go To";
            this.btngoto.UseVisualStyleBackColor = true;
            this.btngoto.Click += new System.EventHandler(this.btngoto_Click);
            // 
            // frmgoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 120);
            this.Controls.Add(this.btngoto);
            this.Controls.Add(this.lbllinenum);
            this.Controls.Add(this.txtlinenum);
            this.Controls.Add(this.btncancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmgoto";
            this.ShowIcon = false;
            this.Text = "Go To Line";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtlinenum;
        private System.Windows.Forms.Label lbllinenum;
        private System.Windows.Forms.Button btngoto;
    }
}