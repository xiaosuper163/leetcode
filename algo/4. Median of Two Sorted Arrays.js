// @9 Array

/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function(nums1, nums2) {
    var helper = function(nums1, index1, nums2, index2, k) {
        // if the answer is in nums2
        if (index1 > nums1.length -1) {
            return nums2[index2+k-1];
        }
        // if the answer is in nums1
        if (index2 > nums2.length-1) {
            return nums1[index1+k-1];
        }
        // if k has been decreased to 1
        if (k==1) {
            return Math.min(nums1[index1], nums2[index2]);
        }
        // add Infinity to the bottom of two arrays
        var mid1 = Infinity, mid2 = Infinity;
        // compare two k/2 indexed values to decide
        // which k/2 useless values need to remove
        if (index1+Math.floor(k/2)-1 < nums1.length) {
            mid1 = nums1[index1+Math.floor(k/2)-1];
        }
        if (index2+Math.floor(k/2)-1 < nums2.length) {
            mid2 = nums2[index2+Math.floor(k/2)-1];
        }
        if (mid1 < mid2) {
            return helper(nums1, index1+Math.floor(k/2), nums2, index2, k-Math.floor(k/2));
        } else {
            return helper(nums1, index1, nums2, index2+Math.floor(k/2), k-Math.floor(k/2));
        }
    };
    // consider both scienarios, even length or odd length
    var mid1 = Math.floor((nums1.length+nums2.length+1)/2);
    var mid2 = Math.floor((nums1.length+nums2.length+2)/2);
    if(mid1 == mid2) {
        return helper(nums1, 0, nums2, 0, mid1);
    }
    return (helper(nums1, 0, nums2, 0, mid1) + helper(nums1, 0, nums2, 0, mid2)) / 2.0;
};