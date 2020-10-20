using System;

namespace domzad2rec
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = tryparse("First");
            double num2 = tryparse("Second");
            Console.WriteLine(Nod(num1, num2));
            Console.ReadKey();
        }
        static double Nod(double num1, double num2)
        {
            int r = 0;
            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                if (num1 > num2)
                {
                    return num2;
                }
                else if (num2 > num1)
                {
                    return num1;
                }
            }
            else if (num1 > num2 && (num1 % num2) > 0)
            {
                return Nod(num1 % num2, num2);
            }
            else if (num2 > num1 && (num2 % num1) > 0)
            {
                return Nod(num1, num2 % num1);
            }
            return r;
        }
        static double tryparse(string message)
        {
            double num1;
            bool triger = false;
            do
            {
                Console.WriteLine($"input {message} number");
                if (double.TryParse(Console.ReadLine(), out num1) && num1 > 0)
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("wrong number try again");
                    continue;
                }
            }
            while (triger == false);
            return num1;
        }
    }
}
