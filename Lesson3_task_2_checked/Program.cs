using System;

double calcDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xline = x2 - x1;
    double yline = y2 - y1;
    double zline = z2 - z1;
    double temp = xline*xline + yline*yline + zline*zline;
    return Math.Sqrt(temp);
}

System.Console.WriteLine("Введите число:");

double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Дистанция: " + calcDistance(x1, y1, z1, x2, y2, z2));