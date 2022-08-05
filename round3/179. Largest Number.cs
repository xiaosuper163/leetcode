public class Solution {
    public string LargestNumber(int[] nums) {
        Array.Sort(nums, (x, y) => {
            return (int) (long.Parse(y.ToString() + x.ToString()) - long.Parse(x.ToString() + y.ToString()));
        });
        string res = string.Join("", nums).TrimStart('0');
        return res == "" ? "0" : res;
    }
}