﻿// Напишите программу, которая по заданному нрмеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
int input = Convert.ToInt32(Console.ReadLine());
string range = Range(input);
Console.WriteLine(range);

string Range(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return "ошибка";
}



