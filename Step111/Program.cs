using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step111
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What number would you like to add 10 to?");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int additionResult = Numbers.Addition(firstNumber);
            Console.WriteLine(additionResult);
          

            Console.WriteLine("What number would you like to subtract 5 from?");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int subtractionResult = Numbers.Subtraction(secondNumber);
            Console.WriteLine(subtractionResult);
           

            Console.WriteLine("What number would you like to multiply by 2?");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int multiplyResult = Numbers.Multiply(thirdNumber);
            Console.WriteLine(multiplyResult);
            Console.ReadLine();

        }
    }
}
