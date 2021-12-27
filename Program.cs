
int[] FillArray()
{
    int[] ArrayA = new int[10];
    for (int i = 0; i < ArrayA.Length; i++)
    {
        ArrayA[i] = new Random().Next(-10, 20);
    }
    return ArrayA;
}

int[] Dev1(int[] ArrayA)
{
    int lenB = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] %2 == 0) lenB++; 
    }
    int[] ArrayB = new int[lenB];
    int j = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] %2==0)
        {
            ArrayB[j] = ArrayA[i];
            j++;
        }
    }
    return (ArrayB); 
}

int[] Dev2(int[] ArrayA)
{
    int lenB = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] > 8) lenB++; 
    }
    int[] ArrayB = new int[lenB];
    int j = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] > 8)
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
    int[] ArrayA = FillArray();
    WriteArray(ArrayA, Dev1(ArrayA));
    WriteArray(ArrayA, Dev2(ArrayA));
}

Task();