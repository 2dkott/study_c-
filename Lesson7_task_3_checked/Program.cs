int[,] generateDoubleArray(int min, int max, int verticalSize, int horizontalSize)
{
    Console.WriteLine("Генерация массива...");
    int[,] doubleArray = new int[verticalSize, horizontalSize];
    for (int i = 0; i < verticalSize; i++)
    {
        for (int j = 0; j < horizontalSize; j++)
        {
            doubleArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return doubleArray;
}

float[] getArithmeticMeanArray(int[,] doubleArray) {
    
    float [] array = new float[doubleArray.GetLength(1)];

    for (int i = 0; i < doubleArray.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < doubleArray.GetLength(0); j++)
        {
            sum = sum + doubleArray[j, i];
        }
        array[i] = (float)sum / (float)doubleArray.GetLength(1);
    }
    return array;
}

void printDoubleArray(int[,] array)
{
    Console.WriteLine("Печать массива: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string divider = j < array.GetLength(1) - 1 ? " ," : "\n";
            Console.Write(array[i, j] + divider);
        }
    }
}

void printArray(float[] array)
{
    Console.WriteLine("Печать массива c среднее арифметическими значениями: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int[,] doubleArray = generateDoubleArray(0, 10, 3, 4);
printDoubleArray(doubleArray);
float[] array = getArithmeticMeanArray(doubleArray);
printArray(array);
