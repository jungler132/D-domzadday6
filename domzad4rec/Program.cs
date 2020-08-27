using System;

namespace domzad4rec
{
    class Program
    {
        static void Main(string[] args)
        {
            ///dom zad 4
            (int a_1, int b_1, bool valid_check) = (0, 0, false);
            do
            {
                int a = tryparse("first");
                int b = tryparse("second");
                (a_1, b_1, valid_check) = check_valid(a, b);
            }
            while (valid_check == false);
            Console.WriteLine(diapazon(a_1 + 1, b_1 - 1));
        }
        static int diapazon(int a, int b)
        {           
            if (a == b)
            {
                return b;
            }
            else
            {
                return a + diapazon(a + 1, b);
            }
        }
        static int tryparse(string message)
        {
            int num1;
            bool triger = false;
            do
            {
                Console.WriteLine($"input {message} number");
                if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0)
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
        static (int,int,bool) check_valid(int a, int b)
        {
            if (a > b)
            {
                int c;
                c = a;
                a = b;
                b = c;
            }
            if (Math.Abs(a - b) == 1)
            {
                Console.WriteLine("Wrong numbers");
                return (0,0,false);
            }
            else
            {
                return (a,b,true);
                
            }
        }
    }
}
