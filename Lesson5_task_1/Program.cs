int arraySize = 8;

int[] generateArray(int min, int max, int arraySize){
    Console.WriteLine("Генерация массива...");
    int[] numbers = new int[arraySize];
    for(int i=0; i<arraySize; i++){
        numbers[i]= new Random().Next(min, max+1);
    }
    Console.WriteLine("Генерация массива закончена");
    return numbers;
}

int getEvenNummberCount(int[] numbers){
    int count=0;
    for(int i=0; i<numbers.Length; i++){
        if(numbers[i]%2==0) count+=1;
    }
    return count;
}

void printArray(int[] array){
    Console.WriteLine("Печать массива: ");
    for(int i=0; i<array.Length; i++){
        Console.WriteLine(array[i]);
    }
}

int[] numbers = generateArray(100, 999, arraySize);
printArray(numbers);
Console.WriteLine("Четных чисел: " + getEvenNummberCount(numbers));


