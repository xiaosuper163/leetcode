public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var res = new List<IList<int>>();
        Helper(new List<int>(), res, 1, n, k);
        return res;
    }
    
    private void Helper(IList<int> currRes, IList<IList<int>> res, int curr, int n, int k) {
        if (currRes.Count == k) {
            res.Add(new List<int>(currRes));
            return;
        }
        
        if (curr > n) return;
        
        for (int i = curr; i <= n; i ++) {
            currRes.Add(i);
            Helper(currRes, res, i + 1, n, k);
            currRes.RemoveAt(currRes.Count - 1);
        }
    }
}