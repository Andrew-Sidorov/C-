// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до M.

void NumberFromMtoN(int m, int n)
{
     if (n > m) NumberFromMtoN(m, n-1);
     Console.Write($"{n} ");
     if (m > n) NumberFromMtoN(m, n+1);
} 
     
    
NumberFromMtoN(10,1);