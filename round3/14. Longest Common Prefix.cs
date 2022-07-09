public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1) return strs[0];
        string res = strs[0];
        
        for (int i = 1; i < strs.Length; i ++) {
            res = res.Substring(0, Math.Min(res.Length, strs[i].Length));
            for (int j = 0; j < Math.Min(res.Length, strs[i].Length); j ++) {
                if (res[j] != strs[i][j]) {
                    res = res.Substring(0, j);
                    continue;
                }
            }
            
            if (res.Length == 0) return res;
        }
        
        return res;
    }
}