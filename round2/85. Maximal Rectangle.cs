public class Solution {
    private int LargestRectangleArea(int[] heights) {
        int res = heights[0];
        Stack<int> st = new Stack<int>();
        st.Push(0);
        for (int i=1; i<heights.Length; i++) {
            if (st.Count == 0 || heights[st.Peek()] < heights[i]) st.Push(i);
            else {
                int top = st.Pop();
                res = Math.Max(res, st.Count==0 ? heights[top]*i : heights[top]*(i-st.Peek()-1));
                i--;
            }
        }
        return res;
    }
    public int MaximalRectangle(char[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return 0;
        int res = 0;
        int[] helperArray = new int[matrix[0].Length+1];
        for (int i=0; i<matrix.Length; i++) {
            for (int j=0; j<matrix[0].Length; j++) {
                if (matrix[i][j] == '1') helperArray[j]++;
                else helperArray[j]=0;
            }
            res = Math.Max(res, LargestRectangleArea(helperArray));
        }
        return res;
    }
}