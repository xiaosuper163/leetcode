// @9 Binary Search

/**
 * @param {number} x
 * @return {number}
 */
var mySqrt = function(x) {
    var start = 0;
    var end = x;
    while (start+1<end) {
        var mid = Math.floor((end-start)/2) + start;
        if (mid*mid == x) {
            return mid;
        } else if (mid*mid < x) {
            start = mid;
        } else {
            end = mid;
        }
    }
    
    if (end**end <= x) {
        return end;
    } else {
        return start;
    }
};