// Dynamic Programming

/**
 * @param {string} s
 * @return {string}
 */
var longestPalindrome = function(s) {
    var resStr = "";
    if (s == null || s.length == 0) {
        return resStr;
    }
    
    var isPalindromic = function(s) {
        for (var i=0, j=s.length-1; i<=j; i++, j--) {
            if (s[i] !== s[j]) {
                return false;
            }
        }
        return true;
    }
    
    for (var i = 0; i<s.length; i++) {
        for (var j=resStr.length; j<=i; j++) {
            var newSubString = s.slice(i-j, i+1);
            if (isPalindromic(newSubString)) {
                resStr = newSubString;
            }
        }
    }
    
    return resStr;
};