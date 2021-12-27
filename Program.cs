
int[] FillArray(int lenA, int minRan, int maxRan)
{
    int[] ArrayA = new int[lenA];
    for (int i = 0; i < ArrayA.Length; i++)
    {
        ArrayA[i] = new Random().Next(minRan, maxRan);
    }
    return ArrayA; 
}

int[] Dev1(int[] ArrayA)
{
    int lenB = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] %2 == 0 && ArrayA[i] != 0) lenB++; 
    }
    int[] ArrayB = new int[lenB];
    int j = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] %2 == 0 && ArrayA[i] != 0)
        {
            ArrayB[j] = ArrayA[i];
            j++;
        }
    }
    return (ArrayB); 
}

void WriteArray(int[] ArrayA, int[] ArrayB)
{
    Console.Write("[");
    for (int i = 0; i < ArrayA.Length; i++)
    {
        Console.Write(ArrayA[i]);
        if (i != ArrayA.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < ArrayB.Length; i++)
    {
        Console.Write(ArrayB[i]);
        if (i != ArrayB.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]\n");
}

void Task()
{
    int[] ArrayA = FillArray(15, -5, 15);
    WriteArray(ArrayA, Dev1(ArrayA));
}

Task();