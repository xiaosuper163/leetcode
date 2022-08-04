public class Solution {
    public int TitleToNumber(string columnTitle) {
        int res = 0;
        int bas = 1;
        for (int i = columnTitle.Length - 1; i >= 0; i --) {
            res += (columnTitle[i] - 'A' + 1) * bas;
            bas *= 26;
        }
        return res;
    }
}