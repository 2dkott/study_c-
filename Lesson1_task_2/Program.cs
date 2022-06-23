int number_a;
int number_b;
int number_c;
int max_number;

Console.WriteLine("Inter the first number");
number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inter the second number");
number_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inter the third number");
number_c = Convert.ToInt32(Console.ReadLine());

max_number = number_a;

if (max_number < number_b) {max_number = number_b;}
if (max_number < number_c) {max_number = number_c;}

Console.WriteLine("Maximum number: " + max_number);
