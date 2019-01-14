/**
 * @param {string} digits
 * @return {string[]}
 */
var letterCombinations = function(digits) {
    num2char = {
        2: ['a','b','c'],
        3: ['d','e','f'],
        4: ['g','h','i'],
        5: ['j','k','l'],
        6: ['m','n','o'],
        7: ['p','q','r','s'],
        8: ['t','u','v'],
        9: ['w','x','y','z']
    };

    if (digits.length==0) {
        return [];
    }

    var prevRes = [''];
    var i = 0;
    while (i<digits.length) {
        // console.log(prevRes);
        var tempRes = [];
        var newCharSet = num2char[parseInt(digits.charAt(i))];
        for (var j=0; j<prevRes.length; j++) {
            for (var k=0; k<newCharSet.length; k++) {
                var tempStr = prevRes[j] + newCharSet[k];
                tempRes.push(tempStr);
                // console.log(tempRes);
            }
        }
        prevRes = tempRes;

        i++;
    }
    return prevRes;

};

console.log(letterCombinations(""));