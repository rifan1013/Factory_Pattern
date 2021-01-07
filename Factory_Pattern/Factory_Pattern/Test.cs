using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Com._13FactoyPattern
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            string input = Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input, out num1);
            if (!result)
            {
                Console.WriteLine("please enter a number");
                return;
            }
            Console.WriteLine("Enter second number");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result)
            {
                Console.WriteLine("please enter number");
                return;
            }
            Console.WriteLine("enter Add,Substarct or Divide");
            CaluclateFactory factory = new CaluclateFactory();
            ICalculate obj =factory.GetCalculation(Console.ReadLine());
            //Divide obj = new Divide();
            obj.Calculate(num1, num2);
            Main();

        }
    }
}
