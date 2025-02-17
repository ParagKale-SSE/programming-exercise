try
{
    var numbers = await ReadIntegersFromFileAsync(args[0]);
    // Parallel LINQ expression to process the collection parallely
    var outputNumbers = numbers.AsParallel().AsOrdered().Select(
        item =>
        {
            var output = item * item;
            return Convert.ToString(output);
        });
    // Writing the output collection to output file asynchronously
    await File.WriteAllLinesAsync(args[1], outputNumbers, CancellationToken.None);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Environment.Exit(1);
}


/// <summary>
/// Reads list of integers from an input file asynchronously
/// </summary>
/// <param name="filePath">The input file.</param>
/// <returns>List of integers.</returns>
static async Task<List<int>> ReadIntegersFromFileAsync(string filePath)
{
    var numbers = new List<int>();

    using (var reader = new StreamReader(filePath))
    {
        string? line;
        while ((line = await reader.ReadLineAsync()!) != null)
        {
            if (int.TryParse(line, out int number))
            {
                numbers.Add(number);
            }
        }
    }
    return numbers;
}
