public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var res = new List<IList<int>>();
        if (numRows <= 0) return res;
        for (int i=0; i<numRows; i++) {
            List<int> levelRes = new List<int>(i+1);
            levelRes.Add(1);
            for (int j=1; j<i; j++) {
                levelRes.Add(res[i-1][j-1] + res[i-1][j]);
            }
            if (i!=0) levelRes.Add(1);
            res.Add(levelRes);
        }
        return res;
    }
}