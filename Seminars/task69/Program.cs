// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Degree (int a, int b)
{
    if ( b == 0 ) return 1;
    else return a * Degree(a, b-1);
}
Console.WriteLine("Введите число а: ");
int n = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine("Введите число b: ");
int m = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine(Degree(n, m));
