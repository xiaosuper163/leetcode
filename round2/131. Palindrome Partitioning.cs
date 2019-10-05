public class Solution {
    private bool IsPalindrome(string s) {
        for (int i=0, j=s.Length-1; i<j; i++, j--) {
            if (s[i] != s[j]) return false;
        }
        return true;
    }
    
    private void Helper(string s, List<IList<string>> res, List<string> curr, int index, int size) {
        if (index == size) res.Add(new List<string>(curr));
        for (int i=1; i<=size-index; i++) {
            string tmp = s.Substring(index, i);
            if (IsPalindrome(tmp)) {
                curr.Add(tmp);
                Helper(s, res, curr, index+i, size);
                curr.RemoveAt(curr.Count-1);
            }
        }
    }
    
    public IList<IList<string>> Partition(string s) {
        var res = new List<IList<string>>();
        var curr = new List<string>();
        Helper(s, res, curr, 0, s.Length);
        return res;
    }
}

/*

public class Solution {
    public IList<IList<string>> Partition(string s) {
        var res = new List<IList<string>>();
        DFS(s, new List<string>(), res);
        return res;
    }
    
    private bool IsPalindrome(string s) {
        for (int i=0, j=s.Length-1; i<j; i++, j--) {
            if (s[i] != s[j]) return false;
        }
        return true;
    }
    
    private void DFS(string s, List<string> currRes, List<IList<string>> res) {
        if (s.Length == 0) res.Add(new List<string>(currRes));
        for (int i=0; i<s.Length; i++) {
            if (IsPalindrome(s.Substring(0, i+1))) {
                currRes.Add(s.Substring(0, i+1));
                DFS(s.Substring(i+1), currRes, res);
                currRes.RemoveAt(currRes.Count-1);
            }
        }
    }
}
*/