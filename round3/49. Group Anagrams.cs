public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        var dict = new Dictionary<string, IList<string>>();
        
        foreach (string str in strs) {
            
            int[] cntLetters = new int[26];
            
            for (int i = 0; i < str.Length; i ++) {
                cntLetters[str[i] - 'a'] += 1;
            }
            
            var sb = new StringBuilder();
            
            for (int i = 0; i < 26; i ++) {
                sb.Append($"{'a' + i}{cntLetters[i]}");
            }
            
            string currStr = sb.ToString();
            
            if (dict.ContainsKey(currStr)) {
                dict[currStr].Add(str);
            } else {
                dict[currStr] = new List<string>() {str};
            }
        }
        
        return dict.Values.ToList();
    }
}