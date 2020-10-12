using System;

namespace Textgame1
{
    class Program
    {
        static void Question(string[] answers, string question, string defaultAnswer)
        {
            Console.WriteLine(question);
            int response = Convert.ToInt32(Console.ReadLine());
            if (response > 0 && response <= answers.Length)
            {
                Console.WriteLine(answers[response - 1]);
            }
            else
            {
                Console.WriteLine(defaultAnswer);
            }

        }

        static void Main(string[] args)
        {
            string[] answers = new string [] { "Поздравляю!" , "А ты хорош!)" };
            Question(answers,
                "Здравствуй, херой \nСкажи мне, ты пидор?\nВведи 1 если да, введи 2, если да.",
                "Ты мало того, пидар, так ещё и тупой. Нажми 1 или 2, дегрод заднеприводный!"
                );
            answers = new string[] { "В жопу надоело, теперь ещё и в глазницу пустую долбишься?", "Поздравляю!)"};
            Question(answers,
                "Скажи, вилкой в глаз, или в жопу раз? \nВведи 1 если вилкой, введи 2, если да.",
                "Выучи цифру 1 и цифру 2. А то ни один нормальный мужик на твоё очко не посмотрит."
                );
            int money = 0;
            answers = new string[] { "На тебе твои копейки. " + (money + 15) + " денег",
                "Поздравляю! Твоё очко принесло тебе " + (money + 1000) + " денег",
                "Поздравляю, ты проебал все свои копейки, и в жопу тебя пьяного бесплатно выебали)))"

            };

            Question(answers,
                "Хочешь денюжку? Денюжка зарабатывается." +
                "\nНапиши 1 чтобы заработать 15 бабосов честным трудом," +
                "\nнапиши 2, чтобы заработать 1000 привычным для тебя способом," +
                "\nнапиши 3, чтобы всё пробухать.",
                "Чувак, у меня для тебя плохие новости. Ты очень тупой, потому что а) до сих пор в это играешь, бэ) ты так и не понял, куда жмакать."
                );


            Console.WriteLine("Тебе еще не надоело быть пидаром? \nСходи в церковь - 1, сходи к бабке - 2, никуда не ходи - 3.");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    Console.WriteLine("Те" + (money + 15) + " денег");
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
