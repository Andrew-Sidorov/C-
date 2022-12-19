// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем 
// первый и последний элемент, второй и предпоследний и т.д. Результат запишите 
// в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21

int[] NewArray(int size)

{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        
        //  int N = new Random().Next(1000000);
        // Console.Write($"Число рандома {N} ");
        Console.Write("Введите число массива  ");
        int N = int.Parse(Console.ReadLine());
    
        int A1 = N / 10000; 
        int A2 = N / 1000 % 10;
        int A3 = N / 100 % 10; 
        int A4 = N / 10 % 10;
        int A5 = N % 10;

        int sum1 = A1 * A5;
        int sum2 = A2 * A4;
        int sum3 = A3;
        Console.Write("[");
        Console.Write($"{sum1} , {sum2} , {sum3}");
        Console.Write("]");
    }
    return res;
    
}
int[] array = NewArray(1);
