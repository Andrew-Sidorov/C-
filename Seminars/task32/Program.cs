// Задача 32: Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] NewArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-10,11);
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

Console.Write("[");
PrintArray(array);
Console.Write("]"); 

Console.Write(" --> [");
for(int i = 0; i < array.Length; i++)
{
    
    Console.Write(array[i] * (-1) +" ");
    
} 
Console.Write("]");
