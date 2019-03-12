public class Solution {
    public int TrailingZeroes(int n) {
        int k = (int) Math.Log(n, 5);
        int res = 0;
        for (int i=1; i<=k; i++) {
            res += (int) (n / (Math.Pow(5, i)));
        }
        return res;
    }
}