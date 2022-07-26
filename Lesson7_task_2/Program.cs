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

void printArray(int[,] array)
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

void printDoubleArrayElementValue(int verticalPosition, int horizontalPosition, int[,] doubleArray) {
    if (verticalPosition < 0 || horizontalPosition < 0)
    {
        Console.WriteLine("Заданы отрицательные позиции элемента!");
        return;
    }
    if (verticalPosition > doubleArray.GetLength(0) - 1 || horizontalPosition > doubleArray.GetLength(0) - 1)
    {
        Console.WriteLine("Позиция элемента не верна!");
        return;
    }
    Console.WriteLine("Значение элемента: " + doubleArray[verticalPosition, horizontalPosition]);
}

int[,] doubleArray = generateDoubleArray(-10, 10, 5, 5);
printArray(doubleArray);
printDoubleArrayElementValue(4, -4, doubleArray);
