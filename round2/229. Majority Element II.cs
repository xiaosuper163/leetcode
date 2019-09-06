public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int cnt1 = 0, cnt2 = 0;
        int cand1 = 0, cand2 = 0;
        foreach (var num in nums) {
            if (num == cand1) {
                cnt1++;
            } else if (num == cand2) {
                cnt2++;
            } else if (cnt1 == 0) {
                cand1 = num;
                cnt1 = 1;
            } else if (cnt2 == 0) {
                cand2 = num;
                cnt2 = 1;
            } else {
                cnt1--;
                cnt2--;
            }            
        }
        cnt1 = 0;
        cnt2 = 0;
        foreach (var num in nums) {
            if (num == cand1) cnt1++;
            else if (num == cand2) cnt2++;
        }
        var res = new List<int>();
        if (cnt1 > nums.Length / 3) res.Add(cand1);
        if (cnt2 > nums.Length / 3) res.Add(cand2);
        return res;
    }
}