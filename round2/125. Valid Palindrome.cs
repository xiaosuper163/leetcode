public class Solution {   
    public bool IsPalindrome(string s) {
        if (s.Length == 0) return true;
        int i = 0, j = s.Length - 1;
        while (i < j) {
            while (i<s.Length && !Char.IsLetterOrDigit(s[i])) i++;
            while (j>=0 && !Char.IsLetterOrDigit(s[j])) j--;
            if (i >= j) return true;
            //Console.WriteLine($"{i} {j} {s[i]} {s[j]}");
            if (Char.ToLower(s[i]) != Char.ToLower(s[j])) return false;
            i++;
            j--;
        }
        return true;
    }
}