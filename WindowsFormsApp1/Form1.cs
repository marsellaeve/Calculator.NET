using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        string sign;
        double val1;
        double val2;
        int trackkeypoint = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd0.Text;
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd1.Text;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd2.Text;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd3.Text;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd4.Text;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd5.Text;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd6.Text;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd7.Text;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd8.Text;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd9.Text;
        }

        private void cmdequal_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(txtbox.Text);
            double result;

            if (sign == "+"){
                result = val1 + val2;
                txtbox.Text = result.ToString();
            }

            else if (sign == "-"){
                result = val1 - val2;
                txtbox.Text = result.ToString();
            }

            else if (sign == "*"){
                result = val1 * val2;
                txtbox.Text = result.ToString();
            }

            else{
                result = val1 / val2;
                txtbox.Text = result.ToString();
            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            txtbox.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        private void cmdcos_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Cos(v).ToString();
        }

        private void cmdsin_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Sin(v).ToString();
        }

        private void cmdsquare_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Pow(v, 2).ToString();
        }

        private void cmdsqrt_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Sqrt(v).ToString();
        }

        private void cmdtan_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Tan(v).ToString();
        }

        private void cmdsubtract_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtbox.Text);
            txtbox.Text = "";
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtbox.Text);
            txtbox.Text = "";
        }

        private void cmdmultiply_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtbox.Text);
            txtbox.Text = "";
        }

        private void cmddivide_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtbox.Text);
            txtbox.Text = "";
        }
        private void txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
