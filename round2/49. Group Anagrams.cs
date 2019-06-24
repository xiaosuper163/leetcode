public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var res = new List<IList<string>>();
        if (strs.Length == 0) return res;
        var helperDict = new Dictionary<string, List<string>>();
        foreach (var str in strs) {
            string orderedStr = new string (str.OrderBy(c => c).ToArray());
            if (!helperDict.ContainsKey(orderedStr)) {
                helperDict[orderedStr] = new List<string>();
            }
            helperDict[orderedStr].Add(str);
        }
        foreach(KeyValuePair<string, List<string>> entry in helperDict)
        {
            res.Add(entry.Value);
        }
        return res;
    }
}