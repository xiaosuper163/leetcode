public class Solution {
    private int Gcd(int a, int b) {
        return b == 0 ? a : Gcd(b, a%b);
    }
    public int MaxPoints(int[][] points) {
        int res = 0;
        for (int i=0; i<points.Length; i++) {
            var m = new Dictionary<string, int>();
            int duplicate = 1;
            for (int j=i+1; j<points.Length; j++) {
                int dx = points[i][0] - points[j][0];
                int dy = points[i][1] - points[j][1];
                if (dx == 0 && dy == 0) {
                    duplicate++;
                    continue;
                }
                int gcd = Gcd(dx, dy);
                string key = $"{dx/gcd} {dy/gcd}";
                if (m.ContainsKey(key)) m[key]++;
                else m[key] = 1;
            }
            res = Math.Max(res, duplicate);
            foreach(KeyValuePair<string, int> entry in m) {
                res = Math.Max(res, entry.Value+duplicate);
            }
        }
        return res;
    }
}

/*

public class Solution {
    public int MaxPoints(int[][] points) {
        int len = points.Length;
        if (len == 0) return 0;
        int res = 1;
        for (int i=0; i<len; i++) {
            var p1 = points[i];
            var m = new Dictionary<string, int>();
            int duplicates = 1;
            for (int j=i+1; j<len; j++) {
                var p2 = points[j];
                if (p1[0] == p2[0] && p1[1]==p2[1]) {
                    duplicates++;
                    res = Math.Max(res, duplicates); // in case there is only overlapped points
                    continue;
                }
                int dx = p2[0] - p1[0];
                int dy = p2[1] - p1[1];
                int gcd = Gcd(dx, dy);
                string key = $"{dx/gcd} {dy/gcd}";
                if (m.ContainsKey(key)) m[key]++;
                else m[key] = 1;
            }
            foreach(KeyValuePair<string, int> entry in m) {
                res = Math.Max(res, entry.Value+duplicates);
            }
        }
        return res;
    }
    
    private int Gcd(int a, int b) {
        return b == 0 ? a : Gcd(b, a%b);
    }
}
 */