int arraySize = 8;

int[] generateArray(int arraySize){
    Console.WriteLine("Генерация массива...");
    int[] numbers = new int[arraySize];
    for(int i=0; i<arraySize; i++){
        numbers[i]= new Random().Next(1, arraySize);
    }
    Console.WriteLine("Генерация массива закончена");
    return numbers;
}

void printArray(int[] array){
    Console.WriteLine("Печать массива: ");
    for(int i=0; i<array.Length; i++){
        Console.WriteLine(array[i]);
    }
}

int[] numbers = generateArray(8);
printArray(numbers);


