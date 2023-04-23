//: Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22


Console.WriteLine("Введите значения A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения C");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > numberA)
{
    max = numberB;
}
if (numberC > numberA)
{
     max = numberC;
}
    Console.WriteLine("Максимальное число:" +max);

