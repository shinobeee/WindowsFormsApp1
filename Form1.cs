using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            string Can;
            switch (Convert.ToInt32(txtnam) % 10)
            {
                case 0:
                    Can = "canh";
                    break;
                case 1:
                    Can = "tân";
                    break;
                case 2:
                    Can = "nhâm";
                    break;
                case 3:
                    Can = "quý";
                    break;
                case 4:
                    Can = "giáp";
                    break;
                case 5:
                    Can = "ất";
                    break;
                case 6:
                    Can = "bính";
                    break;
                case 7:
                    Can = "đinh";
                    break;
                case 8:
                    Can = "mậu";
                    break;
                case 9:
                    Can = "kỷ";
                    break;
            }
            string Chi = "";
            switch (Convert.ToInt32(txtnam) % 12)
            {
                case 0:
                    Chi = "thân";
                    break;
                case 1:
                    Chi = "dậu";
                    break;
                case 2:
                    Chi = "tuất";
                    break;
                case 3:
                    Chi = "hợi";
                    break;
                case 4:
                    Chi = "tý";
                    break;
                case 5:
                    Chi = "sửu";
                    break;
                case 6:
                    Chi = "dần";
                    break;
                case 7:
                    Chi = "mão";
                    break;
                case 8:
                    Chi = "thìn";
                    break;
                case 9:
                    Chi = "tỵ";
                    break;
                case 10:
                    Chi = "ngọ";
                    break;
                case 11:
                    Chi = "mùi";
                    break;
            }
            txtkq.Text = can + " " + Chi;
        }
    }
}










