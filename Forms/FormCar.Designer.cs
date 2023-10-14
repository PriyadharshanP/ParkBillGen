namespace ParkBillGen.Forms
{
    partial class FormCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCar));
            this.btnPrintCar = new System.Windows.Forms.Button();
            this.btnGenCar = new System.Windows.Forms.Button();
            this.btnResetCar = new System.Windows.Forms.Button();
            this.txtResultCar = new System.Windows.Forms.RichTextBox();
            this.txtBHoursCar = new System.Windows.Forms.TextBox();
            this.txtBNameCar = new System.Windows.Forms.TextBox();
            this.txtBVehNoCar = new System.Windows.Forms.TextBox();
            this.hoursCar = new System.Windows.Forms.Label();
            this.nameCar = new System.Windows.Forms.Label();
            this.vehNoCar = new System.Windows.Forms.Label();
            this.printCar = new System.Drawing.Printing.PrintDocument();
            this.printPreviewCar = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintCar
            // 
            this.btnPrintCar.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCar.Image")));
            this.btnPrintCar.Location = new System.Drawing.Point(713, 43);
            this.btnPrintCar.Name = "btnPrintCar";
            this.btnPrintCar.Size = new System.Drawing.Size(41, 40);
            this.btnPrintCar.TabIndex = 30;
            this.btnPrintCar.UseVisualStyleBackColor = true;
            this.btnPrintCar.Click += new System.EventHandler(this.btnPrintCar_Click);
            // 
            // btnGenCar
            // 
            this.btnGenCar.Location = new System.Drawing.Point(632, 386);
            this.btnGenCar.Name = "btnGenCar";
            this.btnGenCar.Size = new System.Drawing.Size(75, 23);
            this.btnGenCar.TabIndex = 29;
            this.btnGenCar.Text = "Generate";
            this.btnGenCar.UseVisualStyleBackColor = true;
            this.btnGenCar.Click += new System.EventHandler(this.btnGenCar_Click);
            // 
            // btnResetCar
            // 
            this.btnResetCar.Location = new System.Drawing.Point(497, 386);
            this.btnResetCar.Name = "btnResetCar";
            this.btnResetCar.Size = new System.Drawing.Size(75, 23);
            this.btnResetCar.TabIndex = 28;
            this.btnResetCar.Text = "Reset";
            this.btnResetCar.UseVisualStyleBackColor = true;
            this.btnResetCar.Click += new System.EventHandler(this.btnResetCar_Click);
            // 
            // txtResultCar
            // 
            this.txtResultCar.Location = new System.Drawing.Point(497, 43);
            this.txtResultCar.Name = "txtResultCar";
            this.txtResultCar.Size = new System.Drawing.Size(210, 297);
            this.txtResultCar.TabIndex = 27;
            this.txtResultCar.Text = "";
            // 
            // txtBHoursCar
            // 
            this.txtBHoursCar.Location = new System.Drawing.Point(241, 191);
            this.txtBHoursCar.Name = "txtBHoursCar";
            this.txtBHoursCar.Size = new System.Drawing.Size(220, 20);
            this.txtBHoursCar.TabIndex = 26;
            // 
            // txtBNameCar
            // 
            this.txtBNameCar.Location = new System.Drawing.Point(241, 116);
            this.txtBNameCar.Name = "txtBNameCar";
            this.txtBNameCar.Size = new System.Drawing.Size(220, 20);
            this.txtBNameCar.TabIndex = 25;
            // 
            // txtBVehNoCar
            // 
            this.txtBVehNoCar.Location = new System.Drawing.Point(241, 41);
            this.txtBVehNoCar.Name = "txtBVehNoCar";
            this.txtBVehNoCar.Size = new System.Drawing.Size(220, 20);
            this.txtBVehNoCar.TabIndex = 24;
            // 
            // hoursCar
            // 
            this.hoursCar.AutoSize = true;
            this.hoursCar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursCar.Location = new System.Drawing.Point(47, 193);
            this.hoursCar.Name = "hoursCar";
            this.hoursCar.Size = new System.Drawing.Size(123, 15);
            this.hoursCar.TabIndex = 23;
            this.hoursCar.Text = "No. of Hr for Parking: ";
            // 
            // nameCar
            // 
            this.nameCar.AutoSize = true;
            this.nameCar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCar.Location = new System.Drawing.Point(47, 118);
            this.nameCar.Name = "nameCar";
            this.nameCar.Size = new System.Drawing.Size(83, 15);
            this.nameCar.TabIndex = 22;
            this.nameCar.Text = "Owner Name: ";
            // 
            // vehNoCar
            // 
            this.vehNoCar.AutoSize = true;
            this.vehNoCar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehNoCar.Location = new System.Drawing.Point(47, 43);
            this.vehNoCar.Name = "vehNoCar";
            this.vehNoCar.Size = new System.Drawing.Size(97, 15);
            this.vehNoCar.TabIndex = 21;
            this.vehNoCar.Text = "Vehicle Number: ";
            // 
            // printPreviewCar
            // 
            this.printPreviewCar.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewCar.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewCar.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewCar.Enabled = true;
            this.printPreviewCar.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewCar.Icon")));
            this.printPreviewCar.Name = "printPreviewCar";
            this.printPreviewCar.Visible = false;
            this.printPreviewCar.Load += new System.EventHandler(this.printPreviewCar_Load);
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintCar);
            this.Controls.Add(this.btnGenCar);
            this.Controls.Add(this.btnResetCar);
            this.Controls.Add(this.txtResultCar);
            this.Controls.Add(this.txtBHoursCar);
            this.Controls.Add(this.txtBNameCar);
            this.Controls.Add(this.txtBVehNoCar);
            this.Controls.Add(this.hoursCar);
            this.Controls.Add(this.nameCar);
            this.Controls.Add(this.vehNoCar);
            this.Name = "FormCar";
            this.Text = "FormCar";
            this.Load += new System.EventHandler(this.FormCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintCar;
        private System.Windows.Forms.Button btnGenCar;
        private System.Windows.Forms.Button btnResetCar;
        private System.Windows.Forms.RichTextBox txtResultCar;
        private System.Windows.Forms.TextBox txtBHoursCar;
        private System.Windows.Forms.TextBox txtBNameCar;
        private System.Windows.Forms.TextBox txtBVehNoCar;
        private System.Windows.Forms.Label hoursCar;
        private System.Windows.Forms.Label nameCar;
        private System.Windows.Forms.Label vehNoCar;
        private System.Drawing.Printing.PrintDocument printCar;
        private System.Windows.Forms.PrintPreviewDialog printPreviewCar;
    }
}