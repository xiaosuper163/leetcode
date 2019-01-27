/**
 * @param {number} x
 * @return {number}
 */
var reverse = function(x) {
    if (x==0) {
        return 0;
    }
    
    var resStr = "";
    var leadingSymbol = null;
    if (x<0) {
        leadingSymbol = '-';
        x = Math.abs(x);
    }
    
    while(x>0) {
        resStr += String(x%10);
        x = (x-(x%10)) / 10;
    }
    
    if (leadingSymbol) {
        resStr = leadingSymbol + resStr;
    }
    if (resStr > Math.pow(2,31) - 1 || resStr < -Math.pow(2,31)) {
        return 0;
    }
    
    return parseInt(resStr);
};