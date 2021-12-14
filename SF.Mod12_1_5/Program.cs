using System;
using System.Collections.Generic;
using System.Threading;

namespace SF.Mod12_1_5
{
    /// <summary>
    /// Задание 12.1.5
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //// список пользователей
            List<User> userList = new()
            {
                new() { Login = "Ivanov", Name = "Иванов", IsPremium = false },
                new() { Login = "Petrov", Name = "Петров", IsPremium = true },
                new() { Login = "Sidorov", Name = "Сидоров", IsPremium = false }
            };

            //// Для списка пользователей
            foreach (User user in userList)
            {
                //// добавьте приветствие по имени
                Console.WriteLine("Здравствуйте, {0}", user.Name);

                //// Если пользователь не имеет премиум-подписки
                if (!user.IsPremium)
                {
                    //// то ему нужно показать рекламу
                    ShowAds();
                }
            }
        }

        /// <summary>
        /// Метод для показа реклама
        /// </summary>
        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            //// Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            //// Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            //// Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
