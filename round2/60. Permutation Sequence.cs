public class Solution {
    public string GetPermutation(int n, int k) {
        int fact = 1;
        List<int> helperList = new List<int>();
        for (int i=1; i<=n; i++) {
            fact *= i;
            helperList.Add(i);
        }
        StringBuilder sb = new StringBuilder();
        for (int i=0, l=k-1; i<n; i++) {
            fact /= (n-i);
            int index = l / fact;
            sb.Append(helperList[index].ToString());
            helperList.RemoveAt(index);
            l -= index * fact;
        }
        return sb.ToString();
    }
}