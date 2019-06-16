public class Solution {
    public int Divide(int dividend, int divisor) {
        bool isNegative = (dividend < 0) != (divisor < 0);
        long absDividend = Math.Abs((long) dividend);
        long absDivisor = Math.Abs((long) divisor);
        long res = 0;
        long left = absDividend;
        long toSubstract = absDivisor;
        long toAdd = 1;
        while (left >= toSubstract) {
            left -= toSubstract;
            res += toAdd;
            toSubstract += toSubstract;
            toAdd += toAdd;
             
            if (left < toSubstract) {
                while (left >= absDivisor) {
                    res += 1;
                    left -= absDivisor;
                }
            }
        }
        if (isNegative) {
            return (int) Math.Max(-res, (long) int.MinValue);
        } else {
            return (int) Math.Min(res, (long) int.MaxValue);
        }
    }
}