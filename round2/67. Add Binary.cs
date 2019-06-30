public class Solution {
    public string AddBinary(string a, string b) {
        int carry = 0;
        int m = a.Length - 1, n = b.Length - 1;
        string res = "";
        int sum = 0;
        while (m >= 0 || n >= 0) {
            if (m>=0 && n>=0) sum = (a[m]-'0') + (b[n]-'0') + carry;
            else if (m >= 0) sum = (a[m]-'0') + carry;
            else if (n >= 0) sum = (b[n]-'0') + carry;
            carry = sum / 2;
            res = res.Insert(0, (sum%2).ToString());
            m--;
            n--;
        }
        if (carry == 1) res = res.Insert(0, "1");
        return res;
    }
}