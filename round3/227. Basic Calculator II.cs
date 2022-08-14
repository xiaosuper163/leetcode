public class Solution {
    public int Calculate(string s) {
        var st = new Stack<string>();
        int start = 0, end;
        while (start < s.Length) {
            if (s[start] >= '0' && s[start] <= '9') {
                end = start;
                while (end + 1 < s.Length && s[end + 1] >= '0' && s[end + 1] <= '9') {
                    end ++;
                }
                st.Push(s.Substring(start, end - start + 1));
                start = end;
            } else if (s[start] == '-' || s[start] == '+') {
                st.Push(s.Substring(start, 1));
            } else if (s[start] == '*' || s[start] == '/') {
                int prevNum = int.Parse(st.Pop());
                char oper = s[start];
                start ++;
                end = start;
                while (end + 1 < s.Length && s[end + 1] >= '0' && s[end + 1] <= '9') {
                    end ++;
                }
                int currNum = int.Parse(s.Substring(start, end - start + 1));
                int tmp = oper == '/' ? prevNum / currNum : prevNum * currNum;
                st.Push(tmp.ToString());
                start = end;
            }            
            
            start ++;
        }
        
        int res = 0;
        while (st.Count != 0) {
            int currNum = int.Parse(st.Pop());
            if (st.Count > 0) {
                string oper = st.Pop();
                if (oper == "+") res += currNum;
                else res -= currNum;
            } else {
                res += currNum;
            }
        }
        return res;
    }
}