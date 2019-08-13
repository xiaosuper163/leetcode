public class Solution {
    public string ConvertToTitle(int n) {
        StringBuilder sb = new StringBuilder();
        while (n > 0) {
            int curr = n % 26;
            if (curr == 0) {
                sb.Insert(0, 'Z');
                n -= 26;
            }
            else sb.Insert(0, (Char)(Convert.ToUInt16('A') + curr-1));
            n = n / 26;
        }
        return sb.ToString();
    }
}