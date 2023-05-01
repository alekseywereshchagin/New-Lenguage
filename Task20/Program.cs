// Напишите программу, которая принимает на вход координаты двух точек
// и находит растояние между ними в 2D пространстве.


//ИЗВЛЕЧЕНИЕ КОРНЯ

//double d = Math.Sqrt(5);

//double num = 5.099786232;
//double numRound =Math.Round(num, 2, MidpointRounding.ToZero);
//Console.WriteLine(numRound);


//ВОЗВЕДЕНИЕ В СТЕПЕНЬ (число, степень)

//double pw = Math.Pow(5, 2);



Console.WriteLine("Введите координаты точки А");
Console.Write("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, yA, xB, yB);
Console.WriteLine(Math.Round(distance, 2,MidpointRounding.ToZero ));

double Distance(int x1, int y1, int x2, int y2)
{
    int katet1 = x2 - x1;
    int katet2 = y2 - y1;
    double hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
    return hypo;
}

