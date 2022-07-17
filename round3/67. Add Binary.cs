public class Solution {
    public string AddBinary(string a, string b) {
        string res = "";
        bool addOne = false;
        
        int m = Math.Max(a.Length, b.Length);
        
        for (int i = 0; i < m; i ++) {
            int x = a.Length - i - 1 >= 0 ? a[a.Length - i - 1] - '0' : 0;
            int y = b.Length - i - 1 >= 0 ? b[b.Length - i - 1] - '0' : 0;
            
            int curr = addOne? x + y + 1 : x + y;
            if (curr >= 2) {
                addOne = true;
                res = (curr % 2).ToString() + res;
            } else {
                addOne = false;
                res = curr.ToString() + res;
            }
        }
        
        if (addOne) res = "1" + res;
        return res;
    }
}