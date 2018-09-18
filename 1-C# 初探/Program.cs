using System;

namespace C__初探
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n运行首个 C# 程序：");
                Console.WriteLine("Hello World!");
            
            Console.WriteLine("\n声明和使用变量：");
                string aFriend = "bill";
                Console.WriteLine(aFriend);

                aFriend = "Maira";
                Console.WriteLine(aFriend);

                Console.WriteLine("Hello " + aFriend);

                Console.WriteLine($"Hello {aFriend}");

            Console.WriteLine("\n使用字符串："); 
                string firstFriend = "Maria";
                string secondFriend = "Sage";
                Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

                Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
                Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
            
            Console.WriteLine("\n发掘字符串的更多精彩用途：");
                string greeting = "      Hello World!       ";
                Console.WriteLine($"[{greeting}]");

                string trimmedGreeting = greeting.TrimStart();
                Console.WriteLine($"[{trimmedGreeting}]");

                trimmedGreeting = greeting.TrimEnd();
                Console.WriteLine($"[{trimmedGreeting}]");

                trimmedGreeting = greeting.Trim();
                Console.WriteLine($"[{trimmedGreeting}]");

                string sayHello = "Hello World!";
                Console.WriteLine("\n"+sayHello);
                sayHello = sayHello.Replace("Hello", "Greetings");
                Console.WriteLine(sayHello);

                Console.WriteLine(sayHello.ToUpper());
                Console.WriteLine(sayHello.ToLower());

            Console.WriteLine("\n搜索字符串：");
                string songLyrics = "You say goodbye, and I say hello";
                Console.WriteLine(songLyrics.Contains("goodbye"));
                Console.WriteLine(songLyrics.Contains("greetings"));
            
            Console.WriteLine("\n完成挑战：");
                Console.WriteLine(songLyrics.StartsWith("You"));
                Console.WriteLine(songLyrics.StartsWith("goodbye"));

                Console.WriteLine(songLyrics.EndsWith("hello"));
                Console.WriteLine(songLyrics.EndsWith("goodbye"));

            Console.WriteLine("\n已完成“C# 初探”快速入门教程。\n");
        }
    }
}
