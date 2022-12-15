// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int n = 8;
int[] arr = new int [n];
Random rand = new Random();
int[] GetNewArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0,2);
        Console.Write(arr[i] +" ");
    }
    return arr;
}
GetNewArr(arr);