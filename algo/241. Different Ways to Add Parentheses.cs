public class Solution {
    public IList<int> DiffWaysToCompute(string input) {
        IList<int> res = new List<int>();
        if (!input.Contains("+") && !input.Contains("-") && !input.Contains("*")) {
            res.Add(Int32.Parse(input));
            return res;
        }
        for (int i = 0; i < input.Length; i++) {
            if (input[i].Equals('+') || input[i].Equals('-') || input[i].Equals('*')) {
                IList<int> leftRes = DiffWaysToCompute(input.Substring(0, i));
                IList<int> rightRes = DiffWaysToCompute(input.Substring(i+1, input.Length-i-1));
                foreach(int left in leftRes) {
                    foreach(int right in rightRes) {
                        switch(input[i]) {
                            case '+':
                                res.Add(left + right);
                                break;
                            case '-':
                                res.Add(left - right);
                                break;
                            case '*':
                                res.Add(left * right);
                                break;
                        }
                    }
                }
            }
        }
        return res;
    }
}