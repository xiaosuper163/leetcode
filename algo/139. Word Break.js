// DFS

/**
 * @param {string} s
 * @param {string[]} wordDict
 * @return {boolean}
 */
var wordBreak = function(s, wordDict) {
    var helper = function(s, collection, index, dict) {
        if (index === s.length) {
            return true;
        }
        
        if (collection.has(index)) {
            return false;
        }
        
        for (var i=index+1; i<=s.length; i++) {
            if (dict.has(s.slice(index,i))) {
                if (helper(s, collection, i, dict)) {
                    return true
                } else {
                    collection.add(i);
                }                
            }
        }
        collection.add(i);
        return false;
    };
    
    var dict = new Set(wordDict);
    var collection = new Set();
    return helper(s, collection, 0, dict);
};