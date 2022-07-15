public class Solution {
    public int TotalNQueens(int n) {
        int res = 0;        
        
        bool[] colQ = new bool[n];
        bool[] diaQ1 = new bool[2*n - 1];
        bool[] diaQ2 = new bool[2*n - 1];
                
        DFSHelper(n, 0, colQ, diaQ1, diaQ2, ref res);
        
        return res;
    }
    
    private void DFSHelper(int n, int row, bool[] colQ, bool[] diaQ1, bool[] diaQ2, ref int res) {
        if (row == n) {
            res += 1;            
            return;
        }
        
        for (int j = 0; j < n; j ++) {
            if (colQ[j] || diaQ1[row + j] || diaQ2[j - row + n - 1]) continue;
            colQ[j] = true;
            diaQ1[row + j] = true;
            diaQ2[j - row + n - 1] = true;
            DFSHelper(n, row + 1, colQ, diaQ1, diaQ2, ref res);
            colQ[j] = false;
            diaQ1[row + j] = false;
            diaQ2[j - row + n - 1] = false;
        }        
    }
}