//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0) number  *=-1;

int Digits(int num)
{
    int count =0;
    while (num>0)
    {
        num/=10;
        count++;
    }
    int result=count;
    return result;
}
int digits= Digits(number);
Console.WriteLine($"Количество цифр в числе{number} равно {digits}");



//            2 Вариант


//Console.WriteLine("Введите целое число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int count = CountNumbers(number);

//Console.WriteLine($"Кол-во цифр в числе {number} =  {count}");


//int CountNumbers (int num)
//{
//    int i = 0;
//   while (num != 0) 
//   {
//       num = num / 10;
//       i++;
//   }
//   return i;
//}




