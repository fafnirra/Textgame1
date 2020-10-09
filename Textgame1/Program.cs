using System;

namespace Textgame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй, херой \nСкажи мне, ты пидор?");
            Console.WriteLine("Введи 1 если да, введи 2, если да.");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Поздравляю!");
                    break;
                case 2: Console.WriteLine("А ты хорош!)");
                    break;
                default: Console.WriteLine("Ты мало того, пидар, так ещё и тупой. Нажми 1 или 2, дегрод заднеприводный!");
                    break;

            }

          
        }
    }
}
