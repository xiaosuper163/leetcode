public class Solution {
    public string CountAndSay(int n) {
        string res = "1";
        
        while (n > 1) {
            string currRes = "";
            int cnt = 0;
            char currChar = res[0];
            
            for (int i = 0; i < res.Length; i++) {
                if (res[i] == currChar) {
                    cnt++;
                } else {
                    currRes = currRes + cnt.ToString() + currChar.ToString();
                    currChar = res[i];
                    cnt = 1;
                }
            }
            
            res = currRes + cnt.ToString() + currChar.ToString();
            
            n --;
        }
        
        return res;
    }
}