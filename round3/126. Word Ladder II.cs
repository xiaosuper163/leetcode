public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        var hs = new HashSet<string>(wordList);
        hs.Add(beginWord);
        var res = new List<IList<string>>();
        if (!hs.Contains(endWord)) return res;
        
        var queue = new Queue<string>();
        queue.Enqueue(endWord);
        var dist = new Dictionary<string,int>();
        int currDist = 0;
        while (queue.Count != 0) {
            int levelSize = queue.Count;
            for (int i=0; i<levelSize; i++) {
                string currStr = queue.Dequeue();
                if (!dist.ContainsKey(currStr)) {
                    dist[currStr] = currDist;
                }

                for (int j=0; j<currStr.Length; j++) {
                    char[] currCharArray = currStr.ToCharArray();
                    for (char k='a'; k < 'z'; k ++) {
                        currCharArray[j] = k;
                        string newStr = new string(currCharArray);
                        if (hs.Contains(newStr) && !newStr.Equals(currStr)) {
                            queue.Enqueue(newStr);
                            hs.Remove(newStr);
                        }
                    }
                }    
            }
            currDist++;
        }
        
        // foreach (KeyValuePair<string, int> kvp in dist)
        // {
        //     Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        // }
        
        if(!dist.ContainsKey(beginWord)) return res;
        var currRes = new List<string>();
        currRes.Add(beginWord);        
        DFSHelper(beginWord, endWord, dist[beginWord]-1, dist, currRes, res);
        return res;
    }
    
    private void DFSHelper(string currWord, string endWord, int targetDist, Dictionary<string,int> dist, IList<string> currRes, IList<IList<string>> res) {
        if (targetDist == 0) {
            var copied = new List<string>(currRes);
            copied.Add(endWord);
            res.Add(copied);
            return;
        }
        
        for (int j=0; j<currWord.Length; j++) {
            char[] currCharArray = currWord.ToCharArray();
            for (char k='a'; k < 'z'; k ++) {
                currCharArray[j] = k;
                string newStr = new string(currCharArray);
                if (dist.ContainsKey(newStr) && dist[newStr] == targetDist) {
                    currRes.Add(newStr);
                    DFSHelper(newStr, endWord, targetDist-1, dist, currRes, res);
                    currRes.RemoveAt(currRes.Count-1);
                }
            }
        } 
    }
}