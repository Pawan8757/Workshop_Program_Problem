using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureProblem
{
    public class Class1
    {
        public  void FarheinheitToCelcius()
        {
            Console.WriteLine("Enter the temp");
            int farhenheit = Convert.ToInt32(Console.ReadLine());
            double celcius = (farhenheit - 32) * 5 / 9;
            Console.WriteLine("celcius=" + celcius);
            Console.ReadLine();
        }

        public  void CelciusToFarheinheit()
        {
            Console.WriteLine("Enter the temp");
            int celcius = Convert.ToInt32(Console.ReadLine());

            double farheinheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("farheinheit = " + farheinheit);
            Console.ReadLine();
        }
    }
}
