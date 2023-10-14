using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParkBillGen.Forms
{
    public partial class Form3W : Form
    {
        public Form3W()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGen3W_Click(object sender, EventArgs e)
        {
            float hrs3W, fare3W;

            hrs3W = float.Parse(txtBHours3W.Text);
            fare3W = 20 * hrs3W;

            txtResult3W.Clear();
            txtResult3W.Text += "**************************************";
            txtResult3W.Text += "**         3-WHEELER RECEIPT        **";
            txtResult3W.Text += "**************************************\n\n";
            txtResult3W.Text += "Date: " + DateTime.Now + "\n\n";

            txtResult3W.Text += "Vehicle Number : " + txtBVehNo3W.Text + "\n";
            txtResult3W.Text += "Name : " + txtBName3W.Text + "\n";
            txtResult3W.Text += "Hours of parking : " + txtBHours3W.Text + "\n";
            txtResult3W.Text += "Fare : " + fare3W + "\n";
        }

        private void btnReset3W_Click(object sender, EventArgs e)
        {
            txtResult3W.Clear();
            txtBHours3W.Clear();
            txtBName3W.Clear();
            txtBVehNo3W.Clear();   
        }

        private void btnPrint3W_Click(object sender, EventArgs e)
        {
            printPreview3W.Document = print3W;
            printPreview3W.ShowDialog();
        }

        private void Form3W_Load(object sender, EventArgs e)
        {

        }

        private void printPreview3W_Load(object sender, EventArgs e)
        {
            //e.Graphics.DrawString(txtResult3W.Text, new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
    }
}
