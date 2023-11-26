using System;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static Program;


class Program
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }

    static void Main(string[] args)
    {
        List<User> users = new List<User>
        {
            new User()
            {
                Login = "user1",
                Name = "Peter",
                IsPremium = true,
            },
            new User()
            {
                Login = "user2",
                Name = "Alex",
                IsPremium = false,
            },
            new User()
            {
                Login = "user3",
                Name = "Jennifer",
                IsPremium = false,
            }
        };
        CheckUser(users);
    }

    static void CheckUser(List<User> users)
    {
        foreach(var user in users)
        {
            if (!user.IsPremium)
            {
                Greeting(user.Name);
                ShowAds();
            }
            else
            {
                Greeting(user.Name);
            }
        }
    }

    static void Greeting(string name)
    {
        Console.WriteLine($"Привет, {name}!");
    }

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




