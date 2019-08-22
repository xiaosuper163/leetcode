public class Solution {
    public uint reverseBits(uint n) {
        uint res = 0;
        int i = 32;
        while (i > 0) {
            res = (res << 1) | (n & 1);
            n = n >> 1;
            i--;
        }
        return res;
    }
}