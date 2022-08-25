﻿// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями: 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите для первой прямой значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите для первой прямой значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите для первой прямой значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите для первой прямой значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны.");            // Первый способ
// else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают.");
// else
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     Console.WriteLine($"Прямые пересекаются в точке: {x}; {y}");
// }

string IntersectionPoint(double argB1, double argK1, double argB2, double argK2)  // Второй способ (с методом)
{
    string res = "";
    double x = (argB2 - argB1) / (argK1 - argK2);
    double y = argK1 * x + argB1;
    res = Convert.ToString($"{x}; {y}");
    return res;
}

if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны.");
else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают.");
else
{
string result = IntersectionPoint(b1, k1, b2, k2);
Console.WriteLine($"Прямые пересекаются в точке: {result}");
}