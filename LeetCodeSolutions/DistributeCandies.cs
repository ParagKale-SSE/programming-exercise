public class Solution {
    public int DistributeCandies(int[] candyType) {
        var candySet = new HashSet<int>();
    for (int i = 0; i < candyType.Length; i++)
    {
        candySet.Add(candyType[i]);
    }
    return Math.Min(candyType.Length/2, candySet.Count );
    }
}
