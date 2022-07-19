public class Solution {
    public string MinWindow(string s, string t) {
        var dict = new Dictionary<char, int>();
        
        int cnt = 0, left = 0, minLen = int.MaxValue;
        string res = "";
        
        // dict keeps track of the number of characters to match for each character in t
        // cnt keeps track to the number of characters to match in total
        for (int i = 0; i < t.Length; i ++) {
            if (dict.ContainsKey(t[i])) {
                dict[t[i]]++;
            } else {
                dict[t[i]] = 1;
            }
        }
        
        for (int i = 0; i < s.Length; i ++) {
            if (dict.ContainsKey(s[i])) {
                dict[s[i]] --;
                if (dict[s[i]] >= 0) {
                    cnt ++;
                }
            } else {
                dict[s[i]] = -1;
            }
            
            while (cnt == t.Length) {
                if (i - left + 1 < minLen) {
                    minLen = i - left + 1;
                    res = s.Substring(left, i - left + 1);
                }
                
                if (dict.ContainsKey(s[i])) {
                    dict[s[left]] ++;
                    if (dict[s[left]] > 0) cnt--;
                    left ++;
                }
            }
        }
        
        return res;
    }
}