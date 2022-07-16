public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => {return a[0] - b[0];});
        
        var lst = new List<int[]>();
                
        int[] curr = null;
        
        for (int i = 0; i < intervals.Length; i ++) {
            if (curr == null) {
                curr = intervals[i];
            } else {
                if (curr[1] < intervals[i][0]) {
                    lst.Add(curr);
                    curr = intervals[i];
                } else {
                    curr[1] = Math.Max(curr[1], intervals[i][1]);
                }
            }
        }
        
        if (curr != null) lst.Add(curr);;
        
        return lst.ToArray();
    }
}