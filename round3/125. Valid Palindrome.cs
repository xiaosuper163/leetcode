public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        while (left < right) {
            if (!IsAlphaNumeric(s[left])) {
                left ++;
                continue;
            }
            if (!IsAlphaNumeric(s[right])) {
                right --;
                continue;
            }
            if (Char.ToLower(s[left]) != Char.ToLower(s[right])) return false;
            left ++;
            right --;
        }
        
        return true;
    }
    
    private bool IsAlphaNumeric(char c) {
        if ((c >= '0') && (c <= '9') || ((c >= 'a') && (c <='z')) || ((c >= 'A') && (c <= 'Z'))) return true;
        return false;
    }
}