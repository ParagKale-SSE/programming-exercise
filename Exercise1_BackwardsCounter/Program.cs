if (args.Length == 2)
{
    int numOne, numTwo;
    bool isFirstArgValid = int.TryParse(args[0], out numOne);
    bool isSecondArgValid = int.TryParse(args[1], out numTwo);

    if (!(isFirstArgValid && isSecondArgValid))
    {
        Console.WriteLine("Invalid input");
        Environment.Exit(1);
    } else
    {
        CheckEdgeCasesForIntegerInputs(numOne, numTwo);
    }
    while(numOne > 0)
    {
        if (numOne % numTwo == 0)
        {
            Console.Write(numOne + "\t");
        }
        numOne--;
    }
}
else
{
    Console.WriteLine("Invalid Arguments");
    Environment.Exit(1);
}

void CheckEdgeCasesForIntegerInputs(int numOne, int numTwo)
{
    if (numOne < 2)
    {
        Console.WriteLine("Invalid input");
        Environment.Exit(1);
    }
    if (numTwo == 0)
    {
        Console.WriteLine("Division by zero error");
        Environment.Exit(1);
    }
    if (numTwo > numOne)
    {
        Console.WriteLine("Invalid input");
        Environment.Exit(1);
    }
    if (numOne % numTwo != 0)
    {
        Console.WriteLine("First number is not evenly divisible by second number");
        Environment.Exit(1);
    }
    if (numOne < 0 || numTwo < 0)
    {
        Console.WriteLine("Invalid input");
        Environment.Exit(1);
    }
    if (numOne >= 1000)
    {
        Console.WriteLine("Out of range");
        Environment.Exit(1);
    }
}