using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation2
{
    public partial class Form1 : Form
    {
        string sum="0",input1="0",input2="0",lastInput="0";
        int nextInput=0;
        int operation = 0;
        int countsum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {

        }

       

        private void b1_Click(object sender, EventArgs e)
        {
            if (nextInput==1)
            {
                input.Text = "1";
                nextInput = 0;
            }
            else if (float.Parse(input.Text) == 0)
            {
                input.Text = "1";
            }
            else input.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "2";
                nextInput = 0;
            }
            else if(float.Parse(input.Text) == 0)
            {
                input.Text = "2";
            }
            else input.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "3";
                nextInput = 0;
            }
            else if(float.Parse(input.Text) == 0)
            {
                input.Text = "3";
            }
            else input.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "4";
                nextInput = 0;
            }
            else if(float.Parse(input.Text) == 0)
            {
                input.Text = "4";
            }
            else input.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "5";
                nextInput = 0;
            }
            else if(float.Parse(input.Text) == 0)
            {
                input.Text = "5";
            }
            else input.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "6";
                nextInput = 0;
            }
            else if (float.Parse(input.Text) == 0)
            {
                input.Text = "6";
            }
            else input.Text += "6";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "7";
                nextInput = 0;
            }
            else if(float.Parse(input.Text) == 0)
            {
                input.Text = "7";
            }
            else input.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "8";
                nextInput = 0;
            }
            else if(float.Parse(input.Text) == 0)
            {
                input.Text = "8";
            }
            else input.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "9";
                nextInput = 0;
            }
            else if(float.Parse(input.Text) == 0)
            {
                input.Text = "9";
            }
            else input.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (nextInput == 1)
            {
                input.Text = "0";
                nextInput = 0;
            }
            if (float.Parse(input.Text) != 0)
            {
                input.Text += "0";
            }
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            int found=0;
            for(int i = 0; i < input.Text.Length; i++)
            {
                if (input.Text.IndexOf(".")!=-1)
                {
                    found = 1;
                }
            }
            if (found == 0)
            {
                input.Text += ".";
            }
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            if (input1.Equals("0"))  //first input
            {
                input1 = input.Text;
            }
            else if (nextInput == 0) // next input
            {
                cal(operation,0);
                countsum = 0;
            }
            nextInput = 1;  // set new input
            operation = 1;  // set + operation
            countsum = 0;
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if (input1.Equals("0"))  //first input
            {
                input1 = input.Text;
                countsum = 0;
            }
            else if(nextInput==0) // next input
            {
                cal(operation,0);
            }
            nextInput = 1;  // set new input
            operation = 2;  // set - operation
            countsum = 0;
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            if (input1.Equals("0"))  //first input
            {
                input1 = input.Text;
                countsum = 0;
            }
            else if (nextInput == 0) // next input
            {
                cal(operation,0);
            }
            nextInput = 1;  // set new input
            operation = 3;  // set * operation
            countsum = 0;
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if (input1.Equals("0"))  //first input
            {
                input1 = input.Text;
                countsum = 0;
            }
            else if (nextInput == 0) // next input
            {
                cal(operation,0);
            }
            nextInput = 1;  // set new input
            operation = 4;  // set / operation
            countsum = 0;
        }

        private void bSum_Click(object sender, EventArgs e)
        {
            if (input2.Equals("0"))  //first input
            {
                input2 = input.Text;
            }
            /*       else if (input2.Equals(input.Text))  //last input
                   {
                       input2 = input.Text;
                   }
            */
            if (countsum==0)
            { 
            lastInput = input.Text;
                countsum = 1;
            }
            cal(operation,1);
            nextInput = 1;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            sum = "0";
            input1 = "0";
            input2 = "0";
            lastInput = "0";
            countsum = 0;
            nextInput = 0;
            operation = 0;
            input.Text = "0";
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (float.Parse(input.Text) != 0)
            {
                input.Text= input.Text.Substring(0, input.Text.Length - 1);
            }
            if (input.Text.Length == 0)
            {
                input.Text = "0";
            }
        }
        private void cal(int operation,int repeat)
        {
            if (operation == 1)//plus
            {
                if (repeat == 0)
                {
                    input2 = input.Text;
                    sum = (float.Parse(input1) + float.Parse(input2)).ToString();
                    input1 = sum;
                    input.Text = input1;
                }
                else if (repeat == 1)
                {
                    sum = (float.Parse(input1) + float.Parse(lastInput)).ToString();
                    input1 = sum;
                    input.Text = input1;
                    input2 = lastInput;
                }
            }
            if (operation == 2)//minus
            {
                if (repeat == 0)
                {
                    input2 = input.Text;
                    sum = (float.Parse(input1) - float.Parse(input2)).ToString();
                    input1 = sum;
                    input.Text = input1;
                }
                else if (repeat == 1)
                {
                    sum = (float.Parse(input1) - float.Parse(lastInput)).ToString();
                    input1 = sum;
                    input.Text = input1;
                    input2 = lastInput;
                }
            }
            if (operation == 3)//multi
            {
                if (repeat == 0)
                {
                    input2 = input.Text;
                    sum = (float.Parse(input1) * float.Parse(input2)).ToString();
                    input1 = sum;
                    input.Text = input1;
                }
                else if (repeat == 1)
                {
                    sum = (float.Parse(input1) * float.Parse(lastInput)).ToString();
                    input1 = sum;
                    input.Text = input1;
                    input2 = lastInput;
                }
            }
            if (operation == 4)//divide
            {
                if (repeat == 0)
                {
                    input2 = input.Text;
                    sum = (float.Parse(input1) / float.Parse(input2)).ToString();
                    input1 = sum;
                    input.Text = input1;
                }
                else if (repeat == 1)
                {
                    sum = (float.Parse(input1) / float.Parse(lastInput)).ToString();
                    input1 = sum;
                    input.Text = input1;
                    input2 = lastInput;
                }
            }
        }
    }
}
