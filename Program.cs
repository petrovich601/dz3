// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите 5 значное число N:");
// int nam = Convert.ToInt32(Console.ReadLine());
// int nam1 = nam / 10000;
// if (nam1 < 1 | nam1 > 9)
// {
//     Console.WriteLine("Число не 5 значное");
// }
// else
// {
//     int nam2 = ( nam % 10000 ) / 1000;
//     int nam4 = ( nam % 100 ) / 10;
//     int nam5 = nam % 10;
//     if (nam1 == nam5 && nam2 == nam4)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите значение координаты x первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты y первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты z первой точки: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты x второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты y второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты z второй точки: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// int sum = ((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1));
// double distance = Math.Round(Math.Sqrt(sum),2);

// System.Console.WriteLine($"Расстояние между точками = {distance}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N:");
// int nam = Convert.ToInt32(Console.ReadLine());
// double rezalt = 0;
// for (int i = 1; i <= nam; i++ )
// {
//     rezalt = Math.Pow (i,3);
//     Console.WriteLine(rezalt);
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число X:");
// int nam = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Y:");
// int nam1 = Convert.ToInt32(Console.ReadLine());
// int rezalt = nam;
// for (int i = 1; i < nam1; i++)
// {
//     rezalt = rezalt * nam;
// }
// Console.WriteLine(rezalt);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число N:");
// int nam = Convert.ToInt32(Console.ReadLine());
// int rezalt = 0;
// for (int i = 1; nam > 0; i++)
// {
//     rezalt = rezalt + nam % 10;
//     nam = nam / 10;
// }
// Console.WriteLine(rezalt);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// Console.Write( "[ " );
//     for (int i = 0; i < 5; i++)
//     {
//         array[i] = new Random().Next(1,99);
//         Console.Write($"{array[i]}  "); 
//     }
//     Console.WriteLine( "]" );
//     Console.Write( "[ " );
// for (int i = 5; i < 8; i++)
//     {
//         array[i] = new Random().Next(1,99);
//         Console.Write($"{array[i]}  "); 
//     }
//     Console.WriteLine( "]" );

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Введите размер массива N:");
// int size = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//         Console.Write($"{array[i]}  "); 
//         if ((array[i]) % 2 == 0) count ++;
//     }
// Console.WriteLine();
// Console.Write($"Четных чисел:{count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Write("Введите размер массива N:");
// int size = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-9,100);
//         Console.Write($"{array[i]}  "); 
//         if (i % 2 == 0) sum = sum + array[i];
//     }
// Console.WriteLine();
// Console.Write($"Сумма чисел на нечетных позициях:{sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Write("Введите размер массива N:");
// int size = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 0;
// int diff = 0;
// int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,100);
//         Console.Write($"{array[i]}  "); 
//         if (array[i] < min) min = array[i];
//         else if(array[i] > max) max = array[i];
//     }
// diff = max - min;
// Console.WriteLine();
// Console.Write($"Разница min max:{diff}");

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество проверяемых чисел:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите чисело:{i+1}: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// int pos = 0;
// for(int j = 0; j < array.Length; j++)
// {
// if (array[j] > 0) pos = pos + 1;
// }
// Console.Write($"Чисел больше 0:{pos} ");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите коэффициент b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
double x = -99;
double y1 = 0;
double y2 = 0;
while (x < 99)
{
    y1 = k1 * x + b1;
    y2 = k2 * x + b2;
    if ( y1 == y2 )
    {
        Console.Write($"x: {x}, y: {y1}");
    }
    x = x + 0.5;
}