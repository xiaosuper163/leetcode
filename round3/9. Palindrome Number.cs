public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        
        int b = 1;
        
        while (x / b >= 10) b *= 10;
        
        while (x > 0) {
            int left = x / b;
            int right = x % 10;
            if (left != right) return false;
            x = (x - left * b) / 10;
            b = b / 100;
        }
        
        return true;
    }
}