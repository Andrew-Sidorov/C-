// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] CreateArray(int a, int b, int c)
{
    Console.WriteLine("\nТрёхмерный массив:\n");
    int[,,] matrix = new int[a, b, c];
    int[] checkArray = new int [a * b * c];
    int indexCheckArray = 0;
    int elem = 0;
    for (int depth = 0; depth < matrix.GetLength(2); depth++)
    {
         for (int row = 0; row < matrix.GetLength(0); row++)
         {
             for (int column = 0; column < matrix.GetLength(1); column++)
             {
                while (true)
                {
                    bool check = true;
                    elem = new Random().Next(10, 99);
                     for (int i = 0; i < checkArray.Length; i++)
                     {
                        if (elem == checkArray[i]) check = false;
                     }
                     if (check == true)
                     {
                        matrix[row, column, depth] = elem;
                        Console.Write($"[r{row},c{column},d{depth}]={matrix[row, column, depth]} ");
                        checkArray[indexCheckArray] = elem;
                        indexCheckArray++;
                        break;
                     }
                }
             }
             Console.WriteLine();
         }
         Console.WriteLine("\n");
    }
    return checkArray;
}

void Check(int[]array)
{
    Console.WriteLine($"Проверочная матрица (набор всех использованных элементов): \n");
    Array.Sort(array);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

while (true)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("Введите габариты матрицы r c d (без пробела): ");
    int sizeMatrix = int.Parse(Console.ReadLine());
    int countAllElem = (sizeMatrix / 100) * (sizeMatrix / 10 % 10) * (sizeMatrix % 10);
    if (countAllElem <= 90)
    {
        Check(CreateArray(sizeMatrix / 100, sizeMatrix / 10 % 10, sizeMatrix % 10));
        break;
    }
    else
    {
        Console.WriteLine("максимальное количество непоовторяющихся двухзначных чисел = 90");
        Console.WriteLine($"Нужно {countAllElem} чисел");
        Console.WriteLine($"Создать матрицу невозможно");
        Console.WriteLine($"Нажмите ВВОД и введите другие габариты");
        Console.ReadKey();
    }
}