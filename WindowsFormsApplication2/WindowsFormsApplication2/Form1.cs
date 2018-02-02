using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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

        private void plus_Click(object sender, EventArgs e)
        {
            float finput1 = float.Parse(input1.Text);
            float finput2 = float.Parse(input2.Text);
            float sum = finput1 + finput2;
            answer.Text = sum.ToString() ;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            float finput1 = float.Parse(input1.Text);
            float finput2 = float.Parse(input2.Text);
            float sum = finput1 - finput2;
            answer.Text = sum.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            float finput1 = float.Parse(input1.Text);
            float finput2 = float.Parse(input2.Text);
            float sum = finput1 * finput2;
            answer.Text = sum.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            float finput1 = float.Parse(input1.Text);
            float finput2 = float.Parse(input2.Text);
            float sum = finput1 / finput2;
            answer.Text = sum.ToString();
        }
    }
}
