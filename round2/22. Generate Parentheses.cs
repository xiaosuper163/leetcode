public class Solution {
    public void BackTrack(IList<string> res, string curr, int open, int close, int max) {
        if (curr.Length == max * 2) {
            res.Add(curr);
            return;
        }       
        if (open < max) BackTrack(res, curr + "(", open+1, close, max);
        if (close < open) BackTrack(res, curr + ")", open, close+1, max);
    }
    
    public IList<string> GenerateParenthesis(int n) {
        IList<string> res = new List<string>();
        BackTrack(res, "", 0, 0, n);
        return res;
    }
}