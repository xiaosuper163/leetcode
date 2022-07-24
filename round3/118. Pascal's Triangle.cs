public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var res = new List<IList<int>>();
        res.Add(new List<int>(){1});
        
        for (int i = 1; i < numRows; i ++) {
            var currRes = new List<int>();
            currRes.Add(1);
            var lastRes = res.Last();
            for (int j = 1; j < lastRes.Count; j ++) {
                currRes.Add(lastRes[j-1] + lastRes[j]);
            }
            currRes.Add(1);
            res.Add(currRes);
        }
        
        return res;
    }
}