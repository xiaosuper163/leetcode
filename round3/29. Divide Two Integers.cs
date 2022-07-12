public class Solution {
    public int Divide(int dividend, int divisor) {
        
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
        
        int sign = (dividend < 0) ^ (divisor < 0) ? -1 : 1;
        
        long dividend1 = Math.Abs((long) dividend);
        long divisor1 = Math.Abs((long) divisor);
        
        long res = 0;
        
        long toSubstract, toAdd;
        
        while (dividend1 >= divisor1) {
            
            toSubstract = divisor1;
            toAdd = 1;
            
            while (dividend1 > (toSubstract + toSubstract)) {
                
                
                toSubstract += toSubstract;
                toAdd += toAdd;
                
            }
            
            dividend1 -= toSubstract;
            res += toAdd;
            
        }
        
        return sign * (int)res;
        
    }
}