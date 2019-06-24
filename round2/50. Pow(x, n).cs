public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1.0;
        if (n == 1) return x;
        int half = Math.Abs(n/2);
        double halfRes = MyPow(x, half);
        if (n % 2 == 0) return n>0 ? halfRes*halfRes : 1/(halfRes*halfRes);
        return n>0 ? halfRes*halfRes*x : 1/(halfRes*halfRes*x);
    }
}