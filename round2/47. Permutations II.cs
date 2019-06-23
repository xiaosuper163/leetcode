public class Solution {
    private void DFS(List<IList<int>> res, List<int> candidate, int[] visited, int[] nums, int level, int size) {
        if (level == size) {
            res.Add(new List<int>(candidate));
            return;
        }
        for (int i=0; i<size; i++) {
            if (visited[i] == 1) continue;
            if (i>0 && nums[i]==nums[i-1] && visited[i-1]==1) continue;
            visited[i] = 1;
            candidate.Add(nums[i]);
            DFS(res, candidate, visited, nums, level+1, size);
            candidate.RemoveAt(candidate.Count-1);
            visited[i] = 0;
        }
    }
    public IList<IList<int>> PermuteUnique(int[] nums) {
        int size = nums.Length;
        var res = new List<IList<int>>();
        if (size==0) return res;
        Array.Sort(nums);
        var candidate = new List<int>();
        int[] visited = new int[size];
        DFS(res, candidate, visited, nums, 0, size);
        return res;
    }
}