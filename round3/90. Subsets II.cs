public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var res = new List<IList<int>>();
        Array.Sort(nums);
        DFSHelper(nums, 0, new List<int>(), res);
        return res;
    }
    
    private void DFSHelper(int[] nums, int index, IList<int> currRes, IList<IList<int>> res) {
        res.Add(new List<int>(currRes));
        
        for (int i = index; i < nums.Length; i ++) {
            if (i != index && nums[i] == nums[i-1]) continue;
            
            currRes.Add(nums[i]);
            DFSHelper(nums, i + 1, currRes, res);
            currRes.RemoveAt(currRes.Count - 1);
        }
    }
}