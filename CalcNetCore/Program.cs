using System;
using System.Threading;


namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALC: +, -, *, /, %, p");
            
            float a, b;
            char c;
            
            Console.Write("Enter Number 1: ");
            a = float.Parse(Console.ReadLine());
            
            Console.Write("Enter Number 2: ");
            b = float.Parse(Console.ReadLine());
            
            Console.Write("Enter Action: ");
            c = char.Parse(Console.ReadLine());

            try
            {
                if (c == '+')
                    Console.WriteLine("result = "+ (a + b));
                
                else if (c == '-')
                    Console.WriteLine("result = "+ (a - b));

                else if (c == '*')
                    Console.WriteLine("result = "+ (a * b));
                
                else if (b == 0)
                    Console.WriteLine("DivideByZeroException");

                else if (c == '/')
                    Console.WriteLine("result = "+ (a / b));

                else if (c == 'm')
                    Console.WriteLine("result = "+ (a % b));
                
                else if (c == ('p'))
                    Console.WriteLine("result = " + (Math.Pow(a, b)));
            
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
                throw;
            }
        }
    }
}