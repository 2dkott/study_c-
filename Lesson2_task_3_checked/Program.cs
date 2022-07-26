bool checkHoliday(int inputNumber)
{
    return (inputNumber > 5 & inputNumber < 8);
}

System.Console.WriteLine("Введите число:");

int inputNumber = Convert.ToInt32(Console.ReadLine());

if (inputNumber < 1 || inputNumber > 7) System.Console.WriteLine("Должно быть введено число от 1 до 7");
else System.Console.WriteLine("Введенн число это выходной: " + checkHoliday(inputNumber));