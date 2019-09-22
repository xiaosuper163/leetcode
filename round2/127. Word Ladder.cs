public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);
        int res = 0;
        HashSet<string> words = new HashSet<string>(wordList);
        while (queue.Count != 0) {
            int levelSize = queue.Count;
            for (int i=0; i<levelSize; i++) {
                string curr = queue.Dequeue();
                if (curr.Equals(endWord)) return res + 1;
                for (int j=0; j<curr.Length; j++) {
                    char[] newWordChars = curr.ToCharArray();
                    for (char k='a'; k<='z'; k++) {
                        newWordChars[j] = k;
                        string newWord = new string(newWordChars);
                        if (words.Contains(newWord) && !newWord.Equals(curr)) {
                            queue.Enqueue(newWord);
                            words.Remove(newWord);
                        }
                    }
                }
            }
            res ++;
        }
        return 0;
    }
}