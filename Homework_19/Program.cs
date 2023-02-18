// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет      // 12821 -> да    // 23432 -> да
using System;

namespace homework
{    class Program
    {
        static void Main()
        {
           Print("Проверить является ли пятизначное число палиндромом:");
           Print("Введите пятизначное число:");
           Digit(12821);
        }
        public static void Print(string word){
            Console.WriteLine(word);
        }
          
        static void Digit (int numberA)
        {
            
            if(numberA > 99 && numberA < 1000)
              numberA = numberA / 10 % 10;
            Console.WriteLine(numberA);

        } 

    }

}