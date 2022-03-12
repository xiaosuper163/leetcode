public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var res = new int[2];
        
        var dict = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i ++) {
            dict[nums[i]] = i;
        }
        
        for (int i = 0; i < nums.Length; i ++) {
            if (dict.ContainsKey(target - nums[i])) {
                int temp = dict[target-nums[i]];
                if (temp == i) continue;
                res[0] = i;
                res[1] = temp;
                return res;
            }
        }
        
        return res;
    }
}