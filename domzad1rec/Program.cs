using System;

namespace domzad1rec
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Домашнее задание на тему Рекурсия и методы, кортежи, перечисления
            Console.WriteLine(Proc(2, 2, 0));
        }
        static int Proc(int num = 2, int steps = 2, int result = 0)
        {
            if (steps > 10)
            {
                return result;
            }
            else
            {
                return Proc(num *= 2, steps += 1, result += num);
            }
        }
    }
}
