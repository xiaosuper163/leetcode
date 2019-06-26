public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length==0) return new int[0][];
        intervals = intervals.OrderBy(entry => entry[0]).ToArray();
        List<IList<int>> res = new List<IList<int>>();
        res.Add(new List<int>(intervals[0]));
        int index = 0;
        for (int i=1; i<intervals.Length; i++) {
            if (res[index][1] >= intervals[i][0]) {
                if (res[index][1] < intervals[i][1]) {
                    res[index][1] = intervals[i][1];
                } 
            } else {
                res.Add(new List<int>(intervals[i]));
                index++;
            }
        }
        return res.Select(l => l.ToArray()).ToArray();
    }
}