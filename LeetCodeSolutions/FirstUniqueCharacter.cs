// leet code 387
int FirstUniqChar(string s)
{
    Dictionary<char, int> dict = new Dictionary<char, int>();
    foreach (char c in s)
    {
        if (!dict.ContainsKey(c))
        {
            dict.Add(c, 1);
        }
        else
        {
            dict[c]++;
        }
    }
    var ch = dict.Where(x => x.Value == 1).FirstOrDefault().Key;
    return s.IndexOf(ch);
}