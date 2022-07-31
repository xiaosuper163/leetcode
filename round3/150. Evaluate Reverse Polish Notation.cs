public class Solution {
    public int EvalRPN(string[] tokens) {
        var st = new Stack<int>();
        
        foreach (string token in tokens) {
            if (token == "+" || token == "-" || token == "/" || token == "*") {
                int num2 = st.Pop();
                int num1 = st.Pop();
                
                switch (token) {
                    case "+":
                        st.Push(num1 + num2);
                        break;
                    case "-":
                        st.Push(num1 - num2);
                        break;
                    case "/":
                        st.Push(num1 / num2);
                        break;
                    case "*":
                        st.Push(num1 * num2);
                        break;
                }
            } else {
                st.Push(Int32.Parse(token));
            }
        }
        
        return st.Pop();
    }
}