int calcFactorial(int numberOfFactorial) {
    return multiplicationRecursion(1, numberOfFactorial);
}

int multiplicationRecursion(int start, int end)
{
    int next = start + 1;
    if (start == end)
    {
        return end;
    }
    return start * multiplicationRecursion(next, end);
}


int factorialValue = calcFactorial(6);
Console.Write(factorialValue);
