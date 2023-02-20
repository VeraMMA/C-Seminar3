// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using System;

namespace homework
{
    class Program
    {    
        
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }

        static void Main(string[] args)
        {
            Print("По координатам двух точек найдите расстояние между ними в 3D пространстве");
            Print("Введите координаты точек");
           
             Print("Введите xb");
            int xb = Convert.ToInt32(Console.ReadLine());
            Print("Введите xa");
            int xa = Convert.ToInt32(Console.ReadLine());
            Print("Введите yb");
            int yb = Convert.ToInt32(Console.ReadLine());
            Print("Введите ya");
            int ya = Convert.ToInt32(Console.ReadLine());
            Print("Введите zb");
            int zb = Convert.ToInt32(Console.ReadLine());
            Print("Введите za");
            int za = Convert.ToInt32(Console.ReadLine());
               

             Double AB = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya,2) + Math.Pow(zb - za, 2));
             System.Console.WriteLine(AB);
              
        }
        

    }

}


