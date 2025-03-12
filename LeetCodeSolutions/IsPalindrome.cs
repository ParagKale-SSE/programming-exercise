public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLower(c));
            }
        }

        string result = sb.ToString();
        int i = 0;
        int j = result.Length - 1;
        while(i<=j){
            if (result[i] != result[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
