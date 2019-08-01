public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if (gas.Sum() < cost.Sum()) return -1;
        int start = 0, left = 0;
        for (int i=0; i<gas.Length; i++) {
            //Console.WriteLine(left);
            if (left + gas[i] >= cost[i]) {
                left += gas[i] - cost[i];
            } else {
                start = i + 1;
                left = 0;
            }
        }
        if (start >= gas.Length) return -1;
        return start;
    }
}