public class Solution {
    public int ClimbStairs(int n) {
        int prev = 1;
        int curr = 2;
        if (n == 1) return prev;
        if (n == 2) return curr;
        while (n > 2) {
            int temp = prev + curr;
            prev = curr;
            curr = temp;
            n--;
        }
        
        return curr;
    }
}