public class Solution {
    private bool hasDuplicateCharacter(string s) {
        var set = new HashSet<char>(s.ToCharArray());
        return !(set.Count == s.Length);
    }
    public int LengthOfLongestSubstring(string s) {
        if (s==null || s.Length ==0) return 0;
        string res="";
        for (int i=0; i < s.Length; i++) {
            string cur = s.Substring(i-res.Length, res.Length+1);
            if (!hasDuplicateCharacter(cur)) {
                res = cur;
            }
        }
        return res.Length;
    }
}