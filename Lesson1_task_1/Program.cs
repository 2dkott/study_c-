// See https://aka.ms/new-console-template for more information
int number_a;
int number_b;

Console.WriteLine("Inter the first number");
number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inter the second number");
number_b = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b) { Console.WriteLine("number_a: " + number_a + ", number_b: " + number_b + ". Maximum: number_a: " + number_a);}
else if (number_b > number_a) { Console.WriteLine("number_a: " + number_a + ", number_b: " + number_b + ". Maximum: number_b: " + number_b);}
else if (number_b == number_a) { Console.WriteLine("number_a: " + number_a + ", number_b: " + number_b + ". There is no maximum, both numbers are equal");}