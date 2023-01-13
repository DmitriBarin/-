// Урок 2. Домашнее задание!!! Базовые алгоритмы
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// int secondnum (int N)
// {
//     int a = N/10;
//     int b = a%10;
//     return b;
// }
// Console.WriteLine("Введите трёхзначное число");
// int N = Convert.ToInt32(Console.ReadLine());
// int result = secondnum(N);
// Console.WriteLine(result);
// --//--//--//--//--//--//--//--//--//-//--//--//--//--//--//--//--//--//--//--//--


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
// третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num>=0 && num<=99) Console.WriteLine("необходимо min три цифры");
// if(num>=100 && num<=999)
// {
//     num = num%10;
//     Console.WriteLine(num);
// }
// if(num>=1000 && num<=9999)
// {
//     num = (num%100)/10;
//     Console.WriteLine(num);
// }
// if(num>=10000 && num<=99999)
// {
//     num = (num%1000)/100;
//     Console.WriteLine(num);
// }
// --//--//--//--//--//--//--//--//--//-//--//--//--//--//--//--//--//--//--//--//--


// От Helen Dmitrieva
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
// третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.WriteLine("Введите число:");
// String num = Console.ReadLine();

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// // Функции:
// // Сообщение-

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// // вывод 3 цифры
// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, получи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }
//         result = (a / c) % 10;
//     }
// return result;
// }
// --//--//--//--//--//--//--//--//--//-//--//--//--//--//--//--//--//--//--//--//--

// Мой вариант:
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру обозначающую день недели:");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num == 6) Console.WriteLine("Выходной день!"); 
// if(num == 7) Console.WriteLine("Выходной день!"); 
// if(num>=1 && num<=5) Console.WriteLine("Рабочий день");
// --//--//--//--//--//--//--//--//--//-//--//--//--//--//--//--//--//--//--//--//--


// Вариант от Евгения.
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);
// if (numText.Length >2)
// {
//     Console.WriteLine($"{num} => {numText[2]}");
// }
// else
// {
//     Console.WriteLine($"{num} => третьей цифры нет");
// }


// Урок 3. Базовые алгоритмы. Продолжение
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);
// if (numText[0] == numText[4] && numText[1] == numText[3])
// {
//     Console.WriteLine($"{num} => Yes");
// }
// else
// {
//     Console.WriteLine($"{num} => No");
// }
//--//--//--//--//--//--//--//--//--//--//--//--//--//--//-/-/-/-/-/-/-/-/-/-/-/-/-//-/-/-


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double N(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double k1 = x1 - x2;
//     double k2 = y1 - y2;
//     double k3 = z1 - z2;
//     double g = Math.Round(Math.Sqrt((k1 * k1) + (k2 * k2)+ (k3*k3)), 2);//Math.Round(,2) округляет до 2 цифры
//     //Math.Sqrt() квадратный корень 
//     return g;
// }
// Console.WriteLine("Введите координаты x1");
// double x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты y1");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты z1");
// double z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты x2");
// double x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты y2");
// double y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты z2");
// double z2 = Convert.ToInt32(Console.ReadLine());

// double result = N(x1, y1, z1, x2, y2, z2);
// Console.WriteLine(result);
// //--//--//--//--//--//--//--//--//--//--//--//--//--//--//-/-/-/-/-/-/-/-/-/-/-/-/-//-/-/-

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void N (int number)
{
    for(int i = 1; i<=number; i++)
    Console.WriteLine ($"{i}*{i}*{i}={i*i*i}");
}
Console.WriteLine ("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
N(x);
// //--//--//--//--//--//--//--//--//--//--//--//--//--//--//-/-/-/-/-/-/-/-/-/-/-/-/-//-/-/-