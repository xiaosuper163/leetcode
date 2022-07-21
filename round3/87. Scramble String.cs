public class Solution {
    public bool IsScramble(string s1, string s2) {
        int len = s1.Length;
        bool[][][] dp = new bool[len][][];
        // i - start index of s1, j - start index of s2, k - length of the substring
        for (int i = 0; i < len; i++) {
            dp[i] = new bool[len][];
            for (int j = 0; j < len; j++) {
                dp[i][j] = new bool[len + 1];
                dp[i][j][1] = (s1[i] == s2[j]);
            }
        }
        
        for (int k = 2; k <= len; k ++) {
            for (int i = 0; i <= len - k; i ++) {
                for (int j = 0; j <= len - k; j ++) {
                    for (int cut = 1; cut < k; cut ++) {
                        if  ((dp[i][j][cut] && dp[i+cut][j+cut][k-cut] ) || (dp[i][j+k-cut][cut] && dp[i+cut][j][k-cut])) {
                            dp[i][j][k] = true;
                            break;
                        }
                    }
                }
            }
        }
        
        return dp[0][0][len];
    }
}


// The recursive appoach exceeds time limit
// public class Solution {
//     public bool IsScramble(string s1, string s2) {
        
//         int len = s1.Length;
//         if (s1 == s2) return true;
        
//         string str1 = String.Concat(s1.OrderBy(c => c));
//         string str2 = String.Concat(s2.OrderBy(c => c));
        
//         if (str1 != str2) return false;
        
//         for (int i = 1; i < len; i ++) {
//             string s11 = s1.Substring(0, i);
//             string s12 = s1.Substring(i, len - i);
//             string s21 = s2.Substring(0, i);
//             string s22 = s2.Substring(i, len - i);
            
//             if (IsScramble(s11, s21) && IsScramble(s12, s22)) return true;
            
//             s21 = s2.Substring(0, len - i);
//             s22 = s2.Substring(len - i, i);
            
//             if (IsScramble(s11, s22) && IsScramble(s12, s21)) return true;            
//         }
        
//         return false;
//     }
// }