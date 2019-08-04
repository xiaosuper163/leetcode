public class Solution {
    private IList<string> Helper(string s, IList<string>wordDict, Dictionary<string, List<string>> mappings) {
        if (mappings.ContainsKey(s)) return mappings[s];
        if (s.Length == 0) return new List<string>(){""};
        List<string> res = new List<string>();
        foreach (string word in wordDict) {
            if (s.Length < word.Length || !s.Substring(0, word.Length).Equals(word)) continue;
            var mem = Helper(s.Substring(word.Length), wordDict, mappings);
            foreach (string child in mem) {
                res.Add(word + ((child.Length==0 ? "" : " ") + child));
            }
        }
        mappings[s] = res;
        return res;
    }
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        var mappings = new Dictionary<string, List<string>>();
        return Helper(s, wordDict, mappings);
    }
}