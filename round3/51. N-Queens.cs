public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        IList<IList<string>> res = new List<IList<string>>();        
        
        bool[] colQ = new bool[n];
        bool[] diaQ1 = new bool[2*n - 1];
        bool[] diaQ2 = new bool[2*n - 1];
                
        char[][] matrix = new char[n][];
        for (int i = 0; i < n; i ++) {
            matrix[i] = new char[n];
            for (int j = 0; j < n; j ++) {
                matrix[i][j] = '.';
            }
        }
        
        DFSHelper(n, 0, colQ, diaQ1, diaQ2, matrix, res);
        
        return res;
    }
    
    private void DFSHelper(int n, int row, bool[] colQ, bool[] diaQ1, bool[] diaQ2, char[][] matrix, IList<IList<string>> res) {
        if (row == n) {
            IList<string> currRes = new List<string>();
            for (int i = 0; i < n; i ++) {
                string currStr = "";
                for (int j = 0; j < n; j ++) {
                    currStr += matrix[i][j].ToString();
                }
                
                currRes.Add(currStr);
            }
            res.Add(currRes);            
            return;
        }
        
        for (int j = 0; j < n; j ++) {
            if (colQ[j] || diaQ1[row + j] || diaQ2[j - row + n - 1]) continue;
            colQ[j] = true;
            diaQ1[row + j] = true;
            diaQ2[j - row + n - 1] = true;
            matrix[row][j] = 'Q';
            DFSHelper(n, row + 1, colQ, diaQ1, diaQ2, matrix, res);
            colQ[j] = false;
            diaQ1[row + j] = false;
            diaQ2[j - row + n - 1] = false;
            matrix[row][j] = '.';
        }        
    }
    
}


// public class Solution {
//     public IList<IList<string>> SolveNQueens(int n) {
//         IList<IList<int>> res = new List<IList<int>>();        
//         DFSHelper(n, new List<int>(), res);
//         Console.WriteLine(res.Count);
//         return Draw(res);
//     }
    
//     private void DFSHelper(int n, IList<int> currRes, IList<IList<int>> res) {
//         if (currRes.Count == n) {
//             res.Add(new List<int>(currRes));
//             return;
//         }
        
//         for (int i = 0; i < n; i++) {
//             currRes.Add(i);
//             if (Validate(currRes)) {
//                 DFSHelper(n, currRes, res);
//             }
//             currRes.RemoveAt(currRes.Count-1);
//         }
//     }
    
//     // validate if the last Queen doesn't break the rule
//     private bool Validate(IList<int> currRes) { 
//         // 0,0 0,1 0,2 0,3
//         // 1,0 1,1 1,2 1,3
//         // 2,0 2,1 2,2 2,3
//         // 3,0 3,1 3,2 3,3
//         if (currRes.Count == 1) return true;
//         int lastX = currRes.Count-1;
//         int lastY = currRes.Last(); 
        
//         for (int i=0; i<lastX; i++) {
//             int currX = i, currY = currRes[i];
//             if (currX == lastX || currY == lastY) return false; // Appears on the same row/column 
//             if (lastY - currY == lastX - currX) return false;
//             if (lastY - currY == (lastX - currX) * -1) return false;
//         }
        
//         return true;
//     }
    
//     private IList<IList<string>> Draw(IList<IList<int>> res) {
//         var ret = new List<IList<string>>();
//         for (int i=0; i<res.Count; i++) {
//             var row = res[i];
//             var currRes = new List<string>();
//             for (int j=0; j < row.Count; j++) {
//                 currRes.Add(DrawSingleRow(row[j], row.Count));
//             }
//             ret.Add(currRes);
//         }
//         return ret;
//     }
    
//     private string DrawSingleRow(int x, int len) {
//         StringBuilder sb = new StringBuilder();
//         for (int i=0; i<len; i++) {
//             sb.Append('.');
//         }
//         sb[x] = 'Q';
//         return sb.ToString();
//     }
    
// }


