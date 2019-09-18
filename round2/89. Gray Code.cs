public class Solution {
    public IList<int> GrayCode(int n) {
        var res = new List<int>() {0};
        for (int i = 0; i < n; i++) {
            int levelSize = res.Count;
            for (int j=levelSize-1; j>=0; j--) {
                res.Add(res[j] | (1<<i));
            }
        }
        return res;
    }
}