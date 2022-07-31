int[,] generateDoubleArray(int verticalSize, int horizontalSize)
{
    Console.WriteLine("Генерация массива...");
    int elementValue = 1;

    int[,] doubleArray = new int[horizontalSize,verticalSize];

    for (int y = 0; y < verticalSize; y++)
    {
        doubleArray[0,y] = elementValue;
        elementValue++;
    }
    for (int x = 1; x < horizontalSize; x++)
    {
        doubleArray[x,verticalSize - 1] = elementValue;
        elementValue++;
    }
    for (int y = verticalSize - 2; y >= 0; y--)
    {
        doubleArray[horizontalSize - 1,y] = elementValue;
        elementValue++;
    }
    for (int x = horizontalSize - 2; x > 0; x--)
    {
        doubleArray[x,0] = elementValue;
        elementValue++;
    }

    //Периметр заполнен. Продолжаем заполнять массив и задаём
    //координаты ячейки, которую необходимо заполнить следующей.
    int coord_1 = 1;
    int coord_2 = 1;

    while (elementValue < horizontalSize * verticalSize)
    {

        while (doubleArray[coord_1,coord_2 + 1] == 0)
        {
            doubleArray[coord_1,coord_2] = elementValue;
            elementValue++;
            coord_2++;
        }

        while (doubleArray[coord_1 + 1,coord_2] == 0)
        {
            doubleArray[coord_1,coord_2] = elementValue;
            elementValue++;
            coord_1++;
        }

        while (doubleArray[coord_1,coord_2 - 1] == 0)
        {
            doubleArray[coord_1,coord_2] = elementValue;
            elementValue++;
            coord_2--;
        }

        while (doubleArray[coord_1 - 1,coord_2] == 0)
        {
            doubleArray[coord_1,coord_2] = elementValue;
            elementValue++;
            coord_1--;
        }
    }

    for (int x = 0; x < horizontalSize; x++)
    {
        for (int y = 0; y < verticalSize; y++)
        {
            if (doubleArray[x,y] == 0)
            {
                doubleArray[x,y] = elementValue;
            }
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

int[,] doubleArray = generateDoubleArray(5, 5);
printDoubleArray(doubleArray);