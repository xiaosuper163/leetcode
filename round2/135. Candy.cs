public class Solution {
    public int Candy(int[] ratings) {
        int res = ratings.Length;
        int start = 1;
        int[] nums = new int[ratings.Length];
        nums[0] = 1;
        for (int i = 1; i < ratings.Length; i++) {
            if (ratings[i] > ratings[i-1]) {
                //Console.WriteLine(start);
                res += start;
                nums[i] = 1 + start;
                start ++;
            } else {
                nums[i] = 1;
                start = 1;
            }
        }
        for (int j=ratings.Length-2; j>=0; j--) {
            if (ratings[j] > ratings[j+1] && nums[j] <= nums[j+1]) {
                res += nums[j+1] - nums[j] + 1;
                nums[j] = nums[j+1] + 1;
            }
        }
        return res;
    }
}