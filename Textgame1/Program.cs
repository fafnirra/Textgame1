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
                case 1:
                    Console.WriteLine("Поздравляю!");
                    break;
                case 2:
                    Console.WriteLine("А ты хорош!)");
                    break;
                default:
                    Console.WriteLine("Ты мало того, пидар, так ещё и тупой. Нажми 1 или 2, дегрод заднеприводный!");
                    break;
            }
            Console.WriteLine("Скажи, вилкой в глаз, или в жопу раз? \nВведи 1 если вилкой, введи 2, если да.");
            
            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1:
                    Console.WriteLine("В жопу надоело, теперь ещё и в глазницу пустую долбишься?");
                    break;
                case 2:
                    Console.WriteLine("Поздравляю!)");
                    break;
                default:
                    Console.WriteLine("Выучи цифру 1 и цифру 2. А то ни один нормальный мужик на твоё очко не посмотрит.");
                    break;
            }

        }
    }
}
