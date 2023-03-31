using System;

namespace _20230331_ex1_이광재
{
    class MainApp
    {
        static double Square(double arg)
        {
            double result;
            result = arg * arg;

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
