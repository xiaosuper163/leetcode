public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        int idxOfFirstWordInNewLine = 0, idxStartWord, idxEndWord;
        IList<string> res = new List<string>();
        
        while (idxOfFirstWordInNewLine < words.Length) {
            idxStartWord = idxOfFirstWordInNewLine;
            idxEndWord = idxOfFirstWordInNewLine;
            int currLineLength = 0;
            int widthLeft = maxWidth;
            while (idxEndWord < words.Length && words[idxEndWord].Length <= widthLeft) {
                currLineLength += words[idxEndWord].Length;
                widthLeft -= words[idxEndWord].Length + 1;
                idxEndWord ++;
            }
            idxOfFirstWordInNewLine = idxEndWord;
            idxEndWord --;
            
            int numEmptySpaces = maxWidth - currLineLength;
            string currStr = "";
            
            if (idxOfFirstWordInNewLine == words.Length) { // last line
                for (int i = idxStartWord; i <= idxEndWord; i++) {
                    currStr += words[i];
                    if (i != idxEndWord) {
                        currStr += " ";
                    }
                }
                
                for (int i = 0; i < numEmptySpaces - (idxEndWord - idxStartWord); i ++) {
                    currStr += " ";
                }
            } else {
                int numSpaceBetweenWords = idxEndWord == idxStartWord ? numEmptySpaces : numEmptySpaces / (idxEndWord - idxStartWord);
                for (int i = idxStartWord; i <= idxEndWord; i++) {
                    currStr += words[i];
                    if (i == idxEndWord && idxEndWord != idxStartWord) break;
                    for (int j = 0 ; j < numSpaceBetweenWords; j ++) {
                        currStr += " ";
                    }
                    if (idxEndWord != idxStartWord && numEmptySpaces % (idxEndWord - idxStartWord) != 0) {
                        currStr += " ";
                        numEmptySpaces --;
                    }
                }
            }
            
            res.Add(currStr);
            
        }
        
        return res;
    }
}