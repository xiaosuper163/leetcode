public class Solution {
    public int Calculate(string s) {
        int res = 0, currRes = 0, num = 0;
        char preOperator = '+';
        for (int i=0; i<s.Length; i++) {
            if (s[i] <= '9' && s[i] >= '0') {
                int j=i+1;
                while (j < s.Length && s[j] <= '9' && s[j] >= '0') {
                    j++;
                }
                num = Int32.Parse(s.Substring(i, j-i));
                i = j-1;
            }
            if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/' || i == s.Length - 1) {
                switch(preOperator) {
                    case '+':
                        currRes += num;
                        break;
                    case '-':
                        currRes -= num;
                        break;
                    case '*':
                        currRes *= num;
                        break;
                    case '/':
                        currRes /= num;
                        break;
                }
                if (s[i] == '+' || s[i] == '-' || i == s.Length - 1) {
                    res += currRes;
                    currRes = 0;
                }
                preOperator = s[i];
                num = 0;
            }
        }
        return res;
    }
}