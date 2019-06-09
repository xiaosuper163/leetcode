public class Solution {
    public int Reverse(int x) {
        int res = 0;
        while (x != 0) {
            if (res > int.MaxValue/10 || (res==int.MaxValue && x%10>7)) return 0;
            if (res < int.MinValue/10 || (res==int.MinValue && x%10<-8)) return 0;
            res = res * 10 + (x % 10);
            x = (int) x / 10;
        }
        return res;
    }
}