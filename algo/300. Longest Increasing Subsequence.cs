// @9 Dynamic Programming

public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        List<int> helper_list = new List<int>();
        for (int i=0; i<nums.Length; i++) {
            helper_list.Add(1);
        }
        for (int i=0; i<nums.Length; i++) {
            int currRes = 1;
            for (int j=0; j<i; j++) {
                if (nums[j] < nums[i]) {
                    currRes = Math.Max(helper_list[j] + 1, currRes);
                }
            }
            helper_list[i] = currRes;
            //Console.WriteLine(currRes);
        }
        return helper_list.Max();
    }
}