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

int[,] multilplyArrays(int[,] doubleArray1, int[,] doubleArray2) {
    if (doubleArray1.GetLength(0) != doubleArray2.GetLength(0)) { 
    }
    if (doubleArray1.GetLength(1) != doubleArray2.GetLength(1))
    {
    }
    int[,] finalArray = new int[doubleArray1.GetLength(0), doubleArray1.GetLength(1)];
    for (int i = 0; i < doubleArray1.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray1.GetLength(1); j++)
        {
            finalArray[i, j] = doubleArray1[i, j] * doubleArray2[i, j];
        }
    }
    return finalArray;

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

int[,] doubleArray1 = generateDoubleArray(0, 5, 4, 4);
printDoubleArray(doubleArray1);
int[,] doubleArray2 = generateDoubleArray(0, 5, 4, 4);
printDoubleArray(doubleArray2);
printDoubleArray(multilplyArrays(doubleArray1, doubleArray2));
