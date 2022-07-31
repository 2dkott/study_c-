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

int[,] sortDoubleArray(int[,] doubleArray) {
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        int length = doubleArray.GetLength(1)-1;
        int counter = 0;
        while (length != 0) {
            while (counter<length)
            {
                if (doubleArray[i, counter] > doubleArray[i, counter + 1]) {
                    int minValue = doubleArray[i, counter + 1];
                    doubleArray[i, counter + 1] = doubleArray[i, counter];
                    doubleArray[i, counter] = minValue;
                }
                counter++;
            }
            length--;
            counter = 0;
        }
    }
    return doubleArray;
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

int[,] doubleArray = generateDoubleArray(0, 9, 4, 4);
printDoubleArray(doubleArray);
printDoubleArray(sortDoubleArray(doubleArray));