public class Solution {
    public string IntToRoman(int num) {
        var myMap = new Dictionary<int, string>();
        string res = "";
        myMap.Add(1, "I");
        myMap.Add(4, "IV");
        myMap.Add(5, "V");
        myMap.Add(9, "IX");
        myMap.Add(10, "X");
        myMap.Add(40, "XL");
        myMap.Add(50, "L");
        myMap.Add(90, "XC");
        myMap.Add(100, "C");
        myMap.Add(400, "CD");
        myMap.Add(500, "D");
        myMap.Add(900, "CM");
        myMap.Add(1000, "M");
        int[] myArray = new int[] {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        for (int i = 0; i < myArray.Length; i++) {
            if (num == 0) return res;
            for (int j = 0; j < (int) num/myArray[i]; j++) {
                res += myMap[myArray[i]];
            }
            num = num % myArray[i];
        }
        return res;
    }
}