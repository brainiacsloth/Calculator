using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(String[] args)
            {

                int num = Convert.ToInt32("45");
                Console.WriteLine(num + 6);

                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 + num2);

                double num3 = Convert.ToDouble(Console.ReadLine());
                double num4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num3 + num4);
            }
        
    }
}
