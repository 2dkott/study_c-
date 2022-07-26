int calculateSum(int inputNumber)
{
    int sum=0;
    
    while(inputNumber>0){
        sum = sum + inputNumber%10;
        inputNumber/=10;
        }
    return sum;
}

System.Console.WriteLine("Введите число:");

int inputNumber = Convert.ToInt32(Console.ReadLine());
if (inputNumber <= 0) System.Console.WriteLine("Должно быть введено натуральное число!");
else {System.Console.WriteLine("Суммв чисел: " + calculateSum(inputNumber));}