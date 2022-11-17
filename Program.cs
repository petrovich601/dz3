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

// Console.Write("Введите коэффициент b1:");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент k1:");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент b2:");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент k2:");
// int k2 = Convert.ToInt32(Console.ReadLine());
// double x = ((double)(b2 - b1) / (k1 -k2));
// double y = k1 * x + b1;
// Console.Write($"x: {x}, y: {y}");

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m,n];
// Random r = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//       array[i,j] = Math.Round(r.NextDouble() * (10 - (-10)) + (-10),1);
//       Console.Write($"{   array[i,j]}    ");  
//     }
//  Console.WriteLine();   
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите количество строк массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите проверяемый элемент:");
// int x = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,n];
// Random r = new Random();
// string rezalt = "такого числа в массиве нет";
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//       array[i,j] = r.Next(1,99);
//       Console.Write($"{   array[i,j]}    ");
//       if(array[i,j] == x)
//       {
//         rezalt = "имеется в массиве";
//       }
//     }
//  Console.WriteLine();   
// }
// Console.Write($"{ x } {rezalt} ");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите количество строк массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,n];
// Random r = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//       array[i,j] = r.Next(1,9);
//       Console.Write($"{   array[i,j]}      ");
//     }
//  Console.WriteLine();
// }
//  Console.WriteLine("среднее арифметическое");
// double[] sum = new double[n];
// double[] arifm = new double[n];
// for (int k = 0; k < n; k++)
// {
//    for (int l = 0; l < m; l++)
//    {
//     sum[k] = sum[k] + array[l,k];
//     arifm[k] = Math.Round((sum[k] / m),2);
//    }
//     Console.Write($"{ arifm[k]}  ");
// }
 
// Console.Write("Введите количество строк массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,n];
// int[,] array1 = array;
// Random r = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//       array[i,j] = r.Next(1,9);
//       Console.Write($"{   array[i,j]}      ");
//     }
//  Console.WriteLine();
// }
//  Console.WriteLine();
// for (int p = 0; p < m; p++)
// {
//    for (int k = 0; k < n; k++)
//     {
//       array1[0,k] = array[m-1,k];
//       array1[m-1,k] = array[0,k];
//       Console.Write($"{   array1[p,k]}      ");
//     }
// Console.WriteLine();
//     array1[m-1,k] = array[1,k];
// }
// for (int l = 0; l < m; l++)
// {
//     for (int p = 0; p < n; p++)
//     {
//       Console.Write($"{   array1[l,p]}      ");
//     }
//  Console.WriteLine();
// }


//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,n];
// Random r = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//       array[i,j] = r.Next(1,9);
//       Console.Write($"{   array[i,j]}      ");
//     }
//  Console.WriteLine();
// }
//  Console.WriteLine();
// int temp = 0;
// for (int p = 0; p < m; p++)
// {
//    for (int k = 1; k < n; k++)
//     {
//       for (int l = 0; l < n-1; l++)
//       {
//       if (array[p,l] < array[p,l+1])
//       {
//         temp = array[p,l];
//         array[p,l] = array[p,l+1];
//         array[p,l+1] = temp;
//       }
//       }
//     }
// }
// for (int p = 0; p < m; p++)
// {
//    for (int k = 0; k < n; k++)
//     {
//       Console.Write($"{   array[p,k]}      ");
//     }
// Console.WriteLine();
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите размер массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,m];
// Random r = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//       array[i,j] = r.Next(1,9);
//       Console.Write($"{   array[i,j]}      ");
//     }
//  Console.WriteLine();
// }
//  Console.WriteLine();
//  int temp = 0;
//  int nam = 0;
// for (int p = 0; p < m; p++)
// {
//   int sum = 0;
//   for (int k = 0; k < m; k++)
//     {
//       sum += array[p,k];
//     }
//   if (temp < sum)
//    {
//     temp = sum;
//     nam = p;
//    }
// }
// for (int l = 0; l < m; l++)
//     {
//       Console.Write($"{   array[nam,l]}      ");
//     }
//     Console.Write($" Строка №  {   nam}      ");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите размер матриц:");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] array1 = new int[m,m];
// Random r = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//       array1[i,j] = r.Next(1,9);
//       Console.Write($"{   array1[i,j]}      ");
//     }
//  Console.WriteLine();
// }
// Console.WriteLine();
// int[,] array2 = new int[m,m];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//       array2[i,j] = r.Next(1,9);
//       Console.Write($"{   array2[i,j]}      ");
//     }
//  Console.WriteLine();
// }
// Console.WriteLine();
// int[,] array12 = new int[m,m];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//       for (int k = 0; k < m; k++)
//       {
//       array12[i,j] += array1[i,k] * array2[k,j];
//       }
//       Console.Write($"{   array12[i,j]}      ");
//     }
//  Console.WriteLine();
// }


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int m = 2;
// double[,,] array = new double[m,m,m];
// Random r = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//       for (int k = 0; k < m; k++)
//       {
//         array[i,j,k] = new Random().Next(0,100);
//         Console.Write($"{   array[i,j,k]}  ({i},{j},{k})  ");
//       }
//     }
//  Console.WriteLine();   
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Console.Clear();
// int[,] matrix = new int[4,4];
// int temp = 1;
// int i = 0;
// int j = 0;

// void FillMatrix(int[,] matrix)
// {
//     while (temp <= matrix.GetLength(0)*matrix.GetLength(1))
//     {
//         matrix[i,j] = temp;
//         temp++;
//         if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
//         j++;
//         else if (i < j && i + j >= matrix.GetLength(0) - 1)
//         i++;
//         else if (i >= j && i + j > matrix.GetLength(1) - 1)
//         j--;
//         else
//         i--;
//     }
// }

// FillMatrix(matrix);

// for (i = 0; i < matrix.GetLength(0); i++)
// {
//     for ( j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write($"{   matrix[i,j],2}      ");
//     }
//  Console.WriteLine();
// }
// Console.WriteLine();

// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// string RowRecursion(int N)
// {
//     if (N == 1) return $"{N} ";
//     else return $"{N} " + RowRecursion(N - 1);
// }
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(RowRecursion(n));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int SumRec(int n)
// {
//     if (n == m) return m;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(n));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    else return A(m,n);
}
Console.WriteLine(A(m,n));












// string name = "Юрий";
// Console.WriteLine($"Добрый день, {name}");
// Console.WriteLine("Отличная работа. Справились с самым сложным ДЗ");
// Console.WriteLine("ДЗ принимается");
// for (int i=1; i < 4; i++)
// {
// Console.WriteLine("Гип-гип - УРА !");
// }