public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var res = new List<IList<int>>();
        DFSHelper(new List<int>(), res, 0, 0, k, n);
        return res;
    }
    
    private void DFSHelper(IList<int> currRes, IList<IList<int>> res, int index, int min, int k, int target) {
        if (index == k && target == 0) {
            res.Add(new List<int>(currRes));
            return;
        }
        if (index == k) return;
        for (int i = min + 1; i <= 9; i ++) {
            currRes.Add(i);
            DFSHelper(currRes, res, index + 1, i, k, target - i);
            currRes.RemoveAt(currRes.Count - 1);
        }        
    }
}