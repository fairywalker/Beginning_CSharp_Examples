
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int index = 0;

        while (index < count)
    {
        Console.WriteLine(col[index]);
        index++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index+1;
            break;
        }
        index++;
}
return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.Write("Position: ");
Console.Write(IndexOf(array, 2));