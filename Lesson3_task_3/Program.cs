void generateCubeNumbers(int inputNumber)
{
    int counter=1;
    
    while(counter<=inputNumber){
        System.Console.WriteLine(counter*counter*counter);
        counter+=1;
        }
}

System.Console.WriteLine("Введите число:");

int inputNumber = Convert.ToInt32(Console.ReadLine());
if (inputNumber <= 0) System.Console.WriteLine("Должно быть введено натуральное число!");
else {
    System.Console.WriteLine("Вывод кубичечких чисел:");
    generateCubeNumbers(inputNumber);
}