public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var res = new List<string>();
        if (s.Length <= 10) return res;
        var m = new Dictionary<int, int>();
        int mask = 0x7ffffff;
        int curr = 0;
        for (int i=0; i<9; i++) {
            curr = (curr<<3) | (s[i]&7);
        }
        for (int i=9; i<s.Length; i++) {
            curr = ((curr&mask)<<3) | (s[i]&7);
            if (m.ContainsKey(curr)) {
                if (m[curr] == 1) {
                    res.Add(s.Substring(i-9, 10));
                    m[curr]++;
                }
            } else {
                m[curr] = 1;
            }
        }
        return res;
    }
}