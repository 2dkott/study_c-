int getNumbersAndPringBelowZero(int size) {
    
    int counter=0;
    
    for (int i = 0; i < size; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number<0) counter++;
    }
    return counter;
}

Console.WriteLine("Кол-во отрицательных чисел: " + getNumbersAndPringBelowZero(5)); 