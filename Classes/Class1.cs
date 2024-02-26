using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass.Classes
{
/// <summary>
/// Ahmed Shoman
/// Std:4281503
/// Module:PRG6221
/// </summary>
    internal class Class1
    {
//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<******************>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public string hello(string str)
        {
            return str;
        }
//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<******************>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public string Calc(string i, string k, string opertr)
        { int result=0;
            if (opertr == "+")
                result = int.Parse(i) + int.Parse(k);
         else if (opertr == "-")
                result = int.Parse(i) - int.Parse(k);
            else if (opertr == "*")
                result = int.Parse(i) * int.Parse(k);
            else if (opertr == "/")
                result = int.Parse(i) / int.Parse(k);
            else
                return "Error,type one of the operators:*,-,+,/";

            return result.ToString(); 
        }

 //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<******************>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public string print(string s)
        {
            string a = " DDDDDDDDD ";
            s= s.ToUpper();
            s=  String.Format("{1}{0} This is {0} Formated {1} Text {0}" ,s,a);
            return s;
        }


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<******************>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        //main method that call sub method of operations after identifyying the type of operation
        /// <summary>
        /// https://www.c-sharpcorner.com/blogs/simple-calculator-console-app-using-c-sharp
        /// </summary>
        /// this code to calculate using two arguments with different operators
        /// <param name="args"></param>
        static void Main(string[] args)
            {
                Console.WriteLine("Enter the action to be performed:");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division\n");

                int action = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the first input:");
                int input_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second input:");
                int input_2 = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                switch (action)
                {
                    case 1:
                        result = Addition(input_1, input_2);
                        break;
                    case 2:
                        result = Subtraction(input_1, input_2);
                        break;
                    case 3:
                        result = Multiplication(input_1, input_2);
                        break;
                    case 4:
                        result = Division(input_1, input_2);
                        break;
                    default:
                        Console.WriteLine("Wrong action! Please try again.");
                        break;
                }

                Console.WriteLine("The result is: {0}", result);
                Console.ReadKey();
            }

            // Addition method
            public static int Addition(int input_1, int input_2)
            {
            int x = 0;
                return input_1 + input_2;// returning the result of additional calculation
            }

            // Subtraction method
            public static int Subtraction(int input_1, int input_2)
            {
                return input_1 - input_2;
            }

            // Multiplication method
            public static int Multiplication(int input_1, int input_2)
            {
                return input_1 * input_2;
            }

            // Division
            public static int Division(int input_1, int input_2)
            {
                return input_1 / input_2;
            }
    }
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<******End*******>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
}


 
