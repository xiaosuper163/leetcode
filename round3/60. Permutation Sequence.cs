public class Solution {
    public string GetPermutation(int n, int k) {
        // 3 3, 3-1=2
        // 2!=2 2/2=1+0 1,2,3      "2"
        // 1!=1 0/1=0+0 1,3        "1"
        // 0!=1 0/1=0+0 3          "3"
        IList<int> lst = new List<int>();
        for (int i=1; i<=n; i++) {
            lst.Add(i);
        }
        
        string res = "";
        int denominator = 1, quotient;
        for (int i=1; i<n; i++) {
            denominator *= i;
        }
        
        k--;
        while(lst.Count != 0) {
            quotient = k / denominator;
            k = k - quotient * denominator;
            
            res += lst[quotient];
            lst.RemoveAt(quotient);
            if (lst.Count != 0) denominator /= lst.Count;
        } 
        
        return res;
    }
}