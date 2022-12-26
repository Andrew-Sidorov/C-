// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого 
// элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 
// 7 -столбец)

int[,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}
void Position(int[,] array, int position)
{
    if (position%10 > array.GetLength(1) || position/10 > array.GetLength(0))
    Console.WriteLine($"\nЧисла с позицией ({position/10}*{position%10}) в массиве нет");
    else Console.WriteLine($"\nЧисла с позицией ({position/10}*{position%10}) = {array[position/10 - 1, position%10 - 1]}");
}

Console.WriteLine("Введите размер массива M * N:  ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию массива X * Y"  );
int i = int.Parse(Console.ReadLine());
Console.WriteLine();
Position(CreateArray(size/10, size%10), i);
Console.WriteLine();