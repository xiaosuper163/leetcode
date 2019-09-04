public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int left = Math.Max(A, E);
        int right = Math.Min(C, G);
        int top = Math.Min(D, H);
        int bottom = Math.Max(B, F);
        int overlappedArea;
        if (left >= right || bottom >= top) overlappedArea = 0;
        else overlappedArea = (right - left) * (top - bottom);
        return (C-A)*(D-B) + (G-E)*(H-F) - overlappedArea;
    }
}