public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        var dp = new int[nums.Length];      // stores the max length of divisible subset ending at index n (n = 0, 1, ..., nums.Length-1)
        var prev = new int[nums.Length];    // stores the index of previous number
        
        Array.Sort(nums);
        
        int maxLen = 0;
        int index = -1;
        
        for (int i = 0; i < nums.Length; i ++) {
            dp[i] = 1;
            prev[i] = -1;
            for (int j = 0; j < i; j ++) {
                if (nums[i] % nums[j] == 0 && dp[j] + 1 > dp[i]) {
                    prev[i] = j;
                    dp[i] = dp[j] + 1;
                }
            }
            
            if (dp[i] > maxLen) {
                maxLen = dp[i];
                index = i;
            }
            
            //Console.WriteLine($"i:{i};dp[i]:{dp[i]}");
        }
        
        //Console.WriteLine($"maxLen:{maxLen};index:{index}");
        
        var res = new int[maxLen];
        maxLen --;
        while (maxLen >= 0){
            res[maxLen--] = nums[index];
            index = prev[index];
        }
        
        return res;
    }
}