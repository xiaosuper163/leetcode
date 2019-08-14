public class Solution {
    public int MajorityElement(int[] nums) {
        int occurrences = 0;
        int? res = null;
        foreach(int num in nums) {
            if (res == null) {
                res = num;
                occurrences = 1;
            } else if (num == res) {
                occurrences++;
            } else {
                occurrences--;
            }
            if (occurrences == 0) {
                occurrences = 1;
                res = num;
            }
        }
        return (int) res;
    }
}