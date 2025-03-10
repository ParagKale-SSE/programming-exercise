// leet code 290

bool WordPattern(string pattern, string s)
{
    Dictionary<char, string> patternDict = new Dictionary<char, string>();
    Dictionary<string, char> strDict = new Dictionary<string, char>();
    StringBuilder sb = new StringBuilder();
    StringBuilder sb1 = new StringBuilder();
    var strArray = s.Split(' ');
    int i = 0, j = 0;
    if (strArray.Length != pattern.Length)
    {
        return false;
    }
    else
    {
        foreach (char c in pattern)
        {
            if (!patternDict.ContainsKey(c))
            {
                patternDict[c] = strArray[i];
            }
            i++;
        }

        foreach (var str in strArray)
        {
            if (!strDict.ContainsKey(str))
            {
                strDict[str] = pattern[j];
            }
            j++;
        }
    }

    foreach (char c in pattern)
    {
        sb.Append(string.Concat(patternDict[c], " "));
    }

    foreach (var str in strArray)
    {
        sb1.Append(strDict[str]);
    }

    return sb.ToString().Trim().Equals(s) && sb1.ToString().Trim().Equals(pattern);
}