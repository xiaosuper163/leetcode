public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var queue = new Queue<string>();
        var hs = new HashSet<string>(wordList);
        queue.Enqueue(beginWord);
        int res = 0;
        
        if (!hs.Contains(endWord)) return 0;
        
        while (queue.Count != 0) {
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; i ++) {
                string currStr = queue.Dequeue();
                if (currStr.Equals(endWord)) return res + 1;
                for (int j = 0 ; j < currStr.Length; j ++) {
                    char[] currCharArray = currStr.ToCharArray();
                    for (char k = 'a'; k <= 'z'; k ++) {
                        currCharArray [j] = k;
                        string newStr = new string(currCharArray);
                        if (hs.Contains(newStr) && !newStr.Equals(currStr)) {
                            queue.Enqueue(newStr);
                            hs.Remove(newStr); // !!! remember to remove. infinite loop otherwise
                        }
                    }
                }
            }
            res ++;
        }
        
        return 0;
    }
}