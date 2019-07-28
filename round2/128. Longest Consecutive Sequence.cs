public class Solution {
    public int LongestConsecutive(int[] nums) {
        var nums_set = new HashSet<int>(nums);
        int res = 0;
        foreach (int num in nums) {
            if (nums_set.Contains(num)) {
                int tmpRes = 1;
                nums_set.Remove(num);
                int numup = num;
                int numdown = num;
                while(true) {
                    numup++;
                    if (nums_set.Contains(numup)) {
                        nums_set.Remove(numup);
                        tmpRes++;
                    } else {
                        res = Math.Max(res, tmpRes);
                        break;
                    }
                }
                while(true) {
                    numdown--;
                    if (nums_set.Contains(numdown)) {
                        nums_set.Remove(numdown);
                        tmpRes++;
                    } else {
                        res = Math.Max(res, tmpRes);
                        break;
                    }
                }
            }
        }
        return res;
    }
}