public class Solution {
    public bool IsHappy(int n) {
        var hs = new HashSet<int>();
        hs.Add(n);
        while (true) {
            n = Cal(n);
            if (n == 1) return true;
            else {
                if (hs.Contains(n)) return false;
                else {
                    hs.Add(n);
                }
            }
        }
    }
    
    private int Cal(int n) {
        int res = 0;
        while (n > 0) {
            res += (n % 10) * (n % 10);
            n /= 10;
        }
        
        return res;
    }
}