// @9 DFS

/**
 * @param {string} s
 * @return {string[][]}
 */
var partition = function(s) {
    var isPalindrome = function(str) {
        for (var i = 0, j = str.length-1; i<=j; i++, j--) {
            if (str[i] != str[j]) {
                return false;
            }
        }
        
        return true;
    };
    
    var helper = function(res, partition, index) {
        // make a deep copy
        var partition = Array.from(partition);
        if (index >= s.length) {
            // only push to the res while reaching the end of the string
            res.push(partition);
            return;
        }
        
        for (var i=index; i<s.length; i++) {
            var substring = s.slice(index, i+1);
            if (!isPalindrome(substring)) {
                continue;
            }
            
            partition.push(substring);
            helper(res, partition, i+1);
            partition.pop();
        }
    };
    
    
    var res = [];
    if (s.length == 0) {
        return res;
    }
    
    helper(res, [], 0);
    return res;
};