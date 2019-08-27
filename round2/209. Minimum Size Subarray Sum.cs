// O(nlogn)
public class Solution {
    private int MinWidth(int[] sums, int left, int right, int target) {
        int start = left - 1;
        while (left + 1 < right) {
            int mid = (right - left) / 2 + left;
            if (sums[mid] == target) return mid - start;
            else if (sums[mid] < target) left = mid;
            else right = mid;
        }
        //Console.WriteLine($"{start} {left} {right}");
        if (sums[left] >= target) return left - start;
        if (sums[right] >= target) return right - start;
        return int.MaxValue;
    }
    public int MinSubArrayLen(int s, int[] nums) {
        if (nums.Length == 0) return 0;
        int[] sums = new int[nums.Length+1];
        sums[0] = 0;
        for (int i=1; i<=nums.Length; i++) {
            sums[i] = sums[i-1] + nums[i-1];
        }
        int res = int.MaxValue;
        for (int i=0; i<sums.Length-1; i++) {
            int left = i + 1, right = sums.Length-1;
            int currRes = MinWidth(sums, left, right, sums[i]+s);
            res = Math.Min(res, currRes);
        }
        if (res != int.MaxValue) return res;
        return 0;
    }
}

// O(n)
/*
public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        if (nums.Length == 0) return 0;
        int left = 0, right = 1, res = int.MaxValue, sum = nums[0];
        while (left < nums.Length) {
            int currRes = int.MaxValue;
            while (sum<s && right<nums.Length) {
                sum += nums[right];
                right++;
            }
            if (sum>=s) currRes = right-left;
            res = Math.Min(res, currRes);
            
            while (sum-nums[left]>=s && left<=right) {
                sum -= nums[left];
                left++;
            }
            if (sum>=s) currRes = right-left;
            res = Math.Min(res, currRes);
            
            sum -= nums[left];
            left++;
            if (right <= left) right = left + 1;
        }
        if (res != int.MaxValue) return res;
        return 0;
    }
}
*/