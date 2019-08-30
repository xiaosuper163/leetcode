public class TreeNode {
    public TreeNode[] children;
    public string currStr {get; set;}
    public TreeNode() {
        children = new TreeNode[26];
        currStr = "";
    }
}

public class Trie {
    public TreeNode root;
    
    public Trie() {
        root = new TreeNode();
    }
    
    public void Insert(string word) {
        TreeNode cursor = root;
        for (int i=0; i<word.Length; i++) {
            int index = word[i] - 'a';
            if (cursor.children[index] == null) cursor.children[index] = new TreeNode();
            cursor = cursor.children[index];
        }
        cursor.currStr = word;
    }
}

public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        var res = new List<string>();
        if (board.Length == 0 || board[0].Length == 0) return res;
        var trie = new Trie();
        foreach (var word in words) {
            trie.Insert(word);
        }
        bool[][] visited = new bool[board.Length][];
        for (int i=0; i<visited.Length; i++) {
            visited[i] = new bool[board[0].Length];
            for (int j=0; j<visited[0].Length; j++) {
                visited[i][j] = false;
            }
        }
        for (int i=0; i<board.Length; i++) {
            for (int j=0; j<board[0].Length; j++) {
                if (trie.root.children[board[i][j]-'a'] != null)
                    BackTrack(board, i, j, visited, trie.root.children[board[i][j]-'a'], res);
            }
        }
        return res;
    }
    private void BackTrack(char[][] board, int i, int j, bool[][] visited, TreeNode p, List<string> res) {
        if (p.currStr.Length != 0) {
            res.Add(p.currStr);
            p.currStr = "";
        }
        visited[i][j] = true;
        List<List<int>> vectors = new List<List<int>>() {
            new List<int>(){0,1},
            new List<int>(){0,-1},
            new List<int>(){1,0},
            new List<int>(){-1,0}
        };
        foreach (var v in vectors) {
            int x = v[0] + i, y = v[1] + j;
            if (x>=0 && x<board.Length && y>=0 && y<board[0].Length && visited[x][y]!=true && p.children[board[x][y]-'a']!=null) {
                BackTrack(board, x, y, visited, p.children[board[x][y]-'a'], res);
            }
        }
        visited[i][j] = false;
    }
}