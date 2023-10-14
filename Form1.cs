using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ParkBillGen
{
    public partial class FormMainMenu : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306");

        //This is constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        //These are methods

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender) 
                {
                    DisableButton();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = Color.FromArgb(23, 74, 46);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);


                }
            }
        }

        private void DisableButton() 
        { 
            foreach (Control previousbtn in panelMenu.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(23, 7, 14);
                    previousbtn.ForeColor = Color.White;
                    previousbtn.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopView.Controls.Add(childForm);
            this.panelDesktopView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        
        }

        private void BikeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBk(), sender);

        }

        private void ThreeWheelerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form3W(), sender);
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCar(), sender);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHistory(), sender);
        }
    }
}
