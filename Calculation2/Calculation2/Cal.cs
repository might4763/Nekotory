using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation2
{
    public class Cal
    {
        string temp = "0";
        string sum = "0";
        int equalRound = 0;
        public string total(int operation, string input, string input2)
        {
            if (operation == 1)//plus
            {
                if (temp.Equals("0"))// 1st time
                {
                    temp = (double.Parse(input) + double.Parse(input2)).ToString();  // temp sum 
                }
                else
                {
                    temp = (double.Parse(temp) + double.Parse(input2)).ToString();  // temp sum
                }
                sum = (double.Parse(input) + double.Parse(input2)).ToString();  // calculate sum + input2
                checkLength();
            }
            if (operation == 2)//minus
            {
                if (temp.Equals("0"))// 1st time
                {
                    temp = (double.Parse(input) - double.Parse(input2)).ToString();  // temp sum 
                }
                else
                {
                    temp = (double.Parse(temp) - double.Parse(input2)).ToString();  // temp sum
                }

                sum = (double.Parse(input) - double.Parse(input2)).ToString(); // calculate sum - input2
                checkLength();
            }
            if (operation == 3)//multi
            {
                if (temp.Equals("0"))// 1st time
                {
                    temp = (double.Parse(input) * double.Parse(input2)).ToString();  // temp sum 
                }
                else
                {
                    temp = (double.Parse(temp) * double.Parse(input2)).ToString();  // temp sum
                }
                sum = (double.Parse(input) * double.Parse(input2)).ToString(); // calculate sum * input2          
                checkLength();
                if (!temp.Equals(sum) || equalRound == 1)
                {
                    temp = temp.Substring(0, temp.Length - 2);
                    equalRound = 0;
                    return temp;
                }
            }
            if (operation == 4)//divide
            {
                if (double.Parse(input) == 0 && double.Parse(input2) == 0)
                {
                    sum = "Result is undenfined";
                }
                else if (double.Parse(input2) == 0)
                {
                    sum = "Cant divide by zero";
                }
                else
                {
                    if (temp.Equals("0"))// 1st time
                    {
                        temp = (double.Parse(input) / double.Parse(input2)).ToString();  // temp sum 
                    }
                    else
                    {
                        temp = (double.Parse(temp) / double.Parse(input2)).ToString();  // temp sum
                    }
                    sum = (double.Parse(input) / double.Parse(input2)).ToString(); // calculate sum * input2
                    checkLength();
                }
            }
            return sum;
        }
        public void checkLength()
        {
            int i = sum.IndexOf('.'); //index of dot in sum
            int j = sum.IndexOf('E'); // index of E in sum
            int k = sum.IndexOf('.'); // index of dot in temp
            if (j > -1)// have E
            {
    //            input.Font = new Font("Microsoft Sans Serif", 23); // change font size to fit label
            }
            else if (i > -1)// check sum if sum have .
            {
                if (double.Parse(sum) < 0) // check sum if sum have - operater
                {
                    if (sum.Length > 18)  // check length if more than 18 digit include - and .
                    {
                        if (i > 17)// . in position more than 16 digit
                        {
                            sum = sum.Substring(0, 17);
                        }
                        else
                        {
                            sum = Math.Round(double.Parse(sum), 17 - i).ToString(); // round to 16 digit
                        }
                    }
                }
                else if (double.Parse(sum) >= 0) // sum dont have - operater
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
            }
            else// sum don't have . 
            {
                if (double.Parse(sum) < 0) // check sum if sum have - operater
                {
                    if (sum.Length > 17)  // check length if more than 18 digit include - and .
                    {
                        sum = sum.Substring(0, 17); // change to 16 digit
                    }
                }
                else if (double.Parse(sum) >= 0) // sum dont have - operater
                {
                    if (sum.Length > 16) // check length if more than 17 digit include . 
                    {
                        sum = sum.Substring(0, 16); // change to 16 digit
                    }
                }
            }
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
                        }
                    }
                }
                else if (double.Parse(temp) > 0) // dont have - operater
                {
                    if (temp.Length >= 16)// length >18 , round up
                    {
                        int o = int.Parse(temp.Substring(temp.Length - 1, 1));
                        if (o < 5)
                        {
                            temp = roundUp(double.Parse(temp), temp.Length - (2 + k)).ToString();
                            if (string.Compare(sum, temp) == 0)
                            {
                                equalRound = 1;
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
