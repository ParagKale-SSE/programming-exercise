// Leet Code Missing Number

int MissingNumber(int[] nums)
{
    int result = 0;
    int i = 0;
    while (i <= nums.Length)
    {
        if (!nums.Where(x => x == i).Any())
        {
            result = i;
            break;
        }
        i++;
    }
    return result;
}