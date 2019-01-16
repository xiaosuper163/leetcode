/**
 * @param {number} n
 * @return {string[]}
 */
var generateParenthesis = function(n) {
    if(!n) {
        return [];
    }

    function dfs(left, right, ans, string) {

        // if the number of remaining ) in ) stack is smaller, then it is illegal
        if (right < left) {
            return;
        }

        // two stacks are both empty, push the string into the answer array
        if ((!left) && (!right)) {
            ans.push(string);
            return;
        }

        // recursive function call
        if (left) {
            dfs(left-1, right, ans, string+"(");
        }
        if (right) {
            dfs(left, right-1, ans, string+")");
        }
    }

    var left = n, right = n;
    var ans = [];
    dfs(left, right, ans, "");

    return ans;
};

console.log(generateParenthesis(3));