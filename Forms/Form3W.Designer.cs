namespace ParkBillGen.Forms
{
    partial class Form3W
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3W));
            this.vehNo3W = new System.Windows.Forms.Label();
            this.name3W = new System.Windows.Forms.Label();
            this.hours3W = new System.Windows.Forms.Label();
            this.txtBVehNo3W = new System.Windows.Forms.TextBox();
            this.txtBName3W = new System.Windows.Forms.TextBox();
            this.txtBHours3W = new System.Windows.Forms.TextBox();
            this.txtResult3W = new System.Windows.Forms.RichTextBox();
            this.btnReset3W = new System.Windows.Forms.Button();
            this.btnGen3W = new System.Windows.Forms.Button();
            this.btnPrint3W = new System.Windows.Forms.Button();
            this.print3W = new System.Drawing.Printing.PrintDocument();
            this.printPreview3W = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // vehNo3W
            // 
            this.vehNo3W.AutoSize = true;
            this.vehNo3W.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehNo3W.Location = new System.Drawing.Point(48, 43);
            this.vehNo3W.Name = "vehNo3W";
            this.vehNo3W.Size = new System.Drawing.Size(97, 15);
            this.vehNo3W.TabIndex = 1;
            this.vehNo3W.Text = "Vehicle Number: ";
            this.vehNo3W.Click += new System.EventHandler(this.label1_Click);
            // 
            // name3W
            // 
            this.name3W.AutoSize = true;
            this.name3W.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name3W.Location = new System.Drawing.Point(48, 118);
            this.name3W.Name = "name3W";
            this.name3W.Size = new System.Drawing.Size(83, 15);
            this.name3W.TabIndex = 2;
            this.name3W.Text = "Owner Name: ";
            this.name3W.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // hours3W
            // 
            this.hours3W.AutoSize = true;
            this.hours3W.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours3W.Location = new System.Drawing.Point(48, 193);
            this.hours3W.Name = "hours3W";
            this.hours3W.Size = new System.Drawing.Size(123, 15);
            this.hours3W.TabIndex = 3;
            this.hours3W.Text = "No. of Hr for Parking: ";
            // 
            // txtBVehNo3W
            // 
            this.txtBVehNo3W.Location = new System.Drawing.Point(242, 41);
            this.txtBVehNo3W.Name = "txtBVehNo3W";
            this.txtBVehNo3W.Size = new System.Drawing.Size(220, 20);
            this.txtBVehNo3W.TabIndex = 4;
            // 
            // txtBName3W
            // 
            this.txtBName3W.Location = new System.Drawing.Point(242, 116);
            this.txtBName3W.Name = "txtBName3W";
            this.txtBName3W.Size = new System.Drawing.Size(220, 20);
            this.txtBName3W.TabIndex = 5;
            // 
            // txtBHours3W
            // 
            this.txtBHours3W.Location = new System.Drawing.Point(242, 191);
            this.txtBHours3W.Name = "txtBHours3W";
            this.txtBHours3W.Size = new System.Drawing.Size(220, 20);
            this.txtBHours3W.TabIndex = 6;
            // 
            // txtResult3W
            // 
            this.txtResult3W.Location = new System.Drawing.Point(498, 43);
            this.txtResult3W.Name = "txtResult3W";
            this.txtResult3W.Size = new System.Drawing.Size(210, 297);
            this.txtResult3W.TabIndex = 7;
            this.txtResult3W.Text = "";
            // 
            // btnReset3W
            // 
            this.btnReset3W.Location = new System.Drawing.Point(498, 386);
            this.btnReset3W.Name = "btnReset3W";
            this.btnReset3W.Size = new System.Drawing.Size(75, 23);
            this.btnReset3W.TabIndex = 8;
            this.btnReset3W.Text = "Reset";
            this.btnReset3W.UseVisualStyleBackColor = true;
            this.btnReset3W.Click += new System.EventHandler(this.btnReset3W_Click);
            // 
            // btnGen3W
            // 
            this.btnGen3W.Location = new System.Drawing.Point(633, 386);
            this.btnGen3W.Name = "btnGen3W";
            this.btnGen3W.Size = new System.Drawing.Size(75, 23);
            this.btnGen3W.TabIndex = 9;
            this.btnGen3W.Text = "Generate";
            this.btnGen3W.UseVisualStyleBackColor = true;
            this.btnGen3W.Click += new System.EventHandler(this.btnGen3W_Click);
            // 
            // btnPrint3W
            // 
            this.btnPrint3W.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint3W.Image")));
            this.btnPrint3W.Location = new System.Drawing.Point(714, 43);
            this.btnPrint3W.Name = "btnPrint3W";
            this.btnPrint3W.Size = new System.Drawing.Size(41, 40);
            this.btnPrint3W.TabIndex = 10;
            this.btnPrint3W.UseVisualStyleBackColor = true;
            this.btnPrint3W.Click += new System.EventHandler(this.btnPrint3W_Click);
            // 
            // printPreview3W
            // 
            this.printPreview3W.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview3W.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview3W.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview3W.Enabled = true;
            this.printPreview3W.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview3W.Icon")));
            this.printPreview3W.Name = "printPreview3W";
            this.printPreview3W.Visible = false;
            this.printPreview3W.Load += new System.EventHandler(this.printPreview3W_Load);
            // 
            // Form3W
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint3W);
            this.Controls.Add(this.btnGen3W);
            this.Controls.Add(this.btnReset3W);
            this.Controls.Add(this.txtResult3W);
            this.Controls.Add(this.txtBHours3W);
            this.Controls.Add(this.txtBName3W);
            this.Controls.Add(this.txtBVehNo3W);
            this.Controls.Add(this.hours3W);
            this.Controls.Add(this.name3W);
            this.Controls.Add(this.vehNo3W);
            this.Name = "Form3W";
            this.Text = "Form3W";
            this.Load += new System.EventHandler(this.Form3W_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vehNo3W;
        private System.Windows.Forms.Label name3W;
        private System.Windows.Forms.Label hours3W;
        private System.Windows.Forms.TextBox txtBVehNo3W;
        private System.Windows.Forms.TextBox txtBName3W;
        private System.Windows.Forms.TextBox txtBHours3W;
        private System.Windows.Forms.RichTextBox txtResult3W;
        private System.Windows.Forms.Button btnReset3W;
        private System.Windows.Forms.Button btnGen3W;
        private System.Windows.Forms.Button btnPrint3W;
        private System.Drawing.Printing.PrintDocument print3W;
        private System.Windows.Forms.PrintPreviewDialog printPreview3W;
    }
}