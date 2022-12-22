// Задача 42: Напишите программу, которая будет преобразовывать десятичное 
// число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// N = 2**i

// 45%2 = 22 -> 1
// 22%2 = 11 -> 0
// 11%2 = 5 -> 1
// 5%2 = 2 -> 1
// 2%2 = 1 -> 0
// 1%2 = 0 -> 1

Console.WriteLine("Vvedite chislo: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Chislo {num} konvertirovali v dvoichnoe");

string numDouble = " ";
string numDoubleRev = " ";
while(true)
{  
    int res = num % 2;
    numDouble = res + numDouble;
    num/=2;
    if(num == 0) break;
    
}
Console.Write(numDouble);