//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateNormalMatrix(int a, int b)
{
int[,] matrix = new int[a, b];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
for (int columns = 0; columns < matrix.GetLength(1); columns++)
{
matrix[rows, columns] = new Random().Next(1,10);
Console.Write($"{matrix[rows, columns]} ");
}
Console.WriteLine("");
}
Console.WriteLine("");
return matrix;
}

void CreateSpecArray(int [,] array)
{
for (int rows = 0; rows < array.GetLength(0); rows++)
{
for (int columns = 0; columns < array.GetLength(1); columns++)
{
array[rows, columns] = rows + columns;
Console.Write($"{array[rows, columns]} ");
}
Console.WriteLine("");
}
}
CreateSpecArray(CreateNormalMatrix(3,4));