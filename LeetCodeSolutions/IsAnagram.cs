public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);
        string sorted_s = new string(sArray);
        string sorted_t = new string(tArray);
        return sorted_s.Equals(sorted_t);
    }
}
