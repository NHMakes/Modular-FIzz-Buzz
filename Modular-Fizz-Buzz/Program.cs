using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_Fizz_Buzz
{
    class Program
    {
        ///<summary>Typical FizzBuzz answer.</summary>
        ///<descrition>
        ///     Note this requires a lot of code/variables to change and only works with 2 numbers unless you fancy adding the next number into 
        ///     the first if() and then adding another else if at the bottom as well. 
        /// </description>
        /// <example>
        /// 
        ///     if((i % 3 == 0) && (i % 5 ==0) && (i % 7 == 0))
        ///         Console.WriteLine("FizzBuzzFuzz");
        /// 
        ///     [...]
        ///     
        ///     else if(i % 7== 0)
        ///         Console.WriteLine("Fuzz");
        ///         
        /// </example>
        static void Main(string[] args)
        { 
            for (int i = 1; i <= 100; i++)
            {
                if((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine("FizzBuzz");
                else if(i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if(i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
