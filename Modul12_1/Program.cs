using System;
using System.Collections.Generic;
using System.Threading;


namespace SF.Modul12_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> user = new List<User>(5){
            new User() { Login = "ivan", Name = "Иван", IsPremium = true},
            new User() { Login = "liza", Name = "Елизавета", IsPremium = false},
            new User() { Login = "boris", Name = "Борис", IsPremium = true},
            new User() { Login = "eva", Name = "Ева", IsPremium = true},
            new User() { Login = "miha", Name = "Михаил", IsPremium = false}
            };

            foreach (User polz in user)
            {
                Console.WriteLine("Здравствуйте {0}! ", polz.Name);
                if (!polz.IsPremium)
                {
                    ShowAds();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Все пользователи поприветствованы!");

            Console.ReadKey();
        }
        /// <summary>
        /// Реклама
        /// </summary>
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

    }
}
