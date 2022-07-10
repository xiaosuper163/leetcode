public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var res = new List<string>();
        
        Helper(n, n, "", res);
        
        return res;
    }
    
    private void Helper(int numLeft, int numRight, string curr, IList<string> res) {
        if (numLeft == 0 && numRight == 0) {
            res.Add(curr);
            return;
        }
        
        if (numLeft > numRight || numLeft < 0 || numRight < 0) return;
        
        Helper(numLeft - 1, numRight, curr + "(", res);
        Helper(numLeft, numRight - 1, curr + ")", res);
    }
}