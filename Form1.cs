using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal3_103022330036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string inputUser;
        public int bil1, bil2;

        private void button2_Click(object sender, EventArgs e)
        {
            inputUser += "1";
            label1.Text = inputUser;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputUser += "2";
            label1.Text = inputUser;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputUser += "7";
            label1.Text = inputUser;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputUser += "3";
            label1.Text = inputUser;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputUser += "4";
            label1.Text = inputUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputUser += "5";
            label1.Text = inputUser;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputUser += "6";
            label1.Text = inputUser;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputUser += "8";
            label1.Text = inputUser;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputUser += "9";
            label1.Text = inputUser;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //+
            bil1 = int.Parse(inputUser);
            inputUser = "";
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            inputUser += "0";
            label1.Text = inputUser;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //=
            bil2 = int.Parse(inputUser);
            int hasil = bil1 + bil2;
            label1.Text = " " + hasil;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
