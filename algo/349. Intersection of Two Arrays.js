// @9 Array
// my solution is very slow, with O(1) extra space
// other two solutions; hashmap (fastest) or sort one array + binary search

/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var intersection = function(nums1, nums2) {
    nums1.sort(function(a,b){return a-b;});
    nums2.sort(function(a,b){return a-b;});
    res = {};
    var i=0, j=0;
    while (i<nums1.length && j<nums2.length) {
        if (nums1[i] < nums2[j]) {
            i++;
        } else if (nums1[i] > nums2[j]) {
            j++;
        } else {
            res[nums1[i++]] = 1;
        }
    }
    return Object.keys(res);
};