string[] combineArray(string[] stringArray)
{
    if(stringArray.Length % 2 != 0) Console.Write("Длина списка не четная!");
    string[] tempArray = new string[stringArray.Length / 2];
    for (int i = 0; i < stringArray.Length; i+=2)
    {
        tempArray[i/2] = stringArray[i] + stringArray[i + 1];
    }
    return tempArray;
}

void printStringArray(string[] stringArray)
{
    Console.WriteLine("Печать массива: ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        string divider = i < stringArray.Length - 1 ? " ," : "\n";
        Console.Write(stringArray[i] + divider);
    }
}

string[] testArray = new string[] { "qwe", "wer", "ert", "rty", "tyu", "yui" };
printStringArray(combineArray(testArray));