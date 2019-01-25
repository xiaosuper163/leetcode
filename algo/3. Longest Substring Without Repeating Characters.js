// dynamic programming

/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    if (s == null || s.length == 0) {
        return 0;
    }
    var resStr = s[0];
    
    var hasRepeatingCharacters = function(s) {
        var set = new Set(s.split(""));
        return !(set.size == s.length);
    }
    
    for (var i = 1; i<s.length; i++) {
        var newSubString = s.slice(i-resStr.length, i+1);
        if (!hasRepeatingCharacters(newSubString)) {
            resStr = newSubString;
        }
    }
    
    
    return resStr.length;
};