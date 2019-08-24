public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;
        var m1 = new Dictionary<char, char>();
        var m2 = new Dictionary<char, char>();
        for (int i=0; i<s.Length; i++) {
            if (m1.ContainsKey(s[i]) && m1[s[i]] != t[i]) {
                return false;
            }
            if (m2.ContainsKey(t[i]) && m2[t[i]] != s[i]) {
                return false;
            }
            if (!m1.ContainsKey(s[i])) {
                m1[s[i]] = t[i];
            }
            if (!m2.ContainsKey(t[i])) {
                m2[t[i]] = s[i];
            }
        }
        return true;
    }
}