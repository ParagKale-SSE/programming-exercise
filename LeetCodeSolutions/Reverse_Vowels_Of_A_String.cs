public class Solution {
    public string ReverseVowels(string s) {
        Stack<char> stack = new Stack<char>();
        StringBuilder sb = new StringBuilder();
        foreach(char c in s)
        {
            if (IsVowel(c))
            {
                stack.Push(c);
            }
        }
        for(int i = 0; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
            {
                sb.Append(stack.Pop());
            }
            else
            {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }

    bool IsVowel(char c)
    {
        char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        return vowels.Contains(c);
    }
}
