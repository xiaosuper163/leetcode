public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] v1 = version1.Split('.');
        string[] v2 = version2.Split('.');
        
        int cnt1 = v1.Length, cnt2 = v2.Length;
        int i = 0;
        string curr1, curr2;
        
        while (cnt1 > i || cnt2 > i) {
            curr1 = i < cnt1 ? v1[i] : "0";
            curr2 = i < cnt2 ? v2[i] : "0";
            
            int ver1 = int.Parse(curr1);
            int ver2 = int.Parse(curr2);
            
            if (ver1 < ver2) return -1;
            if (ver1 > ver2) return 1;
            i ++;
        }
        
        return 0;
    }
}