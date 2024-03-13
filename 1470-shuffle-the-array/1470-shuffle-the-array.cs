public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] result = new int[nums.Length];
        int current = 0;
        
        for(int i = 0; i < n; i++)
        {
            result[current++] = nums[i];
            result[current++] = nums[i + n];    
        }
    
        return result;
    }
}