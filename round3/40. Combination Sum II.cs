public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        
        IList<IList<int>> res = new List<IList<int>>();
        DFSHelper(candidates, target, 0, new List<int>(), res);
        return res;
    }
    
    public void DFSHelper(int[] candidates, int target, int index, IList<int> currRes, IList<IList<int>> res) {
        if (target == 0) {
            res.Add(new List<int>(currRes));
            return;
        }
        
        if (target < 0) {
            return;
        }
        
        for (int i=index; i<candidates.Length; i++) {
            if (i != index && candidates[i] == candidates[i-1]) continue;
            
            currRes.Add(candidates[i]);
            DFSHelper(candidates, target-candidates[i], i+1, currRes, res);
            currRes.RemoveAt(currRes.Count-1);
        }
    }
}