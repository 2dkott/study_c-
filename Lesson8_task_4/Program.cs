int[,,] generate3DArray(int min, int max, int ySize, int xSize, int zSise)
{
    Console.WriteLine("Генерация массива...");
    int[,,] tripleArray = new int[ySize, xSize, zSise];
    for (int y = 0; y < ySize; y++)
    {
        for (int x = 0; x < xSize; x++)
        {
            for (int z = 0; z < xSize; z++)
            {
                tripleArray[y, x, z] = new Random().Next(min, max + 1);
                //doubleArray[y, x, z] = new Random().Next(min, max + 1) + " (" + y + "," + x + "," + z + ")";
            }
        }
    }
    return tripleArray;
}

void print3DArray(int[,,] array)
{
    Console.WriteLine("Печать массива: ");
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                string divider = z < array.GetLength(1) - 1 ? " ," : "\n";
                Console.Write(array[y, x, z] + " (" + y + "," + x + "," + z + ")" + divider);
                //doubleArray[y, x, z] = new Random().Next(min, max + 1) + " (" + y + "," + x + "," + z + ")";
            }
        }
    }
}


int[,,] tripleArray = generate3DArray(0, 5, 2, 2, 2);
print3DArray(tripleArray);