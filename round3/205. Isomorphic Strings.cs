public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var dicts2t = new Dictionary<char, char>();
        var dictt2s = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i ++) {
            if (dicts2t.ContainsKey(s[i])) {
                if (t[i] != dicts2t[s[i]]) return false;
            } else {
                if (dictt2s.ContainsKey(t[i])) return false;
                dicts2t[s[i]] = t[i];
                dictt2s[t[i]] = s[i];
            }            
        }
        return true;
    }
}