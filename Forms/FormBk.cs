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
    public partial class FormBk : Form
    {
        public FormBk()
        {
            InitializeComponent();
        }

        private void txtBName3W_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormBk_Load(object sender, EventArgs e)
        {

        }

        private void btnResetBk_Click(object sender, EventArgs e)
        {
            txtBHoursBk.Clear();
            txtBNameBk.Clear();
            txtBVehNoBk.Clear();
            txtResultBk.Clear();
        }

        private void btnGenBk_Click(object sender, EventArgs e)
        {
            float hrsBK, fareBK;

            hrsBK = float.Parse(txtBHoursBk.Text);
            fareBK = 15 * hrsBK;

            txtResultBk.Clear();
            txtResultBk.Text += "**************************************";
            txtResultBk.Text += "**            BIKE RECEIPT          **";
            txtResultBk.Text += "**************************************\n\n";
            txtResultBk.Text += "Date: " + DateTime.Now + "\n\n";

            txtResultBk.Text += "Vehicle Number : " + txtBVehNoBk.Text + "\n";
            txtResultBk.Text += "Name : " + txtBNameBk.Text + "\n";
            txtResultBk.Text += "Hours of parking : " + txtBHoursBk.Text + "\n";
            txtResultBk.Text += "Fare : " + fareBK + "\n";
        }

        private void btnPrintBk_Click(object sender, EventArgs e)
        {
            printPreviewBk.Document = printBk;
            printPreviewBk.ShowDialog();

        }

        private void printPreviewBk_Load(object sender, EventArgs e)
        {
           //e.Graphics.DrawString(txtResultBk.Text, new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
    }
}
