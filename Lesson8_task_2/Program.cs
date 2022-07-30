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

int findMinRowPosition(int[,] doubleArray)
{
    int minRow = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            sum=sum + doubleArray[i, j];
        }
        if (sum < minSum) {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
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

int[,] doubleArray = generateDoubleArray(0, 5, 4, 4);
printDoubleArray(doubleArray);
Console.WriteLine("Позиция строки с минимальной суммой элементов: " + findMinRowPosition(doubleArray));