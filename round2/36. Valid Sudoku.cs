public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> hs = new HashSet<string>();
        for (int i=0; i<9; i++) {
            for (int j=0; j<9; j++) {
                string tmp = board[i][j].ToString();
                if (!tmp.Equals(".")) {
                    if (!hs.Add(string.Format("{0}r{1}", i, tmp)) ||
                        !hs.Add(string.Format("{0}c{1}", j, tmp)) ||
                        !hs.Add(string.Format("{0}-{1}b{2}", i/3, j/3, tmp))) {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}