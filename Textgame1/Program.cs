﻿using System;

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
            string[] answers = new string [] { //результат выбора пользователя//
                "Поздравляю!" , "А ты хорош!)" };
            Question(answers, //вопрос, предлагаемые пользователю варианты ответа + дефолт//
                "Здравствуй, херой \nСкажи мне, ты пидор?\nВведи 1 если да, введи 2, если да.",
                "Ты мало того, пидар, так ещё и тупой. Нажми 1 или 2, дегрод заднеприводный!"
                );
            answers = new string[] {//результат выбора пользователя//
                "В жопу надоело, теперь ещё и в глазницу пустую долбишься?", "Поздравляю!)"};
            Question(answers, //вопрос, предлагаемые пользователю варианты ответа + дефолт//
                "Скажи, вилкой в глаз, или в жопу раз? \nВведи 1 если вилкой, введи 2, если да.",
                "Выучи цифру 1 и цифру 2. А то ни один нормальный мужик на твоё очко не посмотрит."
                );


            int money = 0;
            answers = new string[] {//результат выбора пользователя//
                "На тебе твои копейки. " + (money + 15) + " денег",
                "Поздравляю! Твоё очко принесло тебе " + (money + 1000) + " денег",
                "Поздравляю, ты проебал все свои копейки, и в жопу тебя пьяного бесплатно выебали)))"

            };

            Question(answers, //вопрос, предлагаемые пользователю варианты ответа + дефолт//
                "Хочешь денюжку? Денюжка зарабатывается." +
                "\nНапиши 1 чтобы заработать 15 бабосов честным трудом," +
                "\nнапиши 2, чтобы заработать 1000 привычным для тебя способом," +
                "\nнапиши 3, чтобы всё пробухать.",
                "Чувак, у меня для тебя плохие новости. Ты очень тупой, потому что \nа) до сих пор в это играешь, \nбэ) ты так и не понял, куда жмакать."
                );
            
            answers = new string[] { //результат выбора пользователя//
                "Ты потратил все свои бабки. Теперь у тебя" + (money * 0) + " денег, но ты теперь не пидор",
                "Поздравляю! Шарлатанка тебя развела." +
                "\nТеперь ты должен " + (money = -100500) + " денег в банке, и за тобой охотятся коллекторы," +
                "\nкоторые сначала трахнут тебя забесплатно, а потом ещё и счёт выставят",
                "Поздравляю, ты дома нащел банку сгухи, сожрал, подавился и сдох."

            };

            Question(answers, //вопрос, предлагаемые пользователю варианты ответа + дефолт//
                "Тебе еще не надоело быть пидаром ?" +
                "\nСходи в церковь - 1," +
                "\nсходи к бабке - 2" +
                "\nникуда не ходи - 3.",
                "Тот факт, что тебя не научили отличать циферки 1, 2 и 3 от других значков —" +
                "\nтвои сугубо личные половые труднсти. Найми репетитора и поппробуй ещё раз."
                );


        }
    }
}
