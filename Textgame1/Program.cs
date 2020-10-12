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
            Console.WriteLine("Хочешь денюжку? Денюжка зарабатывается. \nНапиши 1 чтобы заработать 15 бабосов честным трудом, \nнапиши 2, чтобы заработать 1000 привычным для тебя способом," +
                "\nнапиши 3, чтобы всё пробухать.");

            int money = 13;
            int с = Convert.ToInt32(Console.ReadLine());
            switch (с)
            {
                case 1:
                    Console.WriteLine("На тебе твои копейки. " + (money + 15) +" денег");
                    break;
                case 2:
                    Console.WriteLine("Поздравляю! Твоё очко принесло тебе " + (money + 1000) + " денег");
                    break;
                case 3:
                    Console.WriteLine("Поздравляю, ты проебал все свои копейки, и в жопу тебя пьяного бесплатно выебали)))");
                    break;
                default:
                    Console.WriteLine("Чувак, у меня для тебя плохие новости. Ты очень тупой, потому что а) до сих пор в это играешь, бэ) ты так и не понял, куда жмакать.");
                    break;
            }
            Console.WriteLine("Тебе еще не надоело быть пидаром? \nСходи в церковь - 1, сходи к бабке - 2, никуда не ходи - 3.");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (с)
            {
                case 1:
                    Console.WriteLine("На тебе твои копейки. " + (money + 15) + " денег");
                    break;
                case 2:
                    Console.WriteLine("Поздравляю! Твоё очко принесло тебе " + (money + 1000) + " денег");
                    break;
                case 3:
                    Console.WriteLine("Поздравляю, ты проебал все свои копейки, и в жопу тебя пьяного бесплатно выебали)))");
                    break;
                default:
                    Console.WriteLine("Чувак, у меня для тебя плохие новости. Ты очень тупой, потому что а) до сих пор в это играешь, бэ) ты так и не понял, куда жмакать.");
                    break;
            } 


        }
    }
}
