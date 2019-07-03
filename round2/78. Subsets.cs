public class Solution {
    private void DFS(List<IList<int>> res, List<int> curr, int index, int[] nums) {
        res.Add(new List<int>(curr));
        for (int i=index; i<nums.Length; i++) {
            curr.Add(nums[i]);
            DFS(res, curr, i+1, nums);
            curr.RemoveAt(curr.Count - 1);
        }
    }
    public IList<IList<int>> Subsets(int[] nums) {
        var res = new List<IList<int>>();
        var curr = new List<int>();
        DFS(res, curr, 0, nums);
        return res;
    }
}