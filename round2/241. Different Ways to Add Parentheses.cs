public class Solution {
    public Dictionary<string, List<int>> memo = new Dictionary<string, List<int>>();
    public IList<int> DiffWaysToCompute(string input) {
        if (memo.ContainsKey(input)) return memo[input];
        int j = 0;
        while (j < input.Length && input[j] - '0' <= 9 && input[j] - '0' >= 0) j++;
        if (j == input.Length) return new List<int>(){Int32.Parse(input)};
        var res = new List<int>();
        for (int i=0; i<input.Length; i++) {
            if (input[i] == '+' || input[i] == '-' || input[i] == '*') {
                var leftRes = DiffWaysToCompute(input.Substring(0,i));
                var rightRes = DiffWaysToCompute(input.Substring(i+1));
                foreach (var left in leftRes) {
                    foreach (var right in rightRes) {
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
        memo[input] = res;
        return res;
    }
}