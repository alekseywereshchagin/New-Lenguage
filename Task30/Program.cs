﻿// Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]






//int[] array = new int[8];

//int[] array0 = new int[] { 3, 6, 8, 8, 7 };
//int[] array01 = new int[11] { 3, 6, 8, 8, 7, 6, 8, 4, 4, 6, 6 };
//int[] array1 = { 1, 4, 7, 8 };

//var array2 = new int[8]; // 0, 1, 2, 3, 4, 5, 6, 7
//array2[5] = 45;
//array2[0] = 4;

//for (int i = 0; i < array2.Length; i++)
//{
//    array2[i] = i * 2;
//    //Console.Write(array2[i] + " ");
//}

//int[] CreateArray
//void FillArray
//void PrintArray


int[] arr = new int[8];

FillArray(arr);
Console.Write("[");
PrintArray(arr); 
Console.Write("]");

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    
}

void FillArray(int[] array)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}










