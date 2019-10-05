public class Solution {
    private void BackTrack(int[] nums, List<IList<int>> res, List<int> tempList, int remain, int index) {
        if (remain == 0) res.Add(new List<int>(tempList));
        if (remain < 0) return;
        for (int i=index; i<nums.Length; i++) {
            if (i != index && nums[i] == nums[i-1]) continue;
            tempList.Add(nums[i]);
            BackTrack(nums, res, tempList, remain-nums[i], i+1);
            tempList.RemoveAt(tempList.Count-1);
        }
    }
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var res = new List<IList<int>>();
        var tempList = new List<int>();
        BackTrack(candidates, res, tempList, target, 0);
        return res;
    }
}