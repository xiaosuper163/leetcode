// @9 Dynamic Programming

public class Solution {
    public int NumSquares(int n) {
        List<int> helper_list = new List<int>();
        helper_list.Add(0);
        for (int i = 1; i <= n; i++) {
            helper_list.Add(i);
        }
        for (int i = 1; i <= n; i++) {
            int currRes = helper_list[i];
            if (Math.Sqrt(i)%1 == 0) {
                currRes = 1;
                helper_list[i] = currRes;
                continue;
            }
            for (int j = 1; j <= (int) Math.Sqrt(i); j++) {
                currRes = Math.Min(helper_list[i-j*j] + 1, currRes);
            }
            //Console.WriteLine(i+": "+currRes);
            helper_list[i] = currRes;
        }
        return helper_list[n];
    }
}