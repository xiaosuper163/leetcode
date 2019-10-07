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
                foreach(string word in words) dict.Remove(word); // we must remove the word after each level. Because in the same level, the same word can be the last word of multiple paths.
                words.Clear();
                level = path.Count;
                if (level > minLevel) break; // as long as the minLevel is set, we don't need to process the path with more levels.
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

/*
public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        var res = new List<IList<string>>();
        var hs = new HashSet<string>(wordList);
        if (!hs.Contains(endWord)) return res;
        var pathQ = new Queue<IList<string>>(){};
        pathQ.Enqueue(new List<string>(){beginWord});
        int minLevel = 0;
        int currLevel = 1;
        int wordSize = beginWord.Length;
        var toRemove = new List<string>();
        while(pathQ.Count != 0) {
            int levelSize = pathQ.Count;
            if (currLevel == minLevel) break;
            foreach(string toRemoveWord in toRemove) {
                hs.Remove(toRemoveWord);
            }
            toRemove.Clear();
            for (int i=0; i<levelSize; i++) {
                var currPath = pathQ.Dequeue();
                for (int j=0; j<wordSize; j++) {
                    for (char k = 'a'; k <= 'z'; k++) {
                        char[] lastWordChars = currPath[currPath.Count-1].ToCharArray();
                        lastWordChars[j] = k;
                        string newWord = new string(lastWordChars);
                        if (hs.Contains(newWord) || newWord.Equals(endWord)) {
                            var newPath = new List<string>(currPath);
                            newPath.Add(newWord);
                            toRemove.Add(newWord);
                            if (newWord.Equals(endWord)) {
                                res.Add(newPath);
                                minLevel = newPath.Count;
                            } else {
                                pathQ.Enqueue(newPath);
                            }
                        }
                    }
                }
            }
            currLevel++;
        }
        return res;
    }
} */