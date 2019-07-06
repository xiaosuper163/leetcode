public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int cursor = m+n-1;
        m--;
        n--;
        while (m>=0 || n>=0) {
            if (m<0) nums1[cursor--] = nums2[n--];
            else if (n<0) nums1[cursor--] = nums1[m--];
            else {
                if (nums1[m] < nums2[n]) nums1[cursor--] = nums2[n--];
                else nums1[cursor--] = nums1[m--];
            }
        }
    }
}