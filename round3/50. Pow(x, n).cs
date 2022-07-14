public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1.0;
        
        double r = MyPow(x, n / 2);
        if (n % 2 == 0) return r * r;
        if (n > 0) return r * r * x;
        return r * r / x;
    }
}