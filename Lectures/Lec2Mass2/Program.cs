int[] array = {91, 26, 23, 14, 14, 25, 66, 57, 82};

int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
