﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
//наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int GetRandomNumber()
// {
//     int number = new Random().Next(10, 100);
//     Console.WriteLine(number);
//     return number;
// }

// int GetFirstDigit(int number1)
// {
//     // number1 = number1/10;
//     return number1 / 10;
// }

// int num = GetRandomNumber();
// int firstDigit = GetFirstDigit(num);
// Console.WriteLine(firstDigit);

// int GetRandomNumber()
//  {
//      int number = new Random().Next(10, 100);
//      Console.WriteLine(number);
//      return number;
//  }

//  int GetFirstDigit(int number1)
//  {
//           return number1 / 10;
//  }
// void PrintNumber(int num1)
// {
//     Console.WriteLine(num1);
// }

//  int num = GetRandomNumber();
// Console.WriteLine(GetFirstDigit(num));
//  int firstDigit = GetFirstDigit(num);

//  int GetRandomNumber()
//   {
//       int number = new Random().Next(10, 100);
//             return number;
//   }

//   int GetFirstDigit(int number1)
//   {
//            return number1 / 10;
//   }
//  int GetLastDigit(int number1)
//  {
//     return number1 % 10;
//  }

//  void PrintNumber(int num1)
//  {
//      Console.WriteLine(num1);
//  }

//   int num = GetRandomNumber();
//   PrintNumber(num);
//   int firstDigit = GetFirstDigit(num);
//   PrintNumber(firstDigit);
//   int lastDigit = GetLastDigit(num);
//   PrintNumber(lastDigit);

//   int GetRandomNumber()
//    {
//        int number = new Random().Next(10, 100);
//              return number;
//    }

//    int GetFirstDigit(int number1)
//    {
//             return number1 / 10;
//    }
//   int GetLastDigit(int number1)
//   {
//      return number1 % 10;
//   }

//   void PrintNumber(int num1)
//   {
//       Console.Write(num1 + " ");
//   }

// void ShowLargesttDigit(int digit1, int digit2)
// {
//     if (digit1 > digit2)
//     {
//         Console.Write(" -> " + digit1);
//     }
//     else Console.WriteLine(" -> " + digit2);
// }

//    int num = GetRandomNumber();
//    PrintNumber(num);
//    int firstDigit = GetFirstDigit(num);
//    //PrintNumber(firstDigit);
//    int lastDigit = GetLastDigit(num);
//    //PrintNumber(lastDigit);
//    ShowLargesttDigit(firstDigit, lastDigit);

int GetRandomNumber()
   {
       int number = new Random().Next(10, 100);
             return number;
   }

   int GetFirstDigit(int number1)
   {
            return number1 / 10;
   }
  int GetLastDigit(int number1)
  {
     return number1 % 10;
  }

  void PrintNumber(int num1)
  {
      Console.Write(num1 + " ");
  }

void ShowLargesttDigit(int digit1, int digit2)
{
    if (digit1 > digit2)
    {
        Console.Write(" -> " + digit1);
    }
    else Console.WriteLine(" -> " + digit2);
}

   int num = GetRandomNumber();
   PrintNumber(num);
   int firstDigit = GetFirstDigit(num);
   //PrintNumber(firstDigit);
   int lastDigit = GetLastDigit(num);
   //PrintNumber(lastDigit);
   ShowLargesttDigit(firstDigit, lastDigit);

   Console.WriteLine();
   int num2 = GetRandomNumber();
   PrintNumber(num2);
   int firstDigit2 = GetFirstDigit(num2);
   int lastDigit2 = GetLastDigit(num2);
   ShowLargesttDigit(firstDigit2, lastDigit2);
   