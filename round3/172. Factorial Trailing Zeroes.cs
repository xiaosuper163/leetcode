public class Solution {
    public int TrailingZeroes(int n) {
        int res = 0;
        int bas = 5;
        while (n >= bas) {
            res += n / bas;
            bas *= 5;
        }
        
        return res;
    }
}