public class Solution {
    public int LargestRectangleArea(int[] heights) {
        if (heights.Length == 0) return 0;
        int res = heights[0];
        Stack<int> st = new Stack<int>();
        st.Push(0);
        for (int i=1; i<=heights.Length; i++) {
            int curr = i == heights.Length ? 0 : heights[i];
            if (st.Count == 0 || curr > heights[st.Peek()]) st.Push(i);
            else {
                int top = st.Pop();
                res = Math.Max(res, heights[top] * (st.Count == 0 ? i : i-st.Peek()-1));
                //Console.WriteLine(res);
                i--;
            }
        }
        return res;
    }
}