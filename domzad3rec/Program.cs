using System;

namespace domzad3ec
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int stp = int.Parse(Console.ReadLine());
            stepen_hw(numb, stp);
            Console.WriteLine(stepen_hw(numb, stp));
            Console.ReadKey();
        }
        static int stepen_hw(int numb, int stp)
        {
            if (stp == 0)
            {
                return 1;
            }
            else
            {
                return numb * stepen_hw(numb, stp - 1);
            }
        }
    }
}
