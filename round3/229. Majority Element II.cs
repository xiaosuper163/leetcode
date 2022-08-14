public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int candidate1 = int.MinValue, candidate2 = int.MinValue, cnt1 = 0, cnt2 = 0;
        foreach (int num in nums) {
            if (num == candidate1) cnt1++;
            else if (num == candidate2) cnt2++;
            else if (cnt1 == 0) {
                candidate1 = num;
                cnt1 = 1;
            }
            else if (cnt2 == 0) {
                candidate2 = num;
                cnt2 = 1;
            }
            else {
                cnt1 --;
                cnt2 --;
            }
        }
        
        cnt1 = 0;
        cnt2 = 0;
        foreach (int num in nums) {
            if (num == candidate1) cnt1 ++;
            else if (num == candidate2) cnt2 ++;
        }
        
        var res = new List<int>();
        if (cnt1 > nums.Length / 3) res.Add(candidate1);
        if (cnt2 > nums.Length / 3) res.Add(candidate2);
        return res;
    }
}