﻿// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"



// int N = int.Parse(Console.ReadLine()); // 4
// int start = N * (-1); // -N, = -4
// while (start <= N)
// {
//     Console.Write(start + " ");
//     start++;
// } 

// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine()); // 4
// int start = N * (-1); // -N, = -4
// while (start <= N)
// {
//     Console.Write(start + " ");
//     start+=2;
// }

// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 100 && number < 1000)
{
    Console.WriteLine(number %10);
}
else 
{
   Console.WriteLine("Число не трехзначное"); 
}
