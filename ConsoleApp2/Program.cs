using System;
namespace TemperatureProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("It's temperature conversion program");
            
            Class1 class1 = new Class1();
            class1.CelciusToFarheinheit();
           // class1.FarheinheitToCelcius();
        }
    }
}