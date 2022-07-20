public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var st = new Stack<int>();
        int res = 0;
        
        for (int i = 0; i <= heights.Length; i ++) {
            int currHeight = i == heights.Length ? 0 : heights[i];
            
            if (st.Count == 0 || heights[st.Peek()] < currHeight) {
                st.Push(i);
            } else {
                int prev = st.Pop();
                res = Math.Max(res, heights[prev] * (st.Count == 0 ? i : i - st.Peek() - 1)); 
                // !!! st is empty when a height of 0 is reached
                // because  no height can be smaller than 0
                i --;
            }
        }
        
        return res;
    }
}