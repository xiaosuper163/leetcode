public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        
        int[] cnt = new int[26];
        for (int i = 0; i < s.Length; i ++) {
            cnt[s[i] - 'a'] ++;
        }
        for (int i = 0; i < t.Length; i ++) {
            if (-- cnt[t[i] - 'a'] < 0) return false;
        }
        
        return true;
    }
}