using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_using_enum
{
    internal class Program
    {
        
           enum operation
        {
            Add = '+',
            Subtract = '-',
            Multiply = '*',
            Divide = '/',
            Modulus = '%'
        }

        static void Main(string[] args)
        {
            

            Console.WriteLine("Choose operation: +, -, *, /, %   ");
            operation op = (operation)char.Parse(Console.ReadLine());
           
            Console.Write("Enter first number: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            
            decimal result = 0;

            if (op == operation.Add)
                result = num1 + num2;

            else if (op == operation.Subtract)
                result = num1 - num2;

            else if (op == operation.Multiply)
                result = num1 * num2;

            else if (op == operation.Divide)
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return;
                }
            }
            else if (op == operation.Modulus)
            {
                if (num2 != 0)
                    result = num1 % num2;
                else
                {
                    Console.WriteLine("Cannot use modulus by zero!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation!");
                return;
            }

            Console.WriteLine($"Result = {result}");



            


        }
    }
}
