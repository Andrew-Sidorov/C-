// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми 
// числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue); //result[0,0] = 34;
        }
 
   }
   return result;
}

void PrintArrey(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Vvedite kolichestvo strok massiva ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Vvedite kolichestvo stolbcov massiva ");
int columns = int.Parse(Console.ReadLine());


int[,] array = GetArray(rows,columns,0,10);
PrintArrey(array); 