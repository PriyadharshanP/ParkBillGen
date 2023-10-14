namespace ParkBillGen
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BikeButton = new System.Windows.Forms.Button();
            this.ThreeWheelerButton = new System.Windows.Forms.Button();
            this.CarButton = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelDesktopView = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(7)))), ((int)(((byte)(14)))));
            this.panelMenu.Controls.Add(this.buttonHistory);
            this.panelMenu.Controls.Add(this.CarButton);
            this.panelMenu.Controls.Add(this.ThreeWheelerButton);
            this.panelMenu.Controls.Add(this.BikeButton);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 629);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(205)))), ((int)(((byte)(134)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 80);
            this.panel2.TabIndex = 0;
            // 
            // BikeButton
            // 
            this.BikeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BikeButton.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BikeButton.ForeColor = System.Drawing.Color.White;
            this.BikeButton.Image = ((System.Drawing.Image)(resources.GetObject("BikeButton.Image")));
            this.BikeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BikeButton.Location = new System.Drawing.Point(0, 80);
            this.BikeButton.Name = "BikeButton";
            this.BikeButton.Size = new System.Drawing.Size(200, 60);
            this.BikeButton.TabIndex = 1;
            this.BikeButton.Text = "Bike";
            this.BikeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BikeButton.UseVisualStyleBackColor = true;
            this.BikeButton.Click += new System.EventHandler(this.BikeButton_Click);
            // 
            // ThreeWheelerButton
            // 
            this.ThreeWheelerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThreeWheelerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeWheelerButton.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeWheelerButton.ForeColor = System.Drawing.Color.White;
            this.ThreeWheelerButton.Image = ((System.Drawing.Image)(resources.GetObject("ThreeWheelerButton.Image")));
            this.ThreeWheelerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThreeWheelerButton.Location = new System.Drawing.Point(0, 140);
            this.ThreeWheelerButton.Name = "ThreeWheelerButton";
            this.ThreeWheelerButton.Size = new System.Drawing.Size(200, 60);
            this.ThreeWheelerButton.TabIndex = 2;
            this.ThreeWheelerButton.Text = "3-Wheeler";
            this.ThreeWheelerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThreeWheelerButton.UseVisualStyleBackColor = true;
            this.ThreeWheelerButton.Click += new System.EventHandler(this.ThreeWheelerButton_Click);
            // 
            // CarButton
            // 
            this.CarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarButton.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarButton.ForeColor = System.Drawing.Color.White;
            this.CarButton.Image = ((System.Drawing.Image)(resources.GetObject("CarButton.Image")));
            this.CarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CarButton.Location = new System.Drawing.Point(0, 200);
            this.CarButton.Name = "CarButton";
            this.CarButton.Size = new System.Drawing.Size(200, 60);
            this.CarButton.TabIndex = 3;
            this.CarButton.Text = "Car";
            this.CarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CarButton.UseVisualStyleBackColor = true;
            this.CarButton.Click += new System.EventHandler(this.CarButton_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonHistory.Image")));
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonHistory.Location = new System.Drawing.Point(0, 260);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(200, 60);
            this.buttonHistory.TabIndex = 4;
            this.buttonHistory.Text = "History";
            this.buttonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1087, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // panelDesktopView
            // 
            this.panelDesktopView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopView.Location = new System.Drawing.Point(200, 80);
            this.panelDesktopView.Name = "panelDesktopView";
            this.panelDesktopView.Size = new System.Drawing.Size(1087, 549);
            this.panelDesktopView.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 629);
            this.Controls.Add(this.panelDesktopView);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BikeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ThreeWheelerButton;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button CarButton;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktopView;
    }
}

