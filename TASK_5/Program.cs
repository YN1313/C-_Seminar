// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int GetRandomNumber()
// {
//     int number = new Random().Next(100, 1000);
//     return number;
// }
// int GetFirstDigit(int number1)
// {
//     return number1 / 100; 
// }
// int GetSecondDigit(int number)
// {
//     return number %10;
// }
// int random = GetRandomNumber();
// int firstDigit = GetFirstDigit(random);
// int secondDigit = GetSecondDigit(random);

// Console.WriteLine(random);
// Console.WriteLine(firstDigit);
// Console.WriteLine(secondDigit);

// int NewRandom(){
//     int number = new Random().Next(100, 1000);
//     return number;
// }
// int random = NewRandom();
// Console.WriteLine($"число: {random}");
// int RemoveSecondDigit(int random)
// {
//     int firstDigit = random / 100;
//     int thirdDigit = random % 10;
//     int mNumber = firstDigit * 10 + thirdDigit;
//     return mNumber;
// }
// int mNumber = RemoveSecondDigit(random);
// Console.WriteLine($"Новое число: {mNumber}");
