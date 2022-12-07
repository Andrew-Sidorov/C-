// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели ");
int n = int.Parse(Console.ReadLine());

if (n == 1)
{
    Console.Write("нет");
}

if (n == 2)
{
    Console.Write("нет");
}

if (n == 3)
{
    Console.Write("нет");
}

if (n == 4)
{
    Console.Write("нет");
}

if (n == 5)
{
    Console.Write("нет");
}

if (n == 6)
{
    Console.Write("Да");
}
if (n == 7)
{
    Console.Write("Да");
}

if (n > 7)
{
    Console.Write("Такого дня недели нет");
}