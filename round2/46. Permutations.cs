public class Solution {
    public void DFS(List<IList<int>> res, List<int> candidate, int[] nums, int[] visited, int level, int size) {
        if (candidate.Count == size) {
            res.Add(new List<int>(candidate));
            return;
        }
        for (int i=0; i<size; i++) {
            if (visited[i] == 0) { 
                visited[i] = 1;
                candidate.Add(nums[i]);
                DFS(res, candidate, nums, visited, level+1,size);
                candidate.RemoveAt(candidate.Count-1);
                visited[i] = 0;
            }
        }
    }
    public IList<IList<int>> Permute(int[] nums) {
        var res = new List<IList<int>>();
        var candidate = new List<int>();
        if (nums.Length == 0) return res;
        var visited = new int[nums.Length];
        DFS(res, candidate, nums, visited, 0, nums.Length);
        return res;
    }
}