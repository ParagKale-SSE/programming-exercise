// intersection of 2 arrays
int[] Intersection(int[] nums1, int[] nums2)
{
    List<int> result = new List<int>();
    foreach (int i in nums1)
    {
        if (nums2.Where(x => x == i).Any())
        {
            result.Add(i);
        }
    }
    return result.Distinct().ToArray();
}