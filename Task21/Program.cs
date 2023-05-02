// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.



Console.WriteLine("Введите координаты точки А");
Console.Write("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, yA, zA, xB, yB, zB);
Console.WriteLine(Math.Round(distance, 2,MidpointRounding.ToZero ));

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int kat1 = x2 - x1;
    int kat2 = y2 - y1;
    int kat3 = z2 - z1;
    return Math.Sqrt(kat1 * kat1 + kat2 * kat2 + kat3 * kat3);
}


