// DFS

public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> collection = new List<int>();
        if (k == 0) {
            return res;
        }
        Helper(res, collection, 1, n, k);
        return res;
    }
    
    public void Helper(IList<IList<int>> res, IList<int> collection, int index, int n, int k) {
        IList<int> collection_cp = new List<int>(collection);
        if (k == 0) {
            res.Add(collection_cp);
            return;
        }
        
        for (int i=index; i<=n; i++) {
            collection_cp.Add(i);
            Helper(res, collection_cp, i+1, n, k-1);
            collection_cp.RemoveAt(collection_cp.Count()-1);
        }
    }
}