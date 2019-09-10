public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var m = new int[26];
        for (int i=0; i<s.Length; i++) {
            m[s[i]-'a']++;
        }
        for (int i=0; i<t.Length; i++) {
            if (--m[t[i]-'a'] < 0) return false;
        }
        return true;
    }
}