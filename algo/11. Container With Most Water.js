/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function(height) {
    var calcArea = function(index1, index2) {
        return (index2-index1)*Math.min(height[index1], height[index2]);
    };

    if (height.length < 2) {
        return 0;
    }

    var res = calcArea(0,1);
    var i = 1;
    while (i<height.length-1) {
        for (var j=0; j<=i; j++) {
            res = calcArea(j, i+1) > res ? calcArea(j, i+1) : res;
        }

        i++;
    }
    return res;
};

console.log(maxArea([1,8,6,2,5,4,8,3,7]));