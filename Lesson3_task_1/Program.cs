bool checkTest(int inputNumber)
{
    int rightPart = inputNumber%100;
    int revercedRightPart=0;
    int leftPart = inputNumber/1000;
    
    while(rightPart>0){
        int temp = rightPart%10;
        revercedRightPart = revercedRightPart*10+temp;
        rightPart=rightPart/10;
    }
    
    return (leftPart == revercedRightPart);
}

System.Console.WriteLine("Введите число:");

int inputNumber = Convert.ToInt32(Console.ReadLine());
if (inputNumber < 10000) System.Console.WriteLine("Должно быть введено пятизначное число!");
else System.Console.WriteLine("Введенн число это палиндромом: " + checkTest(inputNumber));