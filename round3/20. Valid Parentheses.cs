public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        
        for (int i = 0; i < s.Length; i ++) {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{') {
                st.Push(s[i]);
            } else {
                if (st.Count == 0) return false;
                char top = st.Pop();
                if (!((s[i] == ')' && top == '(') ||
                    (s[i] == ']' && top == '[') ||
                    (s[i] == '}' && top == '{')
                   )) {
                    return false;
                }
            }
        }
        
        if (st.Count == 0) {
            return true;
        } else {
            return false;
        }
    }
}