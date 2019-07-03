public class Solution {
    private void DFS(List<IList<int>> res, List<int> curr, int index, int n, int k) {
        if (curr.Count == k) res.Add(new List<int>(curr));
        for (int i=index+1; i<=n; i++) {
            curr.Add(i);
            DFS(res, curr, i, n, k);
            curr.RemoveAt(curr.Count - 1);
        }
    }
    public IList<IList<int>> Combine(int n, int k) {
        var res = new List<IList<int>>();
        var curr = new List<int>();
        DFS(res, curr, 0, n, k);
        return res;
    }
}