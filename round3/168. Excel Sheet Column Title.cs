public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string res = "";
        while (columnNumber > 0) {
            int curr = columnNumber % 26;
            if (curr == 0) {
                res = "Z" + res;
                columnNumber -= 26;
            } else {
                res = ((char)('A' + curr - 1)).ToString() + res;
            }
            columnNumber /= 26;
        }
        
        return res;
    }
}