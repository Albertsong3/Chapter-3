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
            double HPR;
            double HW;
            string Input;

            double gross;

            Console.Write("Hourly pay rate: ");
            Input = Console.ReadLine();
            HPR = Convert.ToDouble(Input);

            Console.Write("Hours worked: ");
            Input = Console.ReadLine();
            HW = Convert.ToDouble(Input);   


            gross = HPR * HW;

            Console.WriteLine("Gross pay is {0}", gross);


    

        }
    }
}
