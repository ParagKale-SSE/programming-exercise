public class Solution {
    public bool DetectCapitalUse(string word) {
        var firstCh = word[0];
        var subs = word.Substring(1,word.Length-1);
        bool isAllCap = true;
        bool isAllSmall = true;
        bool isSubsAllSmall = true;
        foreach(var ch in word){
            if (!char.IsUpper(ch)){
                isAllCap = false;
            }
            if(char.IsUpper(ch)){
               isAllSmall = false; 
            }
        }
        if (isAllSmall) return true;
        if(isAllCap) return true;
        foreach(var ch in subs){
            if(char.IsUpper(ch)){
               isSubsAllSmall = false; 
            }
        }
        if (char.IsUpper(firstCh) && isSubsAllSmall){
            return true;
        }
        return false;
    }
}
