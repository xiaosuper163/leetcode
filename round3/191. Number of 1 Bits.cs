public class Solution {
    public int HammingWeight(uint n) {
        int res = 0;
        for (int i = 0; i < 32; i ++) {
            res += (int) (n & 1);
            n >>= 1;
        }
        return res;
    }
}