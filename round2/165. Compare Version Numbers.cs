public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] s1 = version1.Split('.');
        string[] s2 = version2.Split('.');
        string cur1=null, cur2=null;
        for(int i=0; i<Math.Max(s1.Length, s2.Length); i++) {
            if (i<s1.Length) cur1 = s1[i];
            else cur1 = "0";
            if (i<s2.Length) cur2 = s2[i];
            else cur2 = "0";
            if (int.Parse(cur1) < int.Parse(cur2)) return -1;
            else if (int.Parse(cur1) > int.Parse(cur2)) return 1;
        }
        return 0;
    }
}