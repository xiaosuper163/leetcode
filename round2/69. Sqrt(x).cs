public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        int start = 0, end = x;
        while (start+1<end) {
            int mid = (end-start)/2 + start;
            if (x == mid * mid) return mid;
            else if ((double) (x / mid) / (double) mid > 1) start = mid;
            else end = mid;
            //Console.WriteLine(mid);
        }
        if ((double) (x / end) / (double) end >= 1) return end;
        else return start;
    }
}