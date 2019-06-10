public class Solution {
    public int MaxArea(int[] height) {
        int cursor1 = 0;
        int cursor2 = height.Length - 1;
        int res = 0;
        while (cursor1 != cursor2) {
            int temp = Math.Min(height[cursor1], height[cursor2]) * (cursor2 - cursor1);
            res = Math.Max(temp, res);
            if (height[cursor1] < height[cursor2]) {
                cursor1 ++;
            } else {
                cursor2 --;
            }
        }
        return res;
    }
}