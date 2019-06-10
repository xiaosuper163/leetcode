public class Solution {
    public bool IsMatch(string s, string p) {
        bool[,] helperArray = new bool[s.Length+1,p.Length+1];
        helperArray[s.Length,p.Length] = true;
        for (int i = s.Length ; i >= 0; i --) {
            for (int j = p.Length - 1; j >= 0; j--) {
                bool firstMatch = (i < s.Length) && (s[i] == p[j] || p[j] == '.');
                if (j < p.Length - 1 && p[j+1] == '*') {
                    helperArray[i,j] = (firstMatch && helperArray[i+1,j]) || helperArray[i,j+2];
                } else {
                    helperArray[i,j] = firstMatch && helperArray[i+1,j+1];
                }
            }
        }
        return helperArray[0,0];
    }
}