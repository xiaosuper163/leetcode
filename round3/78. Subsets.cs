public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var res = new List<IList<int>>();
        DFSHelper(nums, new List<int>(), res, 0);
        return res;
    }
    
    private void DFSHelper(int[] nums, IList<int> currRes, IList<IList<int>> res, int index) {
        res.Add(new List<int>(currRes));
        
        for (int i = index; i < nums.Length; i ++) {
            currRes.Add(nums[i]);
            DFSHelper(nums, currRes, res, i + 1);
            currRes.RemoveAt(currRes.Count - 1);
        }
    }
}