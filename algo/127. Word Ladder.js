// @9 BFS

/**
 * @param {string} beginWord
 * @param {string} endWord
 * @param {string[]} wordList
 * @return {number}
 */
var ladderLength = function(beginWord, endWord, wordList) {
    var validDiff = function(word1, word2) {
        var numDiff = 0;
        for (var i = 0; i < word1.length; i ++) {
            if (word1[i] != word2[i]) {
                numDiff++;
            }
            if (numDiff > 1) {
                return false;
            }
        }
        if (numDiff == 0) {
            return false;
        }
        return true;
    }
    
    if (beginWord==endWord) {
        return 1;
    }
    
    var queue = [beginWord];
    // use a hashset to store which word has been visited
    var visited = {};
    visited[beginWord] = 1;
    // avoid changing the orignal word list
    var ans = 1;
    while(queue.length != 0) {
        console.log(visited);
        ans ++;
        var levelSize = queue.length;        
        for (var i = 0; i < levelSize; i++) {
            var currNode = queue.shift();
            for (var word of wordList) {                          
                if (validDiff(currNode, word)) {
                    // come across the target word
                    if (word == endWord) {
                        return ans;
                    }
                    // avoid pushing the same word into the queue
                    if (visited.hasOwnProperty(word)) {
                        continue;
                    }
                    queue.push(word);
                    visited[word] = 1;
                }
            }
        }
    }
    return 0;
};