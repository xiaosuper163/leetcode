public class Solution {
    public int Calculate(string s) {
        return Helper(s, 0).Item1;
    }
    public Tuple<int, int> Helper(string s, int start) {
        if (start >= s.Length) return new Tuple<int, int>(0, start);
        int res = 0;
        int i = start;
        bool isAdd = true;
        while (i<s.Length) {
            if (s[i] == ')') return new Tuple<int,int>(res, i);
            else if (s[i] == '(') {
                var t = Helper(s, i+1);
                i = t.Item2;
                res += (isAdd ? 1 : (-1)) * t.Item1;
            }
            else if (s[i] <= '9' && s[i] >= '0') {
                int tmp = i;
                while (i+1 < s.Length && s[i+1] <= '9' && s[i+1] >= '0') {
                    i++;
                }
                res += (isAdd ? 1 : (-1)) * Int32.Parse(s.Substring(tmp, i+1-tmp));
            }
            else if (s[i] == '+') {
                isAdd = true;
            }
            else if (s[i] == '-') {
                isAdd = false;
            }
            i++;
        }
        return new Tuple<int, int>(res, i);
    }
}