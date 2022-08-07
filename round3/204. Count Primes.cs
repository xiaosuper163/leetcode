public class Solution {
    public int CountPrimes(int n) {
        int res = 0;
        
        bool[] isPrime = new bool[n];
        
        for (int i = 0; i < n; i ++) isPrime[i] = true;
        
        for (int i = 2; i < n; i ++) {
            if (isPrime[i]) {
                res++;
            } else {
                continue;
            }
            
            if (i > n / i) continue;
            
            for (int j = i * i; j < n; j += i) {
                isPrime[j] = false;
            }
        }
        
        return res;
    }
}