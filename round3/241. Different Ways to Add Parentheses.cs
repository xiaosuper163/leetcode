public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        if (expression.Length <= 2) {
            int num;
            if (int.TryParse(expression, out num)) {
                return new List<int>() {num};
            }
        }
        
        IList<int> res = new List<int>();
        
        for (int i = 1; i < expression.Length; i ++) {
            if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*') {
                IList<int> leftRes = DiffWaysToCompute(expression.Substring(0, i));
                IList<int> rightRes = DiffWaysToCompute(expression.Substring(i + 1));
                foreach (int left in leftRes) {
                    foreach (int right in rightRes) {
                        if (expression[i] == '+') {
                            res.Add(left + right);
                        } else if (expression[i] == '-') {
                            res.Add(left - right);
                        } else {
                            res.Add(left * right);
                        }
                    }
                }
            }
        }
        
        return res;
    }
}