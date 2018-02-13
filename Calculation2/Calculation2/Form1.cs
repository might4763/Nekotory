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
        string temp = "0";
        int sumE = 0; // if sum have E
        int equalRound = 0; // if sum = roundtemp
        public Form1()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e) // key mapping
        {
            if (e.KeyCode == Keys.D1 && !e.Shift)
            {
                if (nextInput == 1) //next input after operater
                {
                    input.Text = "1"; //add new input
                    nextInput = 0; // set to before operater
                }
                else if (input.Text.Equals("0")) //first input
                {
                    input.Text = "1"; //add 1
                }
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "1"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "1"; //other input
                }
            }
            if (e.KeyCode == Keys.D2)
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
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "2"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "2"; //other input
                }
            }
            if (e.KeyCode == Keys.D3)
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
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "3"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "3"; //other input
                }
            }
            if (e.KeyCode == Keys.D4)
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
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "4"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "4"; //other input
                }
            }
            if (e.KeyCode == Keys.D5)
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
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "5"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "5"; //other input
                }
            }
            if (e.KeyCode == Keys.D6)
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
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "6"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "6"; //other input
                }
            }
            if (e.KeyCode == Keys.D7)
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
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "7"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "7"; //other input
                }
            }
            if (e.KeyCode == Keys.D8 && !e.Shift)
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
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "8"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "8"; //other input
                }
            }
            if (e.KeyCode == Keys.D9)
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
                else if (dot == 1) //have dot
                {
                    if (input.Text.Length < 17)// check input digit 
                        input.Text += "9"; //other input
                }
                else if (dot == 0)//not have dot
                {
                    if (input.Text.Length < 16)// check input digit 
                        input.Text += "9"; //other input
                }
            }
            if (e.KeyCode == Keys.D0)
            {
                if (nextInput == 1) //next input after operater
                {
                    input.Text = "0"; //add new input
                    nextInput = 0; // set to before operater
                }
                else if (!input.Text.Equals("0")) //check input !=0
                {
                    if (dot == 1) //have dot
                    {
                        if (input.Text.Length < 17) //check input digit
                            input.Text += "0"; //other input
                    }
                    else if (dot == 0)//not have dot
                    {
                        if (input.Text.Length < 16) // check input digit 
                            input.Text += "0"; //other input
                    }
                }
            }
            if (e.KeyCode == Keys.OemPeriod) // dot
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
            if (e.KeyCode == Keys.Oemplus && e.Shift) // plus
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
                operation = 1;  // set + operation
                countsum = 0; // reset countsum 
                dot = 0; //next input, reset count dot
            }
            if (e.KeyCode == Keys.OemMinus) //minus
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
                    cal(operation);//cal
                }
                nextInput = 1;  // set next input
                operation = 2;  // set - operation
                countsum = 0;// reset countsum 
                dot = 0; //next input, reset count dot
            }
            if (e.KeyCode == Keys.D8 && e.Shift) //multi
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
            if (e.KeyCode == Keys.OemQuestion) // divide
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
            if (e.KeyCode == Keys.Oemplus && !e.Shift)  //sum
            {
                if (input2.Equals("0"))  //first input
                {
                    input2 = input.Text; //set input2
                }
                if (countsum == 0) // first time hit equal
                {
                    input2 = input.Text;
                    countsum = 1; // count time hit equal
                }
                cal(operation); // cal
                nextInput = 1; //set next input
                dot = 0; //next input, reset count dot
            }
            if (e.KeyCode == Keys.D1 && e.Shift) //negate
            {
                if (!input.Text.Equals("0"))  // check input!0
                {
                    if (input.Text.Substring(0, 1).Equals("-")) //input negative
                    {
                        input.Text = input.Text.Substring(1, input.Text.Length - 1); //change to positive
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
                    if (!sum.Equals(0) && nextInput == 1) // not first input and after operater
                    {
                        logInput.Text = "negate(" + logInput.Text + ")"; //save log
                    }
                }
            }
            if (e.KeyCode == Keys.Delete) // Clear
            {
                sum = "0";
                input2 = "0";
                logInput.Text = "";
                countsum = 0;
                nextInput = 0;
                operation = 0;
                input.Text = "0";
                dot = 0;
                state = 0;
                input.Font = new Font("Microsoft Sans Serif", 30);
            }
            if (e.KeyCode == Keys.Back) // delete
            {
                if (countsum == 0) // first time hit equal
                {
                    if (!input.Text.Equals("0")) // have number
                    {
                        if (input.Text.Substring(input.Text.Length - 1).Equals(".")) //check delete dot
                        {
                            dot = 0; // delete dot
                        }
                        input.Text = input.Text.Substring(0, input.Text.Length - 1); // delete last digit
                        if (state != 0)  // not first input
                        {
                            input2 = input.Text; // add to input2
                        }
                    }
                    if (input.Text.Length == 0) // nothing left in input.Text
                    {
                        input.Text = "0"; // add 0 to input.text
                        if (state == 0)  //first input
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
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (nextInput == 1) //next input after operater
            {
                input.Text = "1"; //add new input
                nextInput = 0; // set to before operater
            }
            else if (input.Text.Equals("0")) //first input
            {
                input.Text = "1"; //add 1
            }
            else if (dot==1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "1"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "1"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "1"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "1"; //other input
                    }
                }
            }
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
            else if (dot == 1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "2"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "2"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "2"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "2"; //other input
                    }
                }
            }
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
            else if (dot == 1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "3"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "3"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "3"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "3"; //other input
                    }
                }
            }
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
            else if (dot == 1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "4"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "4"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "4"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "4"; //other input
                    }
                }
            }
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
            else if (dot == 1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "5"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "5"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "5"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "5"; //other input
                    }
                }
            }
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
            else if (dot == 1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "6"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "6"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "6"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "6"; //other input
                    }
                }
            }
        }
        private void b7_Click(object sender, EventArgs e)
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
            else if (dot == 1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "7"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "7"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "7"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "7"; //other input
                    }
                }
            }
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
            else if (dot == 1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "8"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "8"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "8"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "8"; //other input
                    }
                }
            }
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
            else if (dot == 1) //have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 18)// check input digit 
                    {
                        input.Text += "9"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 17) // check input digit
                    {
                        input.Text += "9"; //other input
                    }
                }
            }
            else if (dot == 0)//not have dot
            {
                if (double.Parse(input.Text) < 0) // have - operater
                {
                    if (input.Text.Length < 17)// check input digit 
                    {
                        input.Text += "9"; //other input
                    }
                }
                else // dont have -
                {
                    if (input.Text.Length < 16) // check input digit
                    {
                        input.Text += "9"; //other input
                    }
                }
            }
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
                if (dot == 1) //have dot
                {
                    if (double.Parse(input.Text) < 0) // have - operater
                    {
                        if (input.Text.Length < 18)// check input digit 
                        {
                            input.Text += "0"; //other input
                        }
                    }
                    else // dont have -
                    {
                        if (input.Text.Length < 17) // check input digit
                        {
                            input.Text += "0"; //other input
                        }
                    }
                }
                else if (dot == 0)//not have dot
                {
                    if (double.Parse(input.Text) < 0) // have - operater
                    {
                        if (input.Text.Length < 17)// check input digit 
                        {
                            input.Text += "0"; //other input
                        }
                    }
                    else // dont have -
                    {
                        if (input.Text.Length < 16) // check input digit
                        {
                            input.Text += "0"; //other input
                        }
                    }
                }
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

        private void bNegate_Click(object sender, EventArgs e)
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
            input.Font = new Font("Microsoft Sans Serif", 30);
            temp = "0";
            equalRound = 0;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (countsum == 0) // first time hit equal
            {
                if (!input.Text.Equals("0")) // have number
                {
                    if(input.Text.Substring(input.Text.Length - 1).Equals(".")) //check delete dot
                    {
                        dot = 0; // delete dot
                    }
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
        public void cal(int operation)
        {
            if (operation == 1)//plus
            {
                if (temp.Equals("0"))// 1st time
                {
                    temp = (double.Parse(sum) + double.Parse(input2)).ToString();  // temp sum 
                }
                else
                {
                    temp = (double.Parse(temp) + double.Parse(input2)).ToString();  // temp sum
                }
                sum = (double.Parse(sum) + double.Parse(input2)).ToString();  // calculate sum + input2
                checkLength();
                input.Text = sum; // show sum
                logInput.Text += " + " + input2; // save to log
            }
            if (operation == 2)//minus
            {
                if (temp.Equals("0"))// 1st time
                {
                    temp = (double.Parse(sum) - double.Parse(input2)).ToString();  // temp sum 
                }
                else
                {
                    temp = (double.Parse(temp) - double.Parse(input2)).ToString();  // temp sum
                }

                sum = (double.Parse(sum) - double.Parse(input2)).ToString(); // calculate sum - input2
                checkLength();
                input.Text = sum; // show sum
                logInput.Text += " - " + input2; // save to log
            }
            if (operation == 3)//multi
            {
                if (temp.Equals("0"))// 1st time
                {
                    temp = (double.Parse(sum) * double.Parse(input2)).ToString();  // temp sum 
                }
                else
                {
                    temp = (double.Parse(temp) * double.Parse(input2)).ToString();  // temp sum
                }
                sum = (double.Parse(sum) * double.Parse(input2)).ToString(); // calculate sum * input2          
                checkLength();
                input.Text = sum; // show sum
                if ((!temp.Equals(sum) || equalRound == 1)&&sumE==0)
                {
                    temp = temp.Substring(0, temp.Length - 2);
                    temp = (double.Parse(temp) - 0).ToString();
                    input.Text = temp;
                    equalRound = 0;
                }
                
                logInput.Text += " * " + input2; // save to log
            }
            if (operation == 4)//divide
            {
                if (decimal.Parse(sum) == 0 && decimal.Parse(input2) == 0)
                {
                    sum = "Result is undenfined";
                }
                else if (decimal.Parse(input2) == 0)
                {
                    sum = "Cant divide by zero";
                }
                else
                {
                    if (temp.Equals("0"))// 1st time
                    {
                        temp = (double.Parse(sum) / double.Parse(input2)).ToString();  // temp sum 
                    }
                    else
                    {
                        temp = (double.Parse(temp) / double.Parse(input2)).ToString();  // temp sum
                    }
                    sum = (double.Parse(sum) / double.Parse(input2)).ToString(); // calculate sum * input2
                    checkLength();
                }
                input.Text = sum; // show sum
                logInput.Text += " / " + input2; // save to log
            }
        }
        public void checkLength()
        {
            int i = sum.IndexOf('.'); //index of dot in sum
            int j = sum.IndexOf('E'); // index of E in sum
            int k = sum.IndexOf('.'); // index of dot in temp
            if(j>-1)// have E
            {
                sumE = 1;
                input.Font = new Font("Microsoft Sans Serif",23); // change font size to fit label
            }
            else if (i>-1)// check sum if sum have .
            {
                if (double.Parse(sum) < 0) // check sum if sum have - operater
                {
                    if (sum.Length > 18)  // check length if more than 18 digit include - and .
                    {
                        if (i > 17)// . in position more than 16 digit
                        {
                            sum = sum.Substring(0,17);
                        }
                        else
                        {
                            sum = Math.Round(double.Parse(sum), 17 - i).ToString(); // round to 16 digit
                        }
                    }
                }
                else if(double.Parse(sum) >= 0) // sum dont have - operater
                {
                    if (sum.Length > 17) // check length if more than 17 digit include . 
                        if (i > 16)// . in position more than 16 digit
                        {
                            sum = sum.Substring(0, 16);
                        }
                        else
                        {
                            sum = Math.Round(double.Parse(sum), 16 - i).ToString(); // round to 16 digit
                        }
                }
                sumE = 0;
            }
            else// sum don't have . 
            {
                if (double.Parse(sum) < 0) // check sum if sum have - operater
                {
                    if (sum.Length > 17)  // check length if more than 18 digit include - and .
                    {
                        sum = sum.Substring(0,17); // change to 16 digit
                    }
                }
                else if (double.Parse(sum) >= 0) // sum dont have - operater
                {
                    if (sum.Length > 16) // check length if more than 17 digit include . 
                    {
                        sum = sum.Substring(0, 16); // change to 16 digit
                    }
                }
                sumE = 0;
            }
            if (sumE==0) {
                if (k > -1) // have dot
                {
                    if (double.Parse(temp) < 0) // have - 
                    {
                        if (temp.Length >= 17)// length >18 , round up
                        {
                            int o = int.Parse(temp.Substring(temp.Length - 1, 1));
                            if (o < 5)
                            {
                                temp = roundDown(double.Parse(temp), temp.Length - (2 + k)).ToString();
                                if (string.Compare(sum, temp) == 0)
                                {
                                    equalRound = 1;
                                }
                                tempsum.Text = temp;

                            }
                        }
                    }
                    else if (double.Parse(temp) > 0) // dont have - operater
                    {
                        if (temp.Length >= 16)// length >18 , round up
                        {
                            int o = int.Parse(temp.Substring(temp.Length-1,1));
                            if (o<5)
                            {
                                temp = roundUp(double.Parse(temp), temp.Length-(2+k)).ToString();
                                if (string.Compare(sum, temp) == 0)
                                {
                                    equalRound = 1;
                                }
                                tempsum.Text = temp;

                            }
                        }
                    }

                }
            }
        }
        public double roundUp(double number, int numDecimalPlaces)
        {
            double multiplier = Math.Pow(10, numDecimalPlaces);
            return Math.Ceiling(number * multiplier) / multiplier;
        }
        public double roundDown(double number, int numDecimalPlaces)
        {
            double multiplier = Math.Pow(10, numDecimalPlaces);
            return Math.Floor(number * multiplier) / multiplier;
        }
    }
}
