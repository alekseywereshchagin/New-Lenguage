﻿// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.


int Prompt(string msg)
{

Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите трехзначное число");
if (number >=100 && number <1000)
{
int num = (number % 100 - number % 10) / 10;
Console.WriteLine($"Вторая цифра числа {number} является {num}");
}
else
Console.WriteLine("Это число не трехзначное");
