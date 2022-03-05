public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();
        var visited = new bool[nums.Length];
        for (int i=0; i<nums.Length; i++) {
            visited[i] = false;
        }
        DFSHelper(nums, visited, new List<int>(), res);
        return res;
    }
    
    public void DFSHelper(int[] nums, bool[] visited, IList<int> currRes, IList<IList<int>> res) {
        if (currRes.Count == nums.Length) {
            res.Add(new List<int>(currRes));
            return;
        }
        
        for (int i=0; i<nums.Length; i++) {
            if (visited[i]) continue;
            
            visited[i] = true;
            currRes.Add(nums[i]);
            DFSHelper(nums, visited, currRes, res);
            
            currRes.RemoveAt(currRes.Count-1);
            visited[i] = false;        
        }
    }
}