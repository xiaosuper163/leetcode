public class Solution {
    public IList<int> GrayCode(int n) {
        var res = new List<int>();
        res.Add(0);
        
        for (int i = 0; i < n; i ++) {
            int cnt = res.Count;
            for (int j = cnt - 1; j >= 0; j --) {
                res.Add(res[j] | (1 << i));  
            }            
        }
        
        return res;
    }
}