public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var m = new HashSet<int>();
        foreach (var num in nums) {
            if (m.Contains(num)) return true;
            m.Add(num);
        }
        return false;
    }
}