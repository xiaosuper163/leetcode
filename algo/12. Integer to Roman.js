/**
 * @param {number} num
 * @return {string}
 */
var intToRoman = function(num) {
    var dec2roman = {
        1000: 'M',
        900: 'CM',
        500: 'D',
        400: 'CD',
        100: 'C',
        90: 'XC',
        50: 'L',
        40:'XL',
        10: 'X',
        9: 'IX',
        5: 'V',
        4: 'IV',
        1: 'I'
    };

    var res = '';
    var keys = Object.keys(dec2roman);

    for (var i=keys.length-1; i>=0; i--) {
        tempKey = keys[i];
        for (var n = 0; n < parseInt(num / tempKey); n++) {
            res += dec2roman[tempKey];
        }
        num = num % tempKey;
    }
    return res;
};

console.log(intToRoman(3999));