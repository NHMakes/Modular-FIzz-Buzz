using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_Fizz_Buzz
{
    class Program
    {
        ///<summary>Typical FizzBuzz answer example 3</summary>
        ///<descrition>
        ///     This example shows a more intermediate - advance answer. You provide a list of modulas numbers into the Items array. Then 
        ///     provide a related Output name in the Outputs array.
        ///     
        ///     Program also includes an array length comparison to ensure IndexOutOfBounds exception doesn't happen.
        /// </description>

        static void Main(string[] args)
        {
            int[] Items = new int[] { 3, 5, 7, 10 };
            string[] Outputs = new string[] { "Fizz", "Buzz", "Fuzz", "Bizz" };

            if(Items.Length != Outputs.Length)
                Console.WriteLine("Please ensure both arrays are the same length.");
            else
                for (int i = 1; i <= 100; i++)
                {
                    string Output = "";

                    for (int j = 0; j < Items.Length; j++)
                        if (i % Items[j] == 0)
                            Output = Output + Outputs[j];

                    if (Output != "")
                        Console.WriteLine(Output);
                    else
                        Console.WriteLine(i);
                }

            Console.Read();
        }
    }
}
