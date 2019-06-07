public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        IDictionary<int, int> myMap = new Dictionary<int, int>();
        int index = 0;
        foreach (var num in nums) {
            myMap[num] = index;
            index++;
        }
        int[] res = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            if (myMap.ContainsKey(target-nums[i]) && i != myMap[target - nums[i]]) {
                res[0] = i;
                res[1] = myMap[target - nums[i]];
                return res;
            }
        }
        return res;
    }
}