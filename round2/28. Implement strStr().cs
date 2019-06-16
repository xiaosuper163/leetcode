public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length == 0) return 0;
        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            int j = i;
            while (j < i + needle.Length) {
                if (haystack[j] != needle[j-i]) break;
                j++;
            }
            if (j == i + needle.Length) return i;
        }
        return -1;
    }
}