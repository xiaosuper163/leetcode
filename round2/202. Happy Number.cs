public class Solution {
    public bool IsHappy(int n) {
        if (n == 1) return true;
        var hs = new HashSet<int>();
        hs.Add(n);
        int curr = 0;
        while (true) {
            while(n>0) {
                int tmp = n % 10;
                curr += tmp * tmp;
                n = n / 10;
            }
            if (curr == 1) return true;
            if (hs.Contains(curr)) return false;
            hs.Add(curr);
            n = curr;
            curr = 0;
        }
        return false;
    }
}