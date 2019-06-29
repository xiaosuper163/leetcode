public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 1;
        for (int i=digits.Length-1; i>=0; i--) {
            int curr = digits[i] + carry;
            digits[i] = curr % 10;
            carry = curr / 10;
            if (carry == 0) return digits;
        }
        int[] res = new int[digits.Length+1];
        res[0] = 1;
        return res;
    }
}