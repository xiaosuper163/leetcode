public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        var hs = new HashSet<string>(wordDict);
        
        var dict = new Dictionary<int, IList<int>>();
        
        for (int i = 1; i <= s.Length; i ++) {
            dict[i] = new List<int>();
            for (int j = 0; j < i; j ++) {
                if ((j == 0 || dict[j].Count > 0) && hs.Contains(s.Substring(j, i-j))) {
                    dict[i].Add(j);
                }
            }
        }
        
        // for (int i = 1; i < s.Length; i ++) {
        //     Console.WriteLine($"key {i}:");
        //     Console.WriteLine(String.Join('-', dict[i]));
        // }
        
        var res = new List<string>();
        DFSHelper(s, dict, res, "", s.Length);
        return res;
    }
    
    private void DFSHelper(string s, Dictionary<int, IList<int>> dict, IList<string> res, string currRes, int index) {
        if (index == 0) {
            res.Add(currRes);
            return;
        }
        
        foreach (int next in dict[index]) {
            string currStr = s.Substring(next, index - next) + (index == s.Length ? currRes : " " + currRes);
            DFSHelper(s, dict, res, currStr, next);
        }
    }
}