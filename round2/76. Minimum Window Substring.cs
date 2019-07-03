public class Solution {
    public string MinWindow(string s, string t) {
        var helperDict = new Dictionary<char, int>();
        int left = 0;
        int count = 0;
        int minLen = int.MaxValue;
        string res = "";
        for (int i=0; i<t.Length; i++) {
            int value = 0;
            if (helperDict.TryGetValue (t[i], out value)) helperDict[t[i]]++;
            else helperDict[t[i]] = 1;           
        }
        for (int i=0; i<s.Length; i++) {
            int value = 0;
            if (helperDict.TryGetValue (s[i], out value)) {
                if (--helperDict[s[i]] >= 0) count++;
            } else helperDict[s[i]] = -1;
            while (count == t.Length) {
                if (minLen > i - left + 1) {
                    minLen = i - left + 1;
                    res = s.Substring(left, minLen);
                }
                if (++helperDict[s[left]] > 0) --count;
                left++;
                
            }
        }
        return res;
    }
}