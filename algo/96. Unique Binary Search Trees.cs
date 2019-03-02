// Dynamic Programming

// F(i, n) = G(i-1) * G(n-i)
// G(n) = sum (F(i, n))

public class Solution {
    public int NumTrees(int n) {
        int[] helper_list = new int[n+1];
        helper_list[0] = 1;
        helper_list[1] = 1;
        for (int i = 2; i < n + 1; i++) {
            int temp = 0;
            for (int j = 1; j <= i; j++) {
                temp += helper_list[j-1] * helper_list[i-j];
            }
            helper_list[i] = temp;
        }
        return helper_list[n];
    }
}