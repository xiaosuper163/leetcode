// public class Solution {
//     public int Jump(int[] nums) {
//         int[] dp = new int[nums.Length];
        
//         dp[nums.Length - 1] = 0;
        
//         for (int i = nums.Length - 2; i >= 0; i --) {
//             dp[i] = nums.Length;
//             for (int j = i + 1; j < nums.Length && j <= i + nums[i]; j ++) {
//                 dp[i] = Math.Min(dp[j] + 1, dp[i]);
//             }
//         }
        
//         return dp[0];
//     }
// }


public class Solution {
    public int Jump(int[] nums) {
        int currEndBeforeNextJump = 0, currMaxAfterNextJump = 0, numJumps = 0;
        
        for (int i = 0; i < nums.Length - 1; i ++) {
            currMaxAfterNextJump = Math.Max(currMaxAfterNextJump, nums[i] + i);
            
            if (i == currEndBeforeNextJump) {
                numJumps ++;
                currEndBeforeNextJump = currMaxAfterNextJump;
            }
        }
        
        return numJumps;
    }
}