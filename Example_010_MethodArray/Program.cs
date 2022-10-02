int[] array = { 1, 4, 3, 4, 5, 6, 7, 8, 9 };

int lenght = array.Length;
int find = 10;
int index = 0;

while (index < lenght)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


