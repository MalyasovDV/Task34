void Output(int[]? array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.WriteLine(array[i]);
}

int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; ++i)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

Random rnd = new Random();
int[] array = new int[8];

for (int i = 0; i < 8; ++i)
    array[i] = rnd.Next(100,999);

Output(array);
Console.WriteLine();
Console.WriteLine(EvenCount(array));

