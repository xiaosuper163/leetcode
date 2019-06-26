public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if (intervals.Length==0) {
            int[][] resp = new int[1][];
            resp[0] = newInterval;
            return resp;
        }
        List<IList<int>> res = new List<IList<int>>();
        
        int index = 0;
        bool hasInserted = false;
        int start;
        if (intervals[0][0] >= newInterval[0]) {
            res.Add(new List<int>(newInterval));
            start = 0;
            hasInserted = true;
        } else {
            res.Add(new List<int>(intervals[0]));
            start = 1;
        }
        
        for (int i=start; i<intervals.Length; i++) {
            if (!hasInserted && res[index][1] >= newInterval[0]) {
                if (res[index][1] < newInterval[1]) {
                    res[index][1] = newInterval[1];
                }
                hasInserted = true;
            }
            if (res[index][1] >= intervals[i][0]) {
                if (res[index][1] < intervals[i][1]) {
                    res[index][1] = intervals[i][1];
                } 
            } else if (!hasInserted && newInterval[0]<=intervals[i][0]) {
                res.Add(new List<int>(newInterval));
                index++;
                i--;
                hasInserted = true;
            } else {
                res.Add(new List<int>(intervals[i]));
                index++;
            }
        }
        if (!hasInserted) {
            if (res[index][1] >= newInterval[0]) {
                if (res[index][1] < newInterval[1]) {
                    res[index][1] = newInterval[1];   
                }
            } else {
                res.Add(new List<int>(newInterval));
                index++;
            }
        }        
        return res.Select(l => l.ToArray()).ToArray();
    }
}