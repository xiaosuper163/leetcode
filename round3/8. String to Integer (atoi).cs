public class Solution {
    public int MyAtoi(string s) {
        int i = 0;
        while (i < s.Length && s[i] == ' ') i++;
        
        int res = 0;
        
        if (i >= s.Length) return res;
        
        int sign = 1;
        if (s[i] == '-') {
            sign = -1;
            i ++;
        } else if (s[i] == '+') {
            i ++;
        }
        
        while(i < s.Length) {
            if (s[i] > '9' || s[i] < '0') return res * sign;
            if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && s[i] - '0' > 7)) {
                return sign == 1 ? int.MaxValue : int.MinValue; 
            }
            res = res * 10 + (s[i] - '0');
            i ++;
        }        
        
        return res * sign;
    }
}