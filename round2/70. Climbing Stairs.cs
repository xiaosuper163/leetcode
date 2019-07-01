public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        if (n == 2) return 2;
        int prev1 = 1, prev2 = 2, res=0;
        for (int i=2; i<n; i++) {
            res = prev1 + prev2;
            prev1 = prev2;
            prev2 = res;
        }
        return res;
    }
}