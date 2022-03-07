public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        
        var lst = new List<int>();
        
        for (int i = 0; i < nums1.Length; i ++) {
            if (i != 0 && nums1[i] == nums1[i-1]) continue;            
            if (Find(nums2, nums1[i])) {
                lst.Add(nums1[i]);
            }
        }        
        
        return lst.ToArray();
    }
    
    private bool Find(int[] nums, int target) {
        if (nums.Length == 0) return false;
        
        int left = 0, right = nums.Length - 1;
        while (left + 1 < right) {
            int mid = (int)(right - left) / 2 + left;
            if (nums[mid] == target) {
                return true;
            } else if (nums[mid] < target) {
                left = mid;
            } else {
                right = mid; 
            }
        }
        
        if (nums[left] == target || nums[right] == target) return true;
        return false;
    }
}