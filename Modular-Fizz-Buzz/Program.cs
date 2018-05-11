using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_Fizz_Buzz
{
    class Program
    {
        ///<summary>Typical FizzBuzz answer example 2</summary>
        ///<descrition>
        ///     This example introduces an Output variable, whereby we concatinate the words Fizz, Buzz, Fuzz etc and does a check at the end
        ///     to display the output.
        ///     
        ///     Unfortunatly it still requires multiple data entries and has repeating code.
        /// </description>
        /// <example>
        /// 
        ///     if (i % 7 == 0) Output += "Fuzz";
        ///     if (i % 10 == 0) Output += "Bizz";
        ///         
        /// </example>
        static void Main(string[] args)
        { 
            for (int i = 1; i <= 100; i++)
            {
                string Output = "";

                if (i % 3 == 0) Output += "Fizz";
                if (i % 5 == 0) Output += "Buzz";

                if(Output != "")
                    Console.WriteLine(Output);
                else
                    Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
