// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.



Console.WriteLine("Введите положительное целое число");
int numberN = Convert.ToInt32(Console.ReadLine());

Cube(numberN);

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3} {count  * count * count, 5}");
        count++;
    }
}





