using System;

namespace Open_Lab_02._6
{
    class Program
    {
        public static bool Divisible(int input)
        {
            return input % 100 == 0;
        }
        static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Divisible(input));

        }
    }
}
