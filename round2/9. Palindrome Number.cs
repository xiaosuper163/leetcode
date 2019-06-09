public class Solution {
    public int Reverse(int x) {
        int res = 0;
        while (x != 0) {
            res = res * 10 + (x % 10);
            x = (int) x / 10;
        }
        return res;
    }
    public bool IsPalindrome(int x) {
        if (x<0) return false;
        return (Reverse(x) == x);
    }
}