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
    public partial class Form1 : Form
    {
        int total;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "0";
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            int test = Convert.ToInt32(output.Text);
            total += test;
            output.ResetText();
        }

        private void hasil_Click(object sender, EventArgs e)
        {
            int test = Convert.ToInt32(output.Text);
            total += test;
            output.Text = (total.ToString());
        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
}
