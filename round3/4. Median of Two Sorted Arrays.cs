public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length, n = nums2.Length;
        if ((m + n) % 2 == 1) {
            return (double)FindKthSortedArrays(nums1, 0, nums2, 0, (m+n+1)/2);
        } else {
            return (FindKthSortedArrays(nums1, 0, nums2, 0, (m+n)/2) + FindKthSortedArrays(nums1, 0, nums2, 0, (m+n)/2+1)) / 2.0;
        }
    }
    
    public int FindKthSortedArrays(int[] nums1, int index1, int[] nums2, int index2, int k) {
        
        if (nums1.Length == index1) return nums2[index2 + k - 1]; // == could work as well. It doesn't have to be <=
        if (nums2.Length == index2) return nums1[index1 + k - 1];
        
        if (k == 1) {
            return nums1[index1] < nums2[index2] ? nums1[index1] : nums2[index2];
        }
        
        int key1 = int.MaxValue, key2 = int.MaxValue;
        
        if (nums1.Length - index1 > k/2 - 1) {
            key1 = nums1[index1 + k/2 - 1];
        }
        
        if (nums2.Length - index2 > k/2 - 1) {
            key2 = nums2[index2 + k/2 - 1];
        }
        
        if (key1 < key2) {
            return FindKthSortedArrays(nums1, index1 + k/2, nums2, index2, k - k/2);
        } else {
            return FindKthSortedArrays(nums1, index1, nums2, index2 + k/2, k - k/2);
        }
    }
}