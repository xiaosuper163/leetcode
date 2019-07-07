public class Solution {
    private bool IsValid(string s) {
        if (s[0] == '0' && s.Length==1) return true;
        else if (s[0] == '0') return false;
        return Int32.Parse(s) <= 255;
    }
    private void Helper(string s, List<string> res, string curr, int k, int index) {
        if (k == 0 && index == s.Length) {
            res.Add(curr);
            return;
        }
        for (int i = 1; i < 4; i ++) {
            if (index+i <= s.Length && IsValid(s.Substring(index, i))) {
                if (curr.Length == 0) Helper(s, res, curr+s.Substring(index,i), k-1, index+i); 
                else Helper(s, res, curr+"."+s.Substring(index,i), k-1, index+i);
            }   
        }
    }
    public IList<string> RestoreIpAddresses(string s) {
        var res = new List<string>();
        if (s.Length > 12) return res;
        Helper(s, res, "", 4, 0);
        return res;
    }
}