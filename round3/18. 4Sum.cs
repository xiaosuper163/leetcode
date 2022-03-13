public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var res = new List<IList<int>>();
        if (nums.Length < 4) return res;
        
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 3; i ++) {
            if (i > 0 && nums[i] == nums[i-1]) continue;            
            int a = nums[i];
            
            for (int j = i+1; j < nums.Length - 2; j ++) {
                if (j > i+1 && nums[j-1] == nums[j]) continue;
                int b = nums[j];
                
                int left = j + 1;
                int right = nums.Length - 1;
                
                while (left < right) {
                    if (a + b + nums[left] + nums[right] == target) {
                        res.Add(new List<int>(){a, b, nums[left], nums[right]});
                        left ++;
                        right --;
                        while (left < nums.Length && nums[left] == nums[left-1]) left ++;
                        while (right >= 0 && nums[right] == nums[right+1]) right --;
                    } else if (a + b + nums[left] + nums[right] < target) {
                        left ++;
                    } else {
                        right --;
                    }
                }
            }
        }
        
        return res;
    }
}