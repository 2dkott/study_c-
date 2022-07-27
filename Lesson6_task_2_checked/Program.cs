bool findCrossPoint(double b1, double k1, double b2, double k2, double range)
{
    Console.WriteLine("Старт вычисления по формуле 'x * (k1 - k2) == b2 - b1' ...");
    for (double i = -range; i <= range; i = Math.Round(i + .1f, 2)) {
        if (i * (k1 - k2) == b2 - b1) {
            double y = calculateYForLine(b1, k1, i);
            Console.WriteLine("Вычисление завершено. Координаты точки пересечения=(" + i + "," + y + ")");
            return true;
        }
    }
    Console.WriteLine("Вычисление завершено. Точка пересечения не найдена!");
    return false;
}

double calculateYForLine(double b, double k, double x) {
    return k * x + b;
}

findCrossPoint(2f, 5f, 4f, 9f, 10f);

