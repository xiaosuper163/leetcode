public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (digits.Length == 0) return new List<string>();
        var preRes = new List<string>(){""};
        var helperDict = new Dictionary<char, string>() {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };
        for (int i=0; i<digits.Length; i++) {
            string currOptions = helperDict[digits[i]];
            var currRes = new List<string>();
            for (int j=0; j<preRes.Count; j++) {
                for (int k=0; k<currOptions.Length; k++) {
                    currRes.Add(preRes[j]+currOptions[k]);
                }
            }
            preRes = currRes;
        }
        return preRes;
    }
}