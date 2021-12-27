// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

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
    int[] ArrayB = new int[0];
    int j = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] %2==0)
        {
            int lenght = ArrayB.Length;
            Array.Resize(ref ArrayB, lenght + 1);
            ArrayB[j] = ArrayA[i];
            j++;
        }
    }
    return (ArrayB); 
}

int[] Dev2(int[] ArrayA)
{
    int[] ArrayB = new int[0];
    int j = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] > 8)
        {
            int lenght = ArrayB.Length;
            Array.Resize(ref ArrayB, lenght + 1);
            ArrayB[j] = ArrayA[i];
            j++;
        }
    }
    return (ArrayB); 
}

void WriteArray(int[] ArrayA, int[] ArrayB)
{
    DateTime saveTime;
    saveTime = DateTime.Now;
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
    Console.WriteLine("]");
    Console.WriteLine($"Прошло: {DateTime.Now - saveTime} \n");
}

void Task()
{
    int[] ArrayA = FillArray();
    WriteArray(ArrayA, Dev1(ArrayA));
    WriteArray(ArrayA, Dev2(ArrayA));
}

Task();