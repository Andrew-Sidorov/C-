// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем 
// первый и последний элемент, второй и предпоследний и т.д. Результат запишите 
// в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21
Console.Clear();
int[] NewArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0,124);
    }
    return res;
}
void PrintArray(int[] size)
{

    for (int j = 0; j < size.Length; j++)
    {
        Console.Write(size[j] + " "); 
    }
}
int[] array = NewArray(5);
PrintArray(array);
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


// int N = int.Parse(Console.ReadLine()!);
// int A1 = N / 10000;
// int A2 = N / 1000 % 10;
// int A4 = N / 10 % 10;
// int A5 = N % 10;

// if (A1 == A5 && A2 == A4)
// {
//    Console.Write("Число является палиндромом");
// }
// else
// {
//     Console.Write("Число не является палиндромом");
// }





























// int[] array = NewArray(5);
// PrintArray(array);

// int n = 0;
// int i = 0;
// int j = array.Length - 1;
// int c = 1;
// while (n < array.Length / 2)
// {
//     c = array[i] * array[j];
//     i++;
//     j--;
// }
// Console.WriteLine(c + " ");

