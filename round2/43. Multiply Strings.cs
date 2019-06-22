public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1 == "0" || num2 == "0") return "0";
        int size = num1.Length + num2.Length;
        int[] helper = new int[size];
        for (int i=num1.Length-1; i>=0; i--) {
            for (int j=num2.Length-1; j>=0; j--) {
                int temp = (num1[i]-'0') * (num2[j]-'0');
                int prev = helper[size-2-i-j];
                //Console.WriteLine(string.Format("i={0}, j={1}, temp={2}", i, j, temp));
                prev += temp;
                helper[size-2-i-j] = prev % 10;
                helper[size-1-i-j] += prev / 10;
            }
        }
        StringBuilder sb = new StringBuilder();
        for (int i=size-1; i>=0; i--) {
            if (helper[i] != 0 || sb.Length > 0) {
                sb.Append(helper[i]);
            }
        }
        return sb.ToString();
    }
}