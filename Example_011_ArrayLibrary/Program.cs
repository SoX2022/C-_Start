void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;

    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("Random massive [");

    while (position < count - 1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.WriteLine(col[position] + "]");
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

Console.Write("Enter the number you want to find: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, userNumber);

if (pos == -1) Console.WriteLine("There is no number " + userNumber + " there.");
else Console.WriteLine("Your number's index is " + pos);
