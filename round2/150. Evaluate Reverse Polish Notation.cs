public class Solution {
    public int EvalRPN(string[] tokens) {
        var st = new Stack<string>();
        foreach(string token in tokens) {
            if (token.Equals("+")||token.Equals("-")||token.Equals("*")||token.Equals("/")) {
                int prev1 = Convert.ToInt32(st.Pop());
                int prev2 = Convert.ToInt32(st.Pop());
                switch(token) {
                    case "+":
                        st.Push((prev1+prev2).ToString());
                        break;
                    case "-":
                        st.Push((prev2-prev1).ToString());
                        break;
                    case "*":
                        st.Push((prev1*prev2).ToString());
                        break;
                    case "/":
                        st.Push((prev2/prev1).ToString());
                        break;
                }
            } else {
                st.Push(token);
            }
        }
        return Convert.ToInt32(st.Pop());
    }
}