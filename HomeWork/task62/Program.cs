// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] matrix)
{
    Console.WriteLine("Заполненный массив\n");
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
         {
             for (int columns = 0; columns < matrix.GetLength(1); columns++)
             {
                Console.Write($"{matrix[rows, columns]}\t");
             }
             Console.WriteLine("\n");
         }    
         Console.WriteLine();
}

int[,] Spiral(int n)
{
    int[,] array = new int [n, n];
    int count;
    int rows = 0;
    int columns = 0;
    int elem = 1;
    while (n != 0)
    {
       for (count = 0; count < n-1; count++)
       array[rows, columns++] = elem++;

       for (count = 0; count < n-1; count++)
       array[rows++, columns] = elem++;

       for (count = 0; count < n-1; count++)
       array[rows, columns--] = elem++;

       for (count = 0; count < n-1; count++)
       array[rows--, columns] = elem++;

       rows++;
       columns++;

       if (n==1)
       {
        array[rows-1, columns-1] = elem++;
        n--;
       } 
       else n -= 2;
    }
    Console.WriteLine();
    return array;
}

PrintArray(Spiral(4));