using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void WorkingWithStrings()
        {
            Console.WriteLine("\n基本列表示例：");
                var names = new List<string> { "Latelegance", "Ana", "Felipe" };
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine();
                names.Add("Maria");
                names.Add("Bill");
                names.Remove("Ana");
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine();
                Console.WriteLine($"My name is {names[0]}");
                Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

                Console.WriteLine($"The list has {names.Count} people in it");
            
            Console.WriteLine("\n搜索列表并进行排序：");

            var index = names.IndexOf("Felipe");
            if (index == -1){
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else{
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1){
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else{
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }

            names.Sort();
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
        static void Main(string[] args)
        {
            WorkingWithStrings();

            Console.WriteLine("\n其他类型的列表：");
                var fibonacciNumbers = new List<int> {1, 1};
                while (fibonacciNumbers.Count < 20){
                    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                    fibonacciNumbers.Add(previous + previous2);
                }
                foreach(var item in fibonacciNumbers)
                    Console.WriteLine(item);

            Console.WriteLine("\n挑战：");
                var ifibonacciNumbers = new List<int> {1, 1};
                Console.WriteLine("1\n1");
                for (int i = 3; i <= 20; i++){
                    var iprevious = ifibonacciNumbers[ifibonacciNumbers.Count - 1];
                    var iprevious2 = ifibonacciNumbers[ifibonacciNumbers.Count - 2];
                    ifibonacciNumbers.Add(iprevious + iprevious2);
                    Console.WriteLine(ifibonacciNumbers[i-1]);
                }
        }
    }
}