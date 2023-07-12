// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите числа: ");
// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());
// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Первое число явялется квадратом второго");
// }
// else 
// {
//     Console.WriteLine("Второе число не является квадратом");
// }

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7 ");
string number = Console.ReadLine();
if (number == "1")
{
    Console.Write("Понедельник");
}
if (number == "2")
{
    Console.Write("Вторник");
}
if (number == "3")
{
    Console.Write("Среда");
}
if (number == "4")
{
    Console.Write("Четверг");
}
if (number == "5")
{
    Console.Write("Пятница");
}
if (number == "6")
{
    Console.Write("Суббота");
}
if (number == "7")
{
    Console.Write("Воскресенье");
}
else 
{
    Console.WriteLine("Error");
}