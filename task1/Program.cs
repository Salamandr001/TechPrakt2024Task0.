using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число:");
         
            string input1 = Console.ReadLine();
            
            double number1 = Convert.ToDouble(input1);

            Console.WriteLine("Введіть друге число:");
            
            string input2 = Console.ReadLine();
           
            double number2 = Convert.ToDouble(input2);

           
            double sum = number1 + number2;

            
            Console.WriteLine("Сума чисел: " + sum);

            Console.ReadLine();
        }
    }
}
