public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        if (numerator == 0) return "0";
        
        StringBuilder sb = new StringBuilder();
        var dict = new Dictionary<long, int>();
        
        bool isPositive = (numerator > 0 && denominator > 0) || (numerator < 0) && (denominator < 0);
        if (!isPositive) sb.Append("-");
        
        long num = numerator == int.MinValue ? ((long) int.MaxValue) + 1 : Math.Abs(numerator);
        long den = denominator == int.MinValue ? ((long) int.MaxValue) + 1 : Math.Abs(denominator);
        
        sb.Append(num / den);        
        num = num % den;
        if (num != 0) sb.Append(".");
        
        while (num != 0) {
            num *= 10;
            long curr = num / den;
            if (dict.ContainsKey(num)) {
                sb.Insert(dict[num], "(");
                sb.Append(")");
                break;
            }
            
            dict[num] = sb.Length;
            sb.Append(curr);
            num %= den;
        }
        
        return sb.ToString(); 
    }
}