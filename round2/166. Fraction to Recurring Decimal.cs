public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        bool isPositive = (numerator >= 0 && denominator >= 0) || (numerator <= 0 && denominator <= 0);
        StringBuilder sb = new StringBuilder();
        var mem = new Dictionary<long, int>();
        string memStr = "";
        long num = numerator == int.MinValue ? (long) 2147483648 : Math.Abs(numerator);
        long den = denominator <= int.MinValue ? (long) 2147483648 : Math.Abs(denominator);
        if (!isPositive) sb.Append('-');
        sb.Append(num / den);
        sb.Append('.');
        num %= den;
        while(num!=0) {
            if (mem.ContainsKey(num)) {
                sb.Insert(mem[num], '(');
                sb.Append(')');
                break;
            }
            mem[num] = sb.Length;
            sb.Append((num * 10) / den);
            num = (num * 10) % den;
        }
        return sb.ToString().Trim('.');
    }
}