// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет      // 12821 -> да    // 23432 -> да
using System;

namespace homework
{
    class Program
    {
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }


        static void Main()
        {
            Print("Введите пятизначное число");

            string num = Console.ReadLine();

            for (int i = num.Length -1; i > -1; --i)
            {
                Console.Write(num[i]);
            }

            if (num[0] == num[4] && num[1] == num[3])
            {
                Print("\nЧисло падиндром");
            }
            else
            {
                Print("\nЧисло не падиндром");
            }
        }
    }

}




