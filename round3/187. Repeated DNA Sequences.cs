public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var res = new List<string>();
        if (s.Length <= 10) return res;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int mask = 0x7ffffff;
        int curr = 0;
        for (int i = 0; i < 9; i ++) {
            curr = (curr << 3) | (s[i] & 0x7);
        }
        
        for (int i = 9; i < s.Length; i ++) {
            curr = ((curr & mask) << 3) | (s[i] & 0x7);
            if (dict.ContainsKey(curr)) {
                if (dict[curr] == 1) {
                   res.Add(s.Substring(i - 9, 10)); 
                }
                dict[curr] ++;
            } else {
                dict[curr] = 1;
            }
        }
        
        return res;
    }
}