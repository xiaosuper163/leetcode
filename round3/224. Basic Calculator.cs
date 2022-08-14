public class Solution {
    public int Calculate(string s) {
        var st = new Stack<string>();
        int start, end;
        for (start = 0; start < s.Length;) {
            if (s[start] >= '0' && s[start] <= '9') {
                end = start;
                while (end + 1 < s.Length && s[end + 1] >= '0' && s[end + 1] <= '9') end ++;
                st.Push(s.Substring(start, end - start + 1));
                start = end + 1;
            }
            else if (s[start] == ' ') start ++;
            else if (s[start] == '+' || s[start] == '-' || s[start] == '(') {
                st.Push(s.Substring(start, 1));
                start ++;
            }
            else if (s[start] == ')') {                
                int tmp = 0;
                while (st.Count > 0 && st.Peek() != "(") {
                    string curr = st.Pop();
                    if (st.Count > 0 && st.Peek() == "-") {
                        tmp += (-1) * int.Parse(curr);
                        st.Pop();
                    }
                    else if (st.Count > 0 && st.Peek() == "+") {
                        tmp += int.Parse(curr);
                        st.Pop();
                    }
                    else if (st.Count > 0) { // '(x'
                        tmp += int.Parse(curr);
                    }
                }
                st.Pop();
                st.Push(tmp.ToString());
                start ++;
            }
        }
        
        int res = 0;
        while (st.Count != 0) {
            string curr = st.Pop();
            if (st.Count > 0 && st.Peek() == "-") {
                res += (-1) * int.Parse(curr);
                st.Pop();
            }
            else if (st.Count > 0 && st.Peek() == "+") {
                res += int.Parse(curr);
                st.Pop();
            }
            else {
                res += int.Parse(curr);
            }
            // Console.WriteLine(st.Pop());
        }
        
        return res;
    }
}