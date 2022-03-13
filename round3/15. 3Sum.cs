public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var res = new List<IList<int>>();
        
        if (nums.Length < 3) return res;
        
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i ++) {
            if (i != 0 && nums[i] == nums[i-1]) continue;
            int curr = nums[i];
            
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right) {
                if (nums[left] + nums[right] + curr == 0) {
                    res.Add(new List<int>(){curr, nums[left], nums[right]});
                    left ++;
                    right --;
                    while (left < nums.Length && nums[left] == nums[left - 1]) 
                        left++;
                    while (right >= 0 && nums[right] == nums[right + 1]) 
                        right--;
                } else if (nums[left] + nums[right] < -curr) {
                    left ++;
                } else {
                    right --;
                }
            } 
        }
        
        return res;        
    }
}