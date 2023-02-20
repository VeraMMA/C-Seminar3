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
            Print("Является ли пятизначное число палиндромом.");
            Print("Введите пятизначное число:");
            
          int Num = 12821;
            // if (numberA = numberB && numberX = numberY)
            // {
            //     Print("Нет");
            // }
            // {
            //     Print("Да");
            // }

            firstDigit(Num);
            static void firstDigit(int numberB)
            {
                if (numberB > 10000)
                    numberB = numberB/10000 % 10;
                Console.WriteLine(numberB);
            }
            
            fiveDigit(Num);
            static void fiveDigit(int numberA)
            {
                if (numberA > 10000)
                    numberA = numberA / 1 % 10;
                
                Console.WriteLine(numberA);

            }

            secondDigit(Num);
            static void secondDigit(int numberX)
            {
                if (numberX > 10000)
                    numberX = numberX / 1000 % 10;
                Console.WriteLine(numberX);
            }

            fourDigit(Num);
            static void fourDigit(int numberY)
            {
                if (numberY > 10000)
                    numberY = numberY / 10 % 10;
                
                Console.WriteLine(numberY);

            }

        

            




            
            

        }

    }

}

