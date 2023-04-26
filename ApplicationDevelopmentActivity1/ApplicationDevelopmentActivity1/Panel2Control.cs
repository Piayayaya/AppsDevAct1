using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDevelopmentActivity1
{
    public partial class Panel2Control : UserControl
    {
        public Panel2Control()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputOne = this.inputOneBtn.Text;
            var inputTwo = this.inputTwoBtn.Text;

            var parent = this.Parent as Form1;
            parent.panelTwoInputOne = inputOne;
            parent.panelTwoInputTwo = inputTwo;
        }

        private void inputOneBtn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
