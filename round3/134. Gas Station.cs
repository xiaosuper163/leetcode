public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int total = 0, gasLeft = 0, res = 0;
        for (int i = 0; i < gas.Length; i ++) {
            total += gas[i] - cost[i];
            gasLeft += gas[i] - cost[i];
            if (gasLeft < 0) {
                gasLeft = 0;
                res = i + 1;
            }
        }
        
        return total < 0 ? -1 : res;
    }
}