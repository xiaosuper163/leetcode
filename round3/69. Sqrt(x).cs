public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        
        int left = 0, right = x;
        while (left + 1 < right) {
            int mid = (int) (right - left) / 2 + left;
            if (x / mid == mid) {
                return mid;
            } else if (x / mid < mid) {
                right = mid;
            } else {
                left = mid;
            }
        }
        
        if (right <= x / right) {
            return right;
        } else {
            return left;
        }
    }
}