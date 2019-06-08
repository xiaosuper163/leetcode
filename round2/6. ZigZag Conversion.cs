public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        char[] resCharArray = new char[s.Length];
        int index = 0;
        for (int i=0; i<numRows; i++) {
            int offset1 = i;
            int offset2 = 2 * (numRows-1) - i;
            int start = 0;
            if (i > 0 && i < numRows-1) {
                while (start < s.Length) {
                    //Console.WriteLine("index="+index+" offset1="+offset1);
                    if (start+offset1<s.Length) resCharArray[index++] = s[start+offset1];
                    if (start+offset2<s.Length) resCharArray[index++] = s[start+offset2];
                    start += 2 * (numRows-1);
                }
            } else {
                while (start < s.Length) {
                    if (start+offset1<s.Length) resCharArray[index++] = s[start+offset1];
                    start += 2 * (numRows-1);
                }
            }
        }
        return new string(resCharArray);
    }
}