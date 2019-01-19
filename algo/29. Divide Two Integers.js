// Binary Search?

/**
 * @param {number} dividend
 * @param {number} divisor
 * @return {number}
 */
var divide = function(dividend, divisor) {
    var isNeg = dividend<0 != divisor<0; //? 0 : 1
    dividend = Math.abs(dividend);
    divisor = Math.abs(divisor);
    var left = dividend;
    var base = 1;
    var toSubtract = divisor;
    var ans = 0;
    while (left >= toSubtract) {
        left -= toSubtract;
        ans += base;
        base += base;
        toSubtract += toSubtract;
        
        // when the result is really close
        // we have to slow down the decreasing velocity
        if (left < toSubtract) {
            while (left >= divisor) {
                left -= divisor;
                ans += 1;
            }
        }
    }
    
    if (isNeg) {
        return Math.max(-ans, -Math.pow(2,31));
    } else {
        return Math.min(ans, Math.pow(2,31)-1);
    }
            
};

console.log(divide(-2147483648,1));