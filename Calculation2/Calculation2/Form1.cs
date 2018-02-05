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
        string sum = "0"; // summary
        string input2="0"; // last input
        int state = 0; // check first input
        int nextInput=0; // ready to get next input
        int operation = 0; // 1=plus,2=minus,3=multi,4=div
        int countsum = 0; //count the number of hits the button equal
        int dot = 0; // count dot
        public Form1()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {

        }

       

        private void b1_Click(object sender, EventArgs e)
        {
            if (nextInput==1) //next input after operater
            {
                input.Text = "1"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "1"; //add 1
            }
            else input.Text += "1"; //other input
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "2"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0"))//first input
            {
                input.Text = "2"; //add 2
            }
            else input.Text += "2"; //other input
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "3"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "3"; //add 3
            }
            else input.Text += "3"; //other input
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "4"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "4"; //add 4
            }
            else input.Text += "4"; //other input
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "5"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "5"; //add 5
            }
            else input.Text += "5"; //other input
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "6"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "6"; //add 6
            }
            else input.Text += "6"; //other input
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "7"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "7"; //add 7
            }
            else input.Text += "7"; //other input
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "8"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "8"; //add 8
            }
            else input.Text += "8"; //other input
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "9"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "9"; //add 9
            }
            else input.Text += "9"; //other input
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "0"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (!input.Text.Equals("0")) //check input !=0
            {
                input.Text += "0"; //add 0
            }
        }

        private void bDot_Click(object sender, EventArgs e)
        {           
                if (nextInput == 1)  //next input after operater 
                {
                    input.Text = "0."; //add new input
                    nextInput = 0; // set to before operater
                    dot = 1; //count dot
                }
                else if (dot == 0) // not found dot
                {
                    input.Text += "."; //add .
                    dot = 1; //count dot
                }
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            if (state==0)  //first input
            {
                sum = input.Text;  //set first input
                logInput.Text += sum; //save to log
                state = 1; // set next input
            }
            else if (nextInput == 0) // next input
            {
                input2 = input.Text; //set input2
                cal(operation); //cal
            }
            nextInput = 1;  // set next input
            operation = 1;  // set + operation
            countsum = 0; // reset countsum 
            dot = 0; //next input, reset count dot
        }
        private void bMinus_Click(object sender, EventArgs e)
        {
            if (state == 0)  //first input
            {
                sum = input.Text;  //set first input
                logInput.Text += sum; //save to log
                state = 1; // set next input
            }
            else if(nextInput==0) // next input
            {
                input2 = input.Text; //set input2
                cal(operation);//cal
            }
            nextInput = 1;  // set next input
            operation = 2;  // set - operation
            countsum = 0;// reset countsum 
            dot = 0; //next input, reset count dot
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            if (state == 0)  //first input
            {
                sum = input.Text;  //set first input
                logInput.Text += sum; //save to log
                state = 1; // set next input
            }
            else if (nextInput == 0) // next input
            {
                input2 = input.Text; //set input2
                cal(operation); //cal
            }
            nextInput = 1;  // set next input
            operation = 3;  // set * operation
            countsum = 0;// reset countsum 
            dot = 0; //next input, reset count dot
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if (state == 0)  //first input
            {
                sum = input.Text;  //set first input
                logInput.Text += sum; //save to log
                state = 1; // set next input
            }
            else if (nextInput == 0) // next input
            {
                input2 = input.Text; //set input2
                cal(operation); //cal
            }
            nextInput = 1;  // set next input
            operation = 4;  // set / operation
            countsum = 0;// reset countsum 
            dot = 0; //next input, reset count dot
        }

        private void bSum_Click(object sender, EventArgs e)
        {
            if (input2.Equals("0"))  //first input
            {
                input2 = input.Text; //set input2
            }
            if (countsum==0) // first time hit equal
            {
                input2 = input.Text;
                countsum = 1; // count time hit equal
            }
            cal(operation); // cal
            nextInput = 1; //set next input
            dot = 0; //next input, reset count dot
        }

        private void bOpposite_Click(object sender, EventArgs e)
        {
            if (!input.Text.Equals("0"))  // check input!0
            {
                if(input.Text.Substring(0, 1).Equals("-")) //input negative
                {
                    input.Text = input.Text.Substring(1, input.Text.Length-1); //change to positive
                    if (state == 0) //first input
                    {
                        sum = input.Text; // set first input
                    }
                    else // next input
                    {
                        if (nextInput == 1)// before operater
                        {
                            sum = input.Text;//set to sum
                        }
                        else // after operater
                        {
                            input2 = input.Text; // set to input2
                        }
                    }
                }
                else // input positive
                {
                    input.Text = "-" + input.Text; //change to negative
                    if (state == 0) //first input
                    {
                        sum = input.Text; // set first input
                    }
                    else // next input
                    {
                        if (nextInput == 1) // before operater
                        {
                            sum = input.Text; // set to sum
                        }
                        else // after operater
                        {
                            input2 = input.Text; //set to input2
                        }
                    }
                }
                if (!sum.Equals(0)&&nextInput == 1) // not first input and after operater
                {
                    logInput.Text = "negate(" + logInput.Text + ")"; //save log
                }
            }
        }

        private void bClear_Click(object sender, EventArgs e) //reset
        {
            sum = "0";  
            input2 = "0";
            logInput.Text = "" ;
            countsum = 0;
            nextInput = 0;
            operation = 0;
            input.Text = "0";
            dot = 0;
            state = 0;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (countsum == 0) // first time hit equal
            {
                if (!input.Text.Equals("0")) // have number
                {
                    input.Text = input.Text.Substring(0, input.Text.Length - 1); // delete last digit
                    if (state!=0)  // not first input
                    {
                        input2 = input.Text; // add to input2
                    }
                }
                if (input.Text.Length == 0) // nothing left in input.Text
                {
                    input.Text = "0"; // add 0 to input.text
                    if (state==0)  //first input
                    {
                        sum = input.Text; // add first input
                    }
                    else // next input
                    {
                        input2 = input.Text; //add to input2
                    }
                }
            }
        }
        private void cal(int operation)
        {
            if (operation == 1)//plus
            {
                    sum = (float.Parse(sum) + float.Parse(input2)).ToString();  // calculate sum + input2
                    input.Text = sum; // show sum
                    logInput.Text += " + " + input2; // save to log
            }
            if (operation == 2)//minus
            {
                    sum = (float.Parse(sum) - float.Parse(input2)).ToString(); // calculate sum - input2
                    input.Text = sum; // show sum
                    logInput.Text += " - " + input2; // save to log
            }
            if (operation == 3)//multi
            {
                    sum = (float.Parse(sum) * float.Parse(input2)).ToString(); // calculate sum * input2
                    input.Text = sum; // show sum
                    logInput.Text += " * " + input2; // save to log
            }
            if (operation == 4)//divide
            {
                    sum = (float.Parse(sum) / float.Parse(input2)).ToString(); // calculate sum * input2
                    input.Text = sum; // show sum
                    logInput.Text += " / " + input2; // save to log
            }
        }
    }
}
