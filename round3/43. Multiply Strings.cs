public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1 == "0" || num2 == "0") return "0";
        int len = num1.Length + num2.Length;        
        int[] helper = new int[len];
        
        for (int j = num2.Length - 1; j >= 0 ; j --) {            
            for (int i = num1.Length - 1; i >= 0; i --) {
                int curr = (num2[j] - '0') * (num1[i] - '0');
                int prev = helper[len - i - j - 2];
                
                helper[len - i - j - 2] = (curr + prev) % 10;
                helper[len - i - j - 1] += (curr + prev) / 10;
            }  
        }
        
        StringBuilder sb = new StringBuilder();
        if (helper[len - 1] != 0) sb.Append(helper[len - 1].ToString()); 
        
        for (int i = len - 2; i >= 0; i --) {
            sb.Append(helper[i].ToString());
        }
        
        return sb.ToString();
    }
}