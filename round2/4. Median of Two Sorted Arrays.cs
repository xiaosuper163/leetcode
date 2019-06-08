public class Solution {
    private int Helper(int[] nums1, int index1, int[] nums2, int index2, int k) {
        if (index1 > nums1.Length - 1) {
            return nums2[k+index2-1];
        }
        if (index2 > nums2.Length - 1) {
            return nums1[k+index1-1];
        }
        if (k == 1) {
            return nums1[index1] < nums2[index2] ? nums1[index1] : nums2[index2];
        }
        int mid1 = int.MaxValue, mid2 = int.MaxValue;
        if (index1+(int) k/2-1 < nums1.Length) {
            mid1 = nums1[index1+(int) k/2-1];
        }
        if (index2+(int) k/2-1 < nums2.Length) {
            mid2 = nums2[index2+(int) k/2-1];
        }
        if (mid1 < mid2) {
            return Helper(nums1, index1+(int) k/2, nums2, index2, k-(int) k/2);
        } else {
            return Helper(nums1, index1, nums2, index2+(int) k/2, k-(int) k/2);
        }
    }
    
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int mid1 = (int) (nums1.Length + nums2.Length + 1) / 2;
        int mid2 = (int) (nums1.Length + nums2.Length + 2) / 2;
        if (mid1 == mid2) {
            return Helper(nums1, 0, nums2, 0, mid1);
        } else {
            return (Helper(nums1, 0, nums2, 0, mid1) + Helper(nums1, 0, nums2, 0, mid2)) / 2.0;
        }
    }
}