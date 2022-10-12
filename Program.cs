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

Console.Write("Введите число N:");
int nam = Convert.ToInt32(Console.ReadLine());
double rezalt = 0;
for (int i = 1; i <= nam; i++ )
{
    rezalt = Math.Pow (i,3);
    Console.WriteLine(rezalt);
}