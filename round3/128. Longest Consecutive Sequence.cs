public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hs = new HashSet<int>(nums);
        int res = 0;
        foreach (int element in hs) {         
            int num = element;            
            int currRes = 1;
            hs.Remove(num);
            while (hs.Contains(num - 1)) {
                currRes ++;
                num --;
                hs.Remove(num);
            }
            
            num = element;        
            while (hs.Contains(num + 1)) {
                currRes ++;
                num ++;
                hs.Remove(num);
            }
            
            res = Math.Max(res, currRes);
        }
        
        return res;
    }
}