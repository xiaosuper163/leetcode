public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 0) return true;
        if (s.Length == 1) return false;
        Stack<char> helperStack = new Stack<char>();
        for (int i=0; i<s.Length; i++) {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[' ) {
                helperStack.Push(s[i]);
            } else if (helperStack.Count == 0) {
                return false;
            } else {
                char temp = helperStack.Pop();
                if (!((temp == '(' && s[i] == ')') || (temp == '[' && s[i] == ']') || (temp == '{' && s[i] == '}'))) return false;
            }
        }
        if (helperStack.Count == 0) {
            return true;
        } else {
            return false;
        }
    }
}