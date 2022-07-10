public class Solution {
    private IList<string> Helper(IList<string> currRes, int index, string digits) {
        if (index == digits.Length) {            
            return currRes;
        }
        
        var nextRes = new List<string>();
        
        foreach(string s in currRes) {
            foreach(char c in GetCharsFromDigit(digits[index] - '0')) {
                nextRes.Add(s + c.ToString());
            }
        }
        
        return Helper(nextRes, index + 1, digits);
    }
    
    private IList<char> GetCharsFromDigit(int num) {
        var res = new List<char>();
        
        if (num == 9) {
            res.Add('w');
            res.Add('x');
            res.Add('y');
            res.Add('z');
        } else if (num == 7) {
            res.Add('p');
            res.Add('q');
            res.Add('r');
            res.Add('s');
        } else if (num == 8) {
            res.Add('t');
            res.Add('u');
            res.Add('v');
        } else {
            for (int i = 0; i < 3; i ++) {
                res.Add((char) ('a' + (i + 3 * (num - 2))));
            }
        }
        
        return res;
    }
    
    public IList<string> LetterCombinations(string digits) {
        if (digits.Length == 0) return new List<string>();
                
        return Helper(new List<string>(){""}, 0, digits);;
    }
}