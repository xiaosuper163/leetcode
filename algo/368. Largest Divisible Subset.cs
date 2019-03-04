// @9 Dynamic Programming

public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        if (nums.Length == 0) {
            return new List<int>();
        }
        
        Array.Sort(nums);
        List<int> pre = new List<int>();
        List<int> sizes = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            pre.Add(-1);
            sizes.Add(1);
        }
        for (int i = 0; i < nums.Length; i++) {
            int size = sizes[i];
            for (int j = 0; j < i; j ++) {
                if (nums[i] % nums[j] == 0 && size < sizes[j] + 1) {
                    size = sizes[j] + 1;
                    pre[i] = j;
                }
            }
            sizes[i] = size;
        }
        
        int max = sizes.Max();
        int cursor = sizes.IndexOf(max);
        IList<int> res = new List<int>();
        while (cursor != -1) {
            res.Add(nums[cursor]);
            cursor = pre[cursor];
        }
        // There is no need to reverse. If there is, declare it as a List<int> in line 27.
        //res.Reverse();
        return res;
    }
}