public class Solution {
    public int CountPrimes(int n) {
        int res = 0;
        var hs = new HashSet<int>();
        for (int i=2; i<n; i++) {
            if (!hs.Contains(i)) {
                res++;
                for (int j=2; j<=n/i; j++) {
                    int tmp = i*j;
                    if (!hs.Contains(tmp)) hs.Add(tmp);
                }
            }
        }
        return res;
    }
}