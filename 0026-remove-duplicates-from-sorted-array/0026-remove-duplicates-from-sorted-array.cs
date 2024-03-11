public class Solution {
    public int RemoveDuplicates(int[] nums) {
    int k = 0;
    HashSet<int> uniqueElements = new HashSet<int>();
    
    foreach (int x in nums)
    {
        if (!uniqueElements.Contains(x))
            uniqueElements.Add(x);
    }

    k = uniqueElements.Count;
    int[] unique = uniqueElements.ToArray();

    for(int i = 0; i<k; i++)
    {
        nums[i] = unique[i];
    }
    
    return k;
    }
}