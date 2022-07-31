int sumRecursion(int start, int end)
{
    int next = start + 1;
    if (start == end)
    {
        return end;
    }
    return start + sumRecursion(next, end);
}


int sumValue = sumRecursion(3, 6);
Console.Write(sumValue);
