// Happy Number

bool IsHappy(int n)
{
    var visit = new HashSet<int>();

    while (!visit.Contains(n))
    {
        visit.Add(n);
        n = sumOfSquares(n);
        if (n == 1)
        {
            return true;
        }
    }
    return false;
}

int sumOfSquares(int n)
{
    var output = 0;
    int digit = 0;
    while (n > 0)
    {
        digit = n % 10;
        digit = digit * digit;
        output += digit;
        n = n / 10;
    }
    return output;
}