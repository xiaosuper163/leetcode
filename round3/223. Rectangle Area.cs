public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int top = Math.Min(ay2, by2);
        int bottom = Math.Max(ay1, by1);
        int left = Math.Max(ax1, bx1);
        int right = Math.Min(ax2, bx2);
        int s1 = Math.Abs(ay2 - ay1) * Math.Abs(ax2 - ax1);
        int s2 = Math.Abs(by2 - by1) * Math.Abs(bx2 - bx1);
        int overlap = (top - bottom) * (right - left);
        if (top <= bottom || right <= left) overlap = 0;
        return s1 + s2 - overlap;
    }
}