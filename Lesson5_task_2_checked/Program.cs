int arraySize = 4;

int[] generateArray(int min, int max, int arraySize){
    Console.WriteLine("Генерация массива...");
    int[] numbers = new int[arraySize];
    for(int i=0; i<arraySize; i++){
        numbers[i]= new Random().Next(min, max+1);
    }
    Console.WriteLine("Генерация массива закончена");
    return numbers;
}

int getSumOfOddIndex(int[] numbers){
    int sum=0;
    for(int i=0; i<numbers.Length; i++){
        if(i%2==1) sum+=numbers[i];
    }
    return sum;
}

void printArray(int[] array){
    Console.WriteLine("Печать массива: ");
    for(int i=0; i<array.Length; i++){
        Console.WriteLine(array[i]);
    }
}

int[] numbers = generateArray(1, 10, arraySize);
printArray(numbers);
Console.WriteLine("Сумма значение нечетных индексов: " + getSumOfOddIndex(numbers));


