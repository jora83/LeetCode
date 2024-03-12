public class Solution {
    public int RemoveElement(int[] nums, int val) {
    int counter = 0;
    List<int> withoutVal = new List<int>();

    for(int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            withoutVal.Add(nums[i]);
            counter++;
        }
    }

    for(int i = 0; i<withoutVal.Count; i++)
    {
        nums[i] = withoutVal[i];
    }

    return counter;
    }
}