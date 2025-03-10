// Roman To Integer

int RomanToInt(string s)
{
    Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
    keyValuePairs.Add('I', 1);
    keyValuePairs.Add('V', 5);
    keyValuePairs.Add('X', 10);
    keyValuePairs.Add('L', 50);
    keyValuePairs.Add('C', 100);
    keyValuePairs.Add('D', 500);
    keyValuePairs.Add('M', 1000);

    int res = 0;
    for(int i=0; i < s.Length; i++)
    {
        if (i+1 < s.Length && keyValuePairs[s[i]] < keyValuePairs[s[i+1]])
        {
            res -= keyValuePairs[s[i]];
        }
        else
        {
            res += keyValuePairs[s[i]];
        }
    }
    return res;
}