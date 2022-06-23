int number_a;
int counter=2;

Console.WriteLine("Введите число");
number_a = Convert.ToInt32(Console.ReadLine());

while(counter<=number_a){
    if(counter%2==0){
        Console.WriteLine("Четное число" + counter);
    }
    counter += 2;
}

