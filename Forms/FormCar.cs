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
    public partial class FormCar : Form
    {
        public static FormCar carPrint;
        public RichTextBox resCar;

        public FormCar()
        {
            InitializeComponent();
        }

        private void FormCar_Load(object sender, EventArgs e)
        {

        }

        private void btnGenCar_Click(object sender, EventArgs e)
        {
            float hrsCar, fareCar;

            hrsCar = float.Parse(txtBHoursCar.Text);
            fareCar = 25 * hrsCar;

            txtResultCar.Clear();
            txtResultCar.Text += "**************************************";
            txtResultCar.Text += "**            CAR RECEIPT           **";
            txtResultCar.Text += "**************************************\n\n";
            txtResultCar.Text += "Date: " + DateTime.Now + "\n\n";

            txtResultCar.Text += "Vehicle Number : " + txtBVehNoCar.Text + "\n";
            txtResultCar.Text += "Name : " + txtBNameCar.Text + "\n";
            txtResultCar.Text += "Hours of parking : " + txtBHoursCar.Text + "\n";
            txtResultCar.Text += "Fare : " + fareCar + "\n";
            resCar = txtResultCar;
        }

        private void btnResetCar_Click(object sender, EventArgs e)
        {
            txtBHoursCar.Clear();
            txtBNameCar.Clear();
            txtBVehNoCar.Clear();
            txtResultCar.Clear();
        }

        private void btnPrintCar_Click(object sender, EventArgs e)
        {
            printForm printForm = new printForm();
            printForm.Show();
            printForm.inst.resCar.Text = txtResultCar.Text;

        }

        private void printPreviewCar_Load(object sender, EventArgs e)
        {
            //e.Graphics.DrawString(txtResultCar.Text, new Font("Courier New", 15, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
    }
}
