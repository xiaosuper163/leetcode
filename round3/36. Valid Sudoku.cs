public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var hs = new HashSet<string>();
        
        for (int i = 0; i < board.Length; i ++) {
            for (int j = 0; j < board[0].Length; j ++) {
                if (board[i][j] == '.') continue;
                
                string iaxis = "i" + i.ToString() + "-" + board[i][j].ToString();
                string jaxis = "j" + j.ToString() + "-" + board[i][j].ToString();
                string cell = (i/3).ToString() + "-" + (j/3).ToString() + "-" + board[i][j].ToString();
                
                if (hs.Contains(iaxis) || hs.Contains(jaxis) || hs.Contains(cell)) return false;
                hs.Add(iaxis);
                hs.Add(jaxis);
                hs.Add(cell);
            }
        }
        
        return true;
    }
}