using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass.Classes
{
    internal class Class1
    {
        public string hello(string str)
        {
            return str;
        }

        public string Calc(int i, int k, string opertr)
        { int result=0;
            if (opertr == "+")
                result = i + k;
            if (opertr == "-")
                result = i - k;
            if (opertr == "*")
                result = i * k;
            else
                return "Error,type one of the operators:*,-,+";

            return result.ToString(); 
        }

    }
}
