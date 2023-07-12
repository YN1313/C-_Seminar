// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine(number * number);


Console.WriteLine("Введите число: "); // подсказка для пользователя 
int number = int.Parse(Console.ReadLine()); // Console.ReadLine() - считывает с консоли 
int result = number * number; // храним результат вычисления числа само на себя
Console.WriteLine("Квадрат числа = " + result); // конкатенация склеивание строки через