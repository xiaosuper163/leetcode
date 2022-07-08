public class Solution {
    public int Reverse(int x) {
        int res = 0;
        while (x != 0) {
            if (Math.Abs(res) > int.MaxValue / 10) return 0;
            res = res*10 + x%10;
            x /= 10;
        }
        
        return res;
    }
}