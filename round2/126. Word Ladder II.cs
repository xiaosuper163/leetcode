public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        Queue<List<string>> paths = new Queue<List<string>>();
        paths.Enqueue(new List<string>{beginWord});
        HashSet<string> dict = new HashSet<string>(wordList);
        HashSet<string> words = new HashSet<string>();
        var res = new List<IList<string>>();
        int minLevel = int.MaxValue;
        int level = 1;
        while (paths.Count != 0) {
            int levelSize = paths.Count;
            List<string> path = paths.Dequeue();
            if (path.Count > level) {
                foreach(string word in words) dict.Remove(word);
                words.Clear();
                level = path.Count;
                if (level > minLevel) break;
            }
            string curr = path[path.Count-1];
            for (int j=0; j<curr.Length; j++) {
                char[] newWordChars = curr.ToCharArray();
                for (char c='a'; c<='z'; c++) {
                    newWordChars[j] = c;
                    string newWord = new string(newWordChars);
                    if (!dict.Contains(newWord)) continue;
                    //if (curr.Equals("log")) Console.WriteLine($"{curr} {newWord}");
                    words.Add(newWord);
                    var newPath = new List<string>(path);
                    newPath.Add(newWord);
                    if (newWord.Equals(endWord)) {
                        minLevel = Math.Min(minLevel, level);
                        if (minLevel == level) res.Add(newPath);
                    } else {
                        paths.Enqueue(newPath);
                    }
                }
            }
        }
        return res;
    }
}