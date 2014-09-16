using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            double HPR = 13.50;
            double HW = 25;
            string Input;

            double gross = HPR * HW;

            Console.Write("Hourly pay rate: ");
            Input = Console.ReadLine();

            Console.Write("Hours worked: ");
            Input = Console.ReadLine();

            Console.WriteLine("Gross pay is {0}", gross);

    

        }
    }
}
