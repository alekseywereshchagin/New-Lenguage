// Напишите программу, которая принимает на вход координаты точки (X и Y),
// при чем X не равен 0 и Y не равен 0,
// и выдает номер четвертиплоскости, в которой находится эта точка.



Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarte = Quarter(xCoordinate,yCoordinate );
string result = quarte > 0
                ? $"Указанные координаты соответствуют четверти -> {quarte}" 
                : "Введены некорректные координаты";
          Console.Write(result);      

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
