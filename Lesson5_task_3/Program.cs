int arraySize = 5;

int[] generateArray(int min, int max, int arraySize){
    Console.WriteLine("Генерация массива...");
    int[] numbers = new int[arraySize];
    for(int i=0; i<arraySize; i++){
        numbers[i]= new Random().Next(min, max+1);
    }
    Console.WriteLine("Генерация массива закончена");
    return numbers;
}

int getDifferenceBetweenMaxAndMin(int[] numbers){
    int min=numbers[0];
    int max=0;
    for(int i=0; i<numbers.Length; i++){
        if(numbers[i]>max) max=numbers[i];
        if(numbers[i]<min) min=numbers[i];
    }
    return max-min;
}

void printArray(int[] array){
    Console.WriteLine("Печать массива: ");
    for(int i=0; i<array.Length; i++){
        Console.WriteLine(array[i]);
    }
}

int[] numbers = generateArray(1, 10, arraySize);
printArray(numbers);
Console.WriteLine("Разница между максимальным и минимальным значений в списке: " + getDifferenceBetweenMaxAndMin(numbers));


