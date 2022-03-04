public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> res = new List<IList<int>>();
        DFSHelper(candidates, target, 0, new List<int>(), res);
        return res;
    }
    
    public void DFSHelper(int[] candidates, int target, int index, List<int> currRes, IList<IList<int>> res) {
        // exit
        if (target == 0) {
            res.Add(new List<int>(currRes));
            return;
        }
        if (target < 0) {
            return;
        }
        
        for (int i=index; i<candidates.Length; i++) {
            currRes.Add(candidates[i]);
            DFSHelper(candidates, target-candidates[i], i, currRes, res);
            currRes.RemoveAt(currRes.Count-1);
        }
    }
}