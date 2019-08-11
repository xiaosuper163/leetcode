public class Solution {
    public int MaximumGap(int[] nums) {
        if (nums.Length == 0) return 0;
        int max = 0, min = int.MaxValue;
        foreach (var num in nums) {
            max = Math.Max(max, num);
            min = Math.Min(min, num);
        }
        int size = (max-min) / nums.Length + 1;
        int cnt = (max-min) / size + 1;
        
        int[] bucketMins = new int[cnt];
        int[] bucketMaxs = new int[cnt];
        for (int i=0; i<cnt; i++) {
            bucketMins[i] = int.MaxValue;
            bucketMaxs[i] = -1;
        }
        
        foreach (var num in nums) {
            int index = (num-min) / size;
            bucketMins[index] = Math.Min(bucketMins[index], num);
            bucketMaxs[index] = Math.Max(bucketMaxs[index], num);
        }
        for (int i=0; i<cnt; i++) {
            Console.WriteLine(bucketMaxs[i]);
        }
        
        int res = 0;
        for (int i=0; i<cnt-1; i++) {
            if (bucketMaxs[i] != -1) {
                int j=i+1;
                while (bucketMins[j] == int.MaxValue) j++;
                if (j > cnt-1) break;
                res = Math.Max(res, bucketMins[j] - bucketMaxs[i]);
            }
        }
        
        return res;
    }
}