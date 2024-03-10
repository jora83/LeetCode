bool ContainsDuplicate(int[] nums)
{
    HashSet<int> hasValues = new HashSet<int>();

    foreach(int num in nums)
    {
        if (hasValues.Contains(num)) return true;
        hasValues.Add(num);
    }

    return false;
}