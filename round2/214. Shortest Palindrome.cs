public class Solution {
    public static string Reverse( string s ) {
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
    public string ShortestPalindrome(string s) {
        int i=0, j=s.Length-1, end = j;
        while (i <= j) {
            if (s[i] == s[j]) {
                i++;
                j--;
            } else {
                i = 0;
                end--;
                j = end;
            }
        }
        if (end == s.Length - 1) return s;
        return Reverse(s.Substring(end+1)) + s;
    }
}