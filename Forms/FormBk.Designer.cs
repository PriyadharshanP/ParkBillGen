namespace ParkBillGen.Forms
{
    partial class FormBk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBk));
            this.btnPrintBk = new System.Windows.Forms.Button();
            this.btnGenBk = new System.Windows.Forms.Button();
            this.btnResetBk = new System.Windows.Forms.Button();
            this.txtResultBk = new System.Windows.Forms.RichTextBox();
            this.txtBHoursBk = new System.Windows.Forms.TextBox();
            this.txtBNameBk = new System.Windows.Forms.TextBox();
            this.txtBVehNoBk = new System.Windows.Forms.TextBox();
            this.hoursBk = new System.Windows.Forms.Label();
            this.nameBk = new System.Windows.Forms.Label();
            this.vehNoBk = new System.Windows.Forms.Label();
            this.printBk = new System.Drawing.Printing.PrintDocument();
            this.printPreviewBk = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintBk
            // 
            this.btnPrintBk.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBk.Image")));
            this.btnPrintBk.Location = new System.Drawing.Point(713, 43);
            this.btnPrintBk.Name = "btnPrintBk";
            this.btnPrintBk.Size = new System.Drawing.Size(41, 40);
            this.btnPrintBk.TabIndex = 20;
            this.btnPrintBk.UseVisualStyleBackColor = true;
            this.btnPrintBk.Click += new System.EventHandler(this.btnPrintBk_Click);
            // 
            // btnGenBk
            // 
            this.btnGenBk.Location = new System.Drawing.Point(632, 386);
            this.btnGenBk.Name = "btnGenBk";
            this.btnGenBk.Size = new System.Drawing.Size(75, 23);
            this.btnGenBk.TabIndex = 19;
            this.btnGenBk.Text = "Generate";
            this.btnGenBk.UseVisualStyleBackColor = true;
            this.btnGenBk.Click += new System.EventHandler(this.btnGenBk_Click);
            // 
            // btnResetBk
            // 
            this.btnResetBk.Location = new System.Drawing.Point(497, 386);
            this.btnResetBk.Name = "btnResetBk";
            this.btnResetBk.Size = new System.Drawing.Size(75, 23);
            this.btnResetBk.TabIndex = 18;
            this.btnResetBk.Text = "Reset";
            this.btnResetBk.UseVisualStyleBackColor = true;
            this.btnResetBk.Click += new System.EventHandler(this.btnResetBk_Click);
            // 
            // txtResultBk
            // 
            this.txtResultBk.Location = new System.Drawing.Point(497, 43);
            this.txtResultBk.Name = "txtResultBk";
            this.txtResultBk.Size = new System.Drawing.Size(210, 297);
            this.txtResultBk.TabIndex = 17;
            this.txtResultBk.Text = "";
            // 
            // txtBHoursBk
            // 
            this.txtBHoursBk.Location = new System.Drawing.Point(241, 191);
            this.txtBHoursBk.Name = "txtBHoursBk";
            this.txtBHoursBk.Size = new System.Drawing.Size(220, 20);
            this.txtBHoursBk.TabIndex = 16;
            // 
            // txtBNameBk
            // 
            this.txtBNameBk.Location = new System.Drawing.Point(241, 116);
            this.txtBNameBk.Name = "txtBNameBk";
            this.txtBNameBk.Size = new System.Drawing.Size(220, 20);
            this.txtBNameBk.TabIndex = 15;
            this.txtBNameBk.TextChanged += new System.EventHandler(this.txtBName3W_TextChanged);
            // 
            // txtBVehNoBk
            // 
            this.txtBVehNoBk.Location = new System.Drawing.Point(241, 41);
            this.txtBVehNoBk.Name = "txtBVehNoBk";
            this.txtBVehNoBk.Size = new System.Drawing.Size(220, 20);
            this.txtBVehNoBk.TabIndex = 14;
            // 
            // hoursBk
            // 
            this.hoursBk.AutoSize = true;
            this.hoursBk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursBk.Location = new System.Drawing.Point(47, 193);
            this.hoursBk.Name = "hoursBk";
            this.hoursBk.Size = new System.Drawing.Size(123, 15);
            this.hoursBk.TabIndex = 13;
            this.hoursBk.Text = "No. of Hr for Parking: ";
            // 
            // nameBk
            // 
            this.nameBk.AutoSize = true;
            this.nameBk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBk.Location = new System.Drawing.Point(47, 118);
            this.nameBk.Name = "nameBk";
            this.nameBk.Size = new System.Drawing.Size(83, 15);
            this.nameBk.TabIndex = 12;
            this.nameBk.Text = "Owner Name: ";
            // 
            // vehNoBk
            // 
            this.vehNoBk.AutoSize = true;
            this.vehNoBk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehNoBk.Location = new System.Drawing.Point(47, 43);
            this.vehNoBk.Name = "vehNoBk";
            this.vehNoBk.Size = new System.Drawing.Size(97, 15);
            this.vehNoBk.TabIndex = 11;
            this.vehNoBk.Text = "Vehicle Number: ";
            // 
            // printPreviewBk
            // 
            this.printPreviewBk.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewBk.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewBk.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewBk.Enabled = true;
            this.printPreviewBk.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewBk.Icon")));
            this.printPreviewBk.Name = "printPreviewBk";
            this.printPreviewBk.Visible = false;
            this.printPreviewBk.Load += new System.EventHandler(this.printPreviewBk_Load);
            // 
            // FormBk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintBk);
            this.Controls.Add(this.btnGenBk);
            this.Controls.Add(this.btnResetBk);
            this.Controls.Add(this.txtResultBk);
            this.Controls.Add(this.txtBHoursBk);
            this.Controls.Add(this.txtBNameBk);
            this.Controls.Add(this.txtBVehNoBk);
            this.Controls.Add(this.hoursBk);
            this.Controls.Add(this.nameBk);
            this.Controls.Add(this.vehNoBk);
            this.Name = "FormBk";
            this.Text = "FormBk";
            this.Load += new System.EventHandler(this.FormBk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintBk;
        private System.Windows.Forms.Button btnGenBk;
        private System.Windows.Forms.Button btnResetBk;
        private System.Windows.Forms.RichTextBox txtResultBk;
        private System.Windows.Forms.TextBox txtBHoursBk;
        private System.Windows.Forms.TextBox txtBNameBk;
        private System.Windows.Forms.TextBox txtBVehNoBk;
        private System.Windows.Forms.Label hoursBk;
        private System.Windows.Forms.Label nameBk;
        private System.Windows.Forms.Label vehNoBk;
        private System.Drawing.Printing.PrintDocument printBk;
        private System.Windows.Forms.PrintPreviewDialog printPreviewBk;
    }
}