using System;
using System.Linq;

namespace Assignment1_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q2 enter the string to check for pangram!");

            //taking input and changing it to lower case
            string s = Console.ReadLine().ToLower();
            //calling the function
            bool flag = CheckIfPangram(s);

            if (flag)
            {
                Console.WriteLine("Yes, the given string is a pangram");
            }
            else
            {
                Console.WriteLine("No, the given string is not a pangram");
            }

        }

        private static bool CheckIfPangram(string s)
        {

            //using distinct to get the unique values of the string given and counting if there are 26 different values.
            string ConditionCheck = new String(s.Distinct().ToArray());//creating a new arry with disctict values of all characters if it has a-z i.e 26 then it is a pangram
            
            if(ConditionCheck.Length == 26)//if unique values are 26 then it is a pangram,26 distinct values
            {
                return true;
            }
            else//else it is not a pangram
            {
                return false;
            }


        }

        

    }
}
