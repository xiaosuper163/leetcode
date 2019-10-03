public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 2) return nums.Length;
        int count = 1;
        int pre = 0, curr = 1;
        while (curr < nums.Length) {
            if (nums[pre] == nums[curr] && count > 0) {
                count--;
                nums[pre+1] = nums[curr];
                pre++;
                curr++;
            } else if (nums[pre] == nums[curr]) {
                if (curr+1<nums.Length) nums[pre+1] = nums[curr+1];
                curr++;
            } else {
                count = 1;
                nums[pre+1] = nums[curr];
                pre++;
                curr++;
            }
        }
        return pre+1;
    }
}

/*
public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2) return nums.Length;
        int pre = nums[0], cnt = 1, index = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != pre)
            {
                if (cnt <= 2)
                {
                    nums[index++] = pre;
                }
                pre = nums[i];
                cnt = 1;
            }
            else if (cnt <= 2)
            {
                nums[index++] = pre;
                cnt++;
            }
        }
        if (cnt <= 2) nums[index++] = nums[nums.Length - 1];
        return index;
    }
}
 */