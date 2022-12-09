// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов 
// чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Clear();
Console.WriteLine("Введите число N   ");
int N = int.Parse(Console.ReadLine()!);
int num = 1;
Console.WriteLine($"Таблица квадратов числа {N}, от 1 до {N}");
while (num < N+1)
{
   int result = num * num;
   Console.Write(result + ",");
   num ++;
}
