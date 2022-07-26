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

void printArray(int[,] array){
    Console.WriteLine("Печать массива: ");
    for(int i=0; i<array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string divider = j < array.GetLength(1) - 1 ? " ," : "\n";
            Console.Write(array[i,j] + divider);
        }
    }
}

printArray(generateDoubleArray(-10, 10, 5, 5));