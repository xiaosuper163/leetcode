public class Solution {
    public int MaxPoints(int[][] points) {
        int n = points.Length;
        int res = 0;
        
        for (int i = 0; i < n; i ++) {
            int x1 = points[i][0];
            int y1 = points[i][1];
            
            int duplicate = 1;
            for (int j = 1; j < n; j ++) {
                int x2 = points[j][0];
                int y2 = points[j][1];
                
                if (x1 == x2 && y1 == y2) {
                    duplicate ++;
                    continue;
                }
                
                int currRes = 0;
                for (int k = 0; k < n; k ++) {
                    int x3 = points[k][0];
                    int y3 = points[k][1];
                    
                    if ((x3 - x2) * (y2 - y1) == (x2 - x1) * (y3 - y2)) {
                        currRes ++;
                    }
                }
                res = Math.Max(res, currRes);                
            }
            res = Math.Max(res, duplicate);
        }
        
        return res;
    }
}