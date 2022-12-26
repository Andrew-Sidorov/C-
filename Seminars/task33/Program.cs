// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет 
// -3; массив [6, 7, 19, 345, 3] -> да

int[] NewArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1,5);
    }
    return res;
}

void PrintArray(int[] size)
{
   // int count = size.Length;
    for (int j = 0; j < size.Length; j++)
    {
        
        Console.Write(size[j] + " ");
        
    }
}

int[] array = NewArray(4);
Console.Write("Введите любое число: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write(A + " ; массив [");
PrintArray(array);
Console.Write("] -> "); 

int i = 0;
int count = 0;

while (i < array.Length)
{
    if (A == array[i])
    {
        count++;
    }

    i++;
}
if (count == 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("да");
}
