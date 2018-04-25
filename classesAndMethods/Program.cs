using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome to the math operations engine. Enter a number:";
            Console.WriteLine(welcome);

            int input = Convert.ToInt32(Console.ReadLine());

            MathOperations math = new MathOperations();

            Console.WriteLine("Divide by 3 returns: " + math.numDivide(input) + ", multiply by 2 returns: " + 
                                math.numDouble(input) + ", and add by 4 returns: " + math.numAdd(input));
            Console.ReadLine();

        }
    }
}
