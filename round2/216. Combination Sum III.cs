public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var res = new List<IList<int>>();
        if (k==0) return res;
        Helper(0, new List<int>(), res, n, k);
        return res;
    }
    private void Helper(int index, List<int> curr, List<IList<int>> res, int target, int k) {
        if (target == 0 && k == 0) {
            res.Add(new List<int>(curr));
        } else if (k == 0 || target < 0) {
            return;
        }
        for (int i=index+1; i<=9; i++) {
            curr.Add(i);
            Helper(i, curr, res, target-i, k-1);
            curr.RemoveAt(curr.Count-1);
        }
        
    }
}