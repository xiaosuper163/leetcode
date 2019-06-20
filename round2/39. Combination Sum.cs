public class Solution {
    private void backtrack(List<IList<int>> res, List<int> tempList, int[] nums, int target, int index) {
        if (target < 0) return;
        var tempList_cp = new List<int>(tempList);
        if (target == 0){
            res.Add(tempList_cp);
        } else {
            for (int i=index; i<nums.Length; i++) {
                tempList_cp.Add(nums[i]);
                backtrack(res, tempList_cp, nums, target-nums[i], i);
                tempList_cp.RemoveAt(tempList_cp.Count-1);
            }
        }
    }
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {       
        var res = new List<IList<int>>();
        if (candidates.Length==0) return res;
        Array.Sort(candidates);
        backtrack(res, new List<int>(), candidates, target, 0);
        return res;
    }
}