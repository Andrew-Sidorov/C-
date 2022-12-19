// Задача 28: Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел = {GetSumNums(a)}");


int GetSumNums(int number)
{
int sum = 1;
while (number > 0)
{
//Console.Write($"{number} ");
sum *= number;
number--;
}
return sum;
}