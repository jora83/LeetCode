public class Solution {
    public int[] GetConcatenation(int[] nums) {
    int[] ans = new int[2 * nums.Length];
    int idx = 0;
        
    for(int i = 0; i < ans.Length; i++)
    {
        ans[i] = nums[idx];
        idx++;
        if (idx == nums.Length) idx = 0;
    }

    return ans;
    }
}