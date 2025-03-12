public class Solution {
    public IList<string> FizzBuzz(int n) {
        int i=1;
        List<string> result = new List<string>();
        while(i<=n){
            if (i%3==0 && i%5==0){
                result.Add("FizzBuzz");
            } 
            else if (i%3==0){
                result.Add("Fizz");
            }
            else if (i%5==0){
                result.Add("Buzz");
            }
            else{
                result.Add(i.ToString());
            }
            i++;
        }
        return result;
    }
}
