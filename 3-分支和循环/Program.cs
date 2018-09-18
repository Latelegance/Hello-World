using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10) {
                Console.WriteLine("The answer is greater than 10.");
            }
            else {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a > b)) {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b)) {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n使用 if 语句做出决定：");
                ExploreIf();

            Console.WriteLine("\n使用循环重复执行运算：");
                //无限循环必须使用 CTRL-C 或其他方法强制退出程序
                
                int counter = 0;
                while (counter < 10) {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                }

                counter = 0;
                do {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                }
                while (counter < 10);

                for(int index = 0; index < 10; index++) {
                    Console.WriteLine($"Hello World! The index is {index}");
                }
            
            Console.WriteLine("\n结合使用分支和循环：");
                
                int sum = 0;
                for(int i = 1; i <=20; i++ ) {
                    
                    if ( i % 3 == 0 ) {
                        sum = sum + i;
                    }
                }
                Console.WriteLine(sum);
            



        }
    }
}
