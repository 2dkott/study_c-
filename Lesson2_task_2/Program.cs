int getThirdNmberFrom(int inputNumber)
{
    return inputNumber % 10;
}

System.Console.WriteLine("Введите число:");

int inputNumber = Convert.ToInt32(Console.ReadLine());

if (inputNumber < 100) System.Console.WriteLine("Должно быть введено трехзначное число или больше!");
else System.Console.WriteLine("Второе число: " + getThirdNmberFrom(inputNumber));