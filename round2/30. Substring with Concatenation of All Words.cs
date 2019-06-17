public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        IList<int> res = new List<int>();
        if (s.Length == 0 || words.Length == 0) return res;
        int wordCount = words.Length;
        int helperDictCount;
        int wordLength = words[0].Length;
        Dictionary<string, int> wordDict = new Dictionary<string, int>();
        for (int i=0; i<wordCount; i++) {
            int defaultValue = 0;
            wordDict.TryGetValue(words[i], out defaultValue);
            wordDict[words[i]] = defaultValue + 1;
        }
        for (int offset = 0; offset < wordLength; offset ++) {
            Dictionary<string, int> helperDict = new Dictionary<string, int>();
            int left = offset;
            helperDictCount = 0;
            for (int i=offset; i<=s.Length-wordLength; i+=wordLength) {
                string currWord = s.Substring(i, wordLength);
                if (wordDict.ContainsKey(currWord)){
                    int defaultValue = 0;
                    helperDict.TryGetValue(currWord, out defaultValue);
                    helperDict[currWord] = defaultValue + 1;
                    if (helperDict[currWord] <= wordDict[currWord]) {
                        helperDictCount ++;
                    } else {
                        while (helperDict[currWord] > wordDict[currWord]) {
                            string temp = s.Substring(left, wordLength);
                            helperDict[temp] --;
                            if (helperDict[temp] < wordDict[temp]) helperDictCount --;
                            left += wordLength;
                        }
                    }
                    if (helperDictCount == wordCount) {
                        res.Add(left);
                        helperDict[s.Substring(left, wordLength)] --;
                        helperDictCount --;
                        left += wordLength;
                    }
                } else {
                    helperDict.Clear();
                    helperDictCount = 0;
                    left = i + wordLength;
                }
            }
        }
        return res;
    }
}