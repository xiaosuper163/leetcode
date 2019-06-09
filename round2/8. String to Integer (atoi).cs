public class Solution {
    public int MyAtoi(string str) {
        if (str == null || str.Length == 0) return 0;
        
        int startIndex = 0, sign = 1, res = 0;
        while (startIndex < str.Length) {
            if (str[startIndex] != ' ') break;
            startIndex ++;
        }
        if (startIndex==str.Length) return 0;
        
        if (str[startIndex] == '+' || str[startIndex] == '-') {
            sign = str[startIndex] == '+' ? 1 : -1;
            startIndex ++;
        }
        
        while (startIndex < str.Length) {
            int digit = str[startIndex] - '0';
            if (digit < 0 || digit > 9) break;
            if (int.MaxValue/10 < res || (int.MaxValue/10==res && digit >= 8)) {
                return sign==1 ? int.MaxValue : int.MinValue;
            }
            res = res*10 + digit;
            startIndex++;
        }
        
        return sign * res;
    }
}