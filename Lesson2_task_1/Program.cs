int getSeconNumberFrom(int inputNumber)
{
    return (inputNumber % 100) / 10;
}

System.Console.WriteLine("Введите число:");

int inputNumber = Convert.ToInt32(Console.ReadLine());

if (inputNumber < 100 || inputNumber > 999) System.Console.WriteLine("Должно быть введено трехзначное число!");
else System.Console.WriteLine("Второе число: " + getSeconNumberFrom(inputNumber));


