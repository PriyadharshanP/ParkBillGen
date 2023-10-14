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
    public partial class printForm : Form
    {
        public static printForm inst;
        public RichTextBox resCar;
        public RichTextBox resBk;
        public RichTextBox res3W;
        public printForm()
        {
            inst = this;
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
