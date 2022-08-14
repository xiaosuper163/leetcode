public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var res = new List<string>();
        if (nums.Length == 0) return res;
        
        string curr = "";
        int low = nums[0], high = nums[0];
                
        for (int i = 0; i < nums.Length; i ++) {
            if (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1]) continue;
            high = nums[i];
            curr = low == high ? low.ToString() : low.ToString() + "->" + high.ToString(); 
            res.Add(curr);
            if (i + 1 < nums.Length) {
                low = nums[i + 1];
            }
        }
        
        return res;
    }
}