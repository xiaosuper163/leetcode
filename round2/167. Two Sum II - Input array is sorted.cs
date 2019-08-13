public class Solution {
    private bool Helper(int[] numbers, int start, int end, int target, int[] res) {
        while (start+1 < end) {
            int mid = (end-start)/2 + start;
            if (numbers[mid] == target) {
                res[1] = mid+1;
                return true;
            } else if (numbers[mid] < target) {
                start = mid;
            } else {
                end = mid;
            }
        }
        if (numbers[start] == target) {
            res[1] = start+1;
            return true;
        }
        if (numbers[end] == target) {
            res[1] = end+1;
            return true;
        }
        return false;
    }
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        for (int i=0; i<numbers.Length; i++) {
            res[0] = i+1;
            if (Helper(numbers, i, numbers.Length-1, target-numbers[i], res))
                return res;
        }
        return res;
    }
}