/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var nextPermutation = function(nums) {
    if (nums.length==0) {
        return [];
    }
    
    var currIndex = nums.length - 1;
    while (currIndex > 0) {      
        if (nums[currIndex] > nums[currIndex-1]) {
            break;
        }
        currIndex--;
    } 
    
    
    if (currIndex > 0) {
        var minIndex = currIndex;
        var currIndex2 = currIndex;
        while (currIndex2 < nums.length) {
            if (nums[currIndex2] > nums[currIndex-1]) {
                min = nums[currIndex2];
                minIndex = currIndex2;
            } else {
                break;
            }            
            currIndex2++;
        }
        // swap the numbers
        var temp = nums[minIndex];
        nums[minIndex] = nums[currIndex-1];
        nums[currIndex-1] = temp;
    }
    
    // swap the numbers in the tail
    var left = currIndex;
    var right = nums.length - 1;
    while (left<right) {
        temp = nums[left];
        nums[left] = nums[right];
        nums[right] = temp;
        left++;
        right--;
    }
};
