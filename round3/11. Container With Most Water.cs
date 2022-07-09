public class Solution {
    public int MaxArea(int[] height) {
        int res = 0;
        
        int left = 0, right = height.Length - 1;
        while (left < right) {
            int currCap = Math.Min(height[right], height[left]) * (right - left);
            res = Math.Max(res, currCap);
            if (height[left] < height[right]) ++left;
            else --right;
        }
        
        return res;
    }
}