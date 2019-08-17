public class Solution {
    public string LargestNumber(int[] nums) {
        Array.Sort(nums, (int a, int b) => (int) (long.Parse(b.ToString()+a.ToString())-long.Parse(a.ToString()+b.ToString())));
        var sb = new StringBuilder();
        foreach(int num in nums) {
            sb.Append(num);
        }
        int i=0;
        while(i<sb.Length && sb[i]=='0') i++;
        if (i==sb.Length) return "0";
        return sb.ToString().Substring(i);
    }
}