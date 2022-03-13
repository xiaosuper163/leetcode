public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var res = new int[2];
        int left = 0, right = numbers.Length - 1;
        while (left < right) {
            if (numbers[left] + numbers[right] == target) {
                res[0] = left + 1;
                res[1] = right + 1;
                return res;
            }
            
            if (numbers[left] + numbers[right] < target) {
                left ++;
            } else {
                right --;
            }
        }
        
        return res;
    }
}