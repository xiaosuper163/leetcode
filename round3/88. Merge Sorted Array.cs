public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1, j = n - 1, k = m + n - 1;
        
        while (k >= 0 && i >= 0 && j >= 0) {
            if (nums1[i] >= nums2[j]) {
                nums1[k--] = nums1[i--];
            } else {
                nums1[k--] = nums2[j--];
            }
        }     
     
        if (j >= 0) { // !!! >=  NOT >
            while (k >= 0) {
                nums1[k--] = nums2[j--];
            }    
        }
    }    
}