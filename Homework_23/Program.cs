
using System;

namespace homework
{
    class Program
    {
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }

        
        static void cube (int N)
        {
            for (int i = 1; i < N; i++)
            {
                System.Console.WriteLine(i + "\t" + Math.Pow(i, 3));
            }   
           
        }
        static void Main()
        {
            Print("Вывести таблицу кубов чисел от 1 до N.");
            
            cube(6);

        }

    }
}
