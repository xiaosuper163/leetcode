public class Solution {
    public string CountAndSay(int n) {
        if (n==1) return "1";
        string prev = CountAndSay(n-1);
        int i = 0;
        string res = "";
        while (i<prev.Length) {
            char currDigit = prev[i];
            int j = 0;
            while (j + i < prev.Length && currDigit == prev[j + i]) j++;
            res += (j.ToString()+currDigit.ToString());
            i += j;
        }
        return res;
    }
}