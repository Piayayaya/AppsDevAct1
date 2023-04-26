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
    public partial class Panel1Control : UserControl
    {
        public Panel1Control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputOne = this.inputOneBtn.Text;
            var inputTwo = this.inputTwoBtn.Text;

            var parent = this.Parent as Form1;
            parent.panelOneInputOne = inputOne;
            parent.panelOneInputTwo = inputTwo;
        }

        private void inputOneBtn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
