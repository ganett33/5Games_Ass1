using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace _5Games_Ass1.Data
{
    class Lotto_Class
    {
        private int[] numArray;
        private Random number;
        private int temp;

        public Lotto_Class()
        {
            numArray = new int[6];
            number = new Random(DateTime.Now.Millisecond);
        }
        public void SetNumbersToZero()      //Set Lotto number of row
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = 0;
            }
        }
        public void GenerateNumbers()       //Lotto random generator
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                temp = number.Next(1, 41);
                while (IsDuplicate(temp, numArray))     //Check duplicate
                {
                    temp = number.Next(1, 41);

                }
                numArray[i] = temp;
            }

            
        }
        public void GeneratePower()   //Powerball random generator
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = number.Next(1, 11);
            }
        }

        public void PrintNumbers(TextBlock ticket)          //Print Lotto number
        {
            ticket.Text = ticket.Text + " ";

            for (int i = 0; i < 6; i++)
            {
                if (numArray[i] < 10)
                {

                    ticket.Text = ticket.Text + numArray[i].ToString("00") + " ";
                }
                else
                {
                    ticket.Text = ticket.Text + numArray[i].ToString() + " ";
                }
            }
        }

        private static bool IsDuplicate(int temp, int[] dupArray)          //Check duplicate
        {
            foreach (var item in dupArray)
            {
                if (item == temp)
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintPower(TextBlock ticket)          //Print Powerball number
        {

            for (int i = 0; i < 1; i++)
            {
                if (numArray[i] < 10)
                {
                    ticket.Text = ticket.Text + numArray[i].ToString("00") + " ";       //Set the number form
                                                                                        //smaller than 10 display with 0
                }
                else
                {
                    ticket.Text = ticket.Text + numArray[i].ToString() + " ";    
                }
            }
        }

        public void PrintSign(TextBlock ticket)          //Print Powerball number
        {
            ticket.Text = ticket.Text + "  ⁞ ";

        }

        public void SortNumbers()           //Sort number ascending order
        {
            for (int i = 0; i < numArray.Length - 1; i++)
            {
                for (int j = 0; j < numArray.Length - 1; j++)
                {
                    if (numArray[j] > numArray[j + 1])
                    {
                        temp = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = temp;
                    }
                }
            }
        }

    }

}
