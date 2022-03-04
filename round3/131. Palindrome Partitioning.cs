public class Solution {
    public IList<IList<string>> Partition(string s) {
        var res = new List<IList<string>>();
        DFSHelper(s, 0, new List<string>(), res);
        return res;
    }
    
    private void DFSHelper(string s, int index, IList<string> currRes, IList<IList<string>> res) {
        if (index == s.Length) {
            res.Add(new List<string>(currRes));
            return;
        }
        
        for (int i=index+1; i<=s.Length; i++) {
            if (!IsPalindrome(s.Substring(index, i-index))) {
                continue;
            }
            currRes.Add(s.Substring(index, i-index));
            DFSHelper(s, i, currRes, res);
            currRes.RemoveAt(currRes.Count-1);
        }
    }
    
    private bool IsPalindrome(string s) {
        for (int i=0, j=s.Length-1; i<=j; i++, j--) {
            if (s[i] != s[j]) {
                return false;
            }
        }
        return true;
    }
}