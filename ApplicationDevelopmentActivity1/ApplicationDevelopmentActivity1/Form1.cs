using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDevelopmentActivity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string panelOneInputOne
        {
            set
            {
                textBox1.Text = value;
            }
        }

        public string panelOneInputTwo
        {
            set
            {
                textBox2.Text = value;
            }
        }

        public string panelTwoInputOne
        {
            set
            {
                textBox1.Text = value;
            }
        }

        public string panelTwoInputTwo
        {
            set
            {
                textBox2.Text = value;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2Control1.Show();
            panel2Control1.BringToFront();

            panel1Control1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1Control1.Show();
            panel1Control1.BringToFront();

            panel2Control1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2Control1.Show();
            panel2Control1.BringToFront();

            panel1Control1.Hide();
        }

        private void panel1Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
