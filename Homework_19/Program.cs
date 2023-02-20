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
        {   Print("Проверить является ли пятизначное число падиндромом");
            Print("Введите пятизначное число: ");

            string digit = Console.ReadLine();

            for (int i = digit.Length -1; i > -1; --i)
            {
                Console.Write(digit[i]);
            }

            if (digit[0] == digit[4] && digit[1] == digit[3])
            {
                Print("\n Число является палиндромом");
            }
            else
            {
                Print("\n Число не является падиндромом");
            }
        }
    }

}




