// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int[] FillArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 20);
    }
   
    return array;
}

(int[], int[]) Dev1()
{
    int[] ArrayA = FillArray();
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
    return (ArrayA, ArrayB); 
}

(int[], int[]) Dev2()
{
    int[] ArrayA = FillArray();

    int[] ArrayB = new int[0];
    int j = 0;
    for (int i = 0; i < ArrayA1.Length; i++)
    {
        if (ArrayA1[i] > 8)
        {
            int lenght = ArrayB.Length;
            Array.Resize(ref ArrayB, lenght + 1);
            ArrayB[j] = ArrayA1[i];
            j++;
        }
    }
    return (ArrayA1, ArrayB); 
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

//WriteArray(Dev1().Item1, Dev1().Item2);

WriteArray(Dev2().Item1, Dev2().Item2);