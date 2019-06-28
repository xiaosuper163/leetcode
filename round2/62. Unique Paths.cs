public class Solution {
    public int UniquePaths(int m, int n) {
        long t2 = m-1 + n-1;
        long divisor = 1;
        long dividend = 1;
        long t1 = Math.Min(m-1, n-1);
        Console.WriteLine(string.Format("{0}, {1}", t2, t1));
        while(t1>0) {
            divisor *= (t1--);
            dividend *= (t2--);
        }
        Console.WriteLine(string.Format("{0}, {1}", dividend, divisor));
        return (int) (dividend / divisor);
    }
}