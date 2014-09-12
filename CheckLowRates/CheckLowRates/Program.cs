using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String Input;

            Double HPR; 
            Console.Write("Hourly pay rate: ");
            Input = Console.ReadLine();
            HPR = Convert.ToDouble(Input);

                if (HPR < 5.65)
                Console.WriteLine("Error...value is to low");
        
                



        }
    }
}
