int SumOfUnique(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    int result = 0;
    foreach (int i in nums)
    {
        if (!dict.ContainsKey(i))
        {
            dict.Add(i, 1);
        }
        else
        {
            dict[i]++;
        }
    }
    var items = dict.Where(x => x.Value == 1);
    foreach (var i in items)
    {
        result += i.Key;
    }
    return result;
}