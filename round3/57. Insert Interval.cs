public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var lst = new List<int[]>();
        int[] curr = null;
        
        for (int i = 0; i < intervals.Length; i++) {
            if (newInterval[1] < intervals[i][0]) {
                lst.Add(newInterval);
                while (i < intervals.Length) {
                    lst.Add(intervals[i]);
                    i++;
                }
            } else if (intervals[i][1] < newInterval[0]) {
                lst.Add(intervals[i]);
                if (i == intervals.Length - 1) {
                    lst.Add(newInterval);
                }
            } else {
                int[] tmp = new int[2];
                tmp[0] = Math.Min(intervals[i][0], newInterval[0]);
                tmp[1] = Math.Max(intervals[i][1], newInterval[1]);
                i++;
                
                while (i < intervals.Length && intervals[i][0] <= tmp[1]) {
                    tmp[1] = Math.Max(tmp[1], intervals[i++][1]);
                }
                
                lst.Add(tmp);
                
                while (i < intervals.Length) {
                    lst.Add(intervals[i]);
                    i ++;
                }
            }
        }
        
        if (intervals.Length == 0) lst.Add(newInterval);
        
        return lst.ToArray();
    }
}