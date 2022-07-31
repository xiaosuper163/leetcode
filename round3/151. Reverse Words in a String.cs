public class Solution {
    public string ReverseWords(string s) {
        var ca = s.ToCharArray();
        Array.Reverse(ca);        
        string s1 = new string(ca);
        string res = "";
        
        int start = 0, end = -1;
        while (end < s1.Length) {
            
            string currWord = "";
            
            start = end + 1;
            while (start < s1.Length && s1[start] == ' ') {
                start ++;
            }
            
            end = start;
            while (end < s1.Length && s1[end] != ' ') {
                currWord = s1.Substring(end, 1) + currWord;
                end ++;
            }
            
            if (currWord.Length > 0)
                res += res.Length == 0 ? currWord : " " + currWord;
        }
        
        return res;
    }
}