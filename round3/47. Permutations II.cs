public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);
        int[] visited = new int[nums.Length];
        var res = new List<IList<int>>();
        
        DFSHelper(nums, visited, new List<int>(), res);
        
        return res;
    }
    
    private void DFSHelper(int[] nums, int[] visited, IList<int> currRes, IList<IList<int>> res) {
        if (currRes.Count == nums.Length) {
            res.Add(new List<int>(currRes));
            return;
        }
        
        for (int i = 0; i < nums.Length; i ++) {
            if (visited[i] == 1) continue;
            if (i > 0 && nums[i] == nums[i-1] && visited[i-1] == 0) continue; 
            // last condition could be either of visited[i-1] == 0 or visited[i-1] == 1
            
            visited[i] = 1;
            currRes.Add(nums[i]);
            DFSHelper(nums, visited, currRes, res);
            currRes.RemoveAt(currRes.Count - 1);
            visited[i] = 0;
            
        }
    }
}