﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 

void Num(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    if(k1 == k2 && b1 != b2) Console.WriteLine($"Прямые параллельны, точки пересечения нет");
    else if (k1 == k2 && b1 == b2) Console.WriteLine($"Прямые совподают");
    else  Console.WriteLine($"Точка пересечений {x}; {y}");
}
Console.WriteLine(" Введите b1, k1, b2, k2");
double B1 = double.Parse(Console.ReadLine());
double K1 = double.Parse(Console.ReadLine());
double B2 = double.Parse(Console.ReadLine());
double K2 = double.Parse(Console.ReadLine());
Num(B1, K1, B2, K2);