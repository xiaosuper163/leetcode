public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        int mask = int.MaxValue;
        
        while ((left & mask) != (right & mask)){
            mask <<= 1;
        }
        
        return mask & left;
    }
}