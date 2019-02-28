public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if (gas.Sum() < cost.Sum()) {
            return -1;
        }
        int sum = 0;
        int index = 0;
        for (int i = 0; i < gas.Length; i++) {
            if (sum + gas[i] - cost[i] >= 0) {
                sum += gas[i] - cost[i];
            } else {
                sum = 0;
                index = i+1;
            }
        }
        if (index == gas.Length + 1) {
            return -1;
        }
        return index;
    }
}