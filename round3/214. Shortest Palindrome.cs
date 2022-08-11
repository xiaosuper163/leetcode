public class Solution {
    public string Reverse( string s ) {
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
    
    public string ShortestPalindrome(string s) {
        int i = 0, j = s.Length - 1, r = j;
        while (i < j) {
            if (s[i] == s[j]) {
                i ++;
                j --;
            } else {
                i = 0;
                j = r - 1;
                r = j;
            }
        }
        
        return Reverse(s.Substring(r + 1)) + s;
    }
}