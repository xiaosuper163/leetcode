// Dynamic Programming
/**
 * @param {string} s
 * @return {number}
 */
var numDecodings = function(s) {
    if (s.length == 0 || s[0] === '0') {
        return 0;
    }
    if (s.length == 1) {
        return 1;
    }
    var c1=1, c2=1, temp;
    for (var i=2; i<=s.length; i++) {
        if (parseInt(s.slice(i-2,i)) <= 26 && s[i-2] !== '0' && s[i-1] !== '0') {
            temp = c1 + c2;
            c1 = c2;
            c2 = temp;
        } else if (parseInt(s.slice(i-2,i)) <= 26 && s[i-2] !== '0') {
            temp = c1;
            c1 = c2;
            c2 = temp;
        } else if (s[i-1] !== '0') {
            c1 = c2;
        } else {
            return 0;
        }
    }
    return c2;
};