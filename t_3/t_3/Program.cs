using System;
using System.Threading;

namespace t_3
{
    class Program
    {
        public delegate int DisplayHandler();
        static void Main(string[] args)
        {
            DisplayHandler handler = new DisplayHandler(Display);
            int result = handler.Invoke();

            Console.WriteLine("Продолжается работа метода Main");
            Console.WriteLine("Результат равен {0}", result);

            Console.ReadLine();
        }

        static int Display()
        {
            Console.WriteLine("Начинается работа метода Display....");
            Random random = new Random();
            int a = random.Next(3, 43);
            int[] mas = new int[a];
            Console.WriteLine($"Числа, делящиеся на 3:");
            int b = 0;

        
            for (int i = 0; b < mas.Length; i++)
            {
                if (i % 3 == 0)
                {
                    mas[b] = i;
                    Console.WriteLine(mas[b]);
                    b++;
                }
            }

            Thread.Sleep(3000);
            Console.WriteLine("Завершается работа метода Display....");
            return a;
        }
    }
}